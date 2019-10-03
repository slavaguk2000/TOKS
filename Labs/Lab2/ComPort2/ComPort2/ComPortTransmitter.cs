using System;
using System.IO.Ports;
using System.Threading;
using System.Timers;

namespace ComPort
{
    class SendException : Exception
    { }

    class ComPortTransmitter
    {
        private const int timeout = 1000;
        private const byte dataSize = 5;
        private Thread reciveThread;
        private SerialPort serialPort;
        private MainForm mainForm;
        private bool timerIsStart;
        private bool isRTS, isChecked;
        string recivingMessage;
        bool inSendProcess = false;

        public delegate void ComPortMessageHandler(string message);

        public event ComPortMessageHandler DataRecived;

        public ComPortTransmitter(string port, MainForm mainForm)
        {
            this.mainForm = mainForm;
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();
            reciveThread = new Thread(new ThreadStart(reciverLoop));
            isRTS = mainForm.isRTS();
            setChecked(mainForm.getChecked());
            recivingMessage = "";
        }

        public void setIsRTS(bool flag)
        {
            isRTS = flag;
        }

        public void setChecked(bool flag)
        {
            isChecked = flag;
            if (isChecked)
            {
                serialPort.ErrorReceived -= serialPort_ErrorReceived;
                serialPort.DataReceived -= serialPort_DataReceived;
                reciveThread = new Thread(new ThreadStart(reciverLoop));
                reciveThread.Start();
                recivingMessage = "";
            }
            else
            {
                serialPort.ReadExisting();
                serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                reciveThread.Abort();
            }  
        }

        public void close()
        {
            reciveThread.Abort();
            serialPort.Close();
        }

        private bool sendPackage(string data)
        {
            if (data.Length > dataSize) throw new Exception("Too large data");
            return sendData(mainForm.packager.byteStaffing(mainForm.packager.package(data)));
        }

        public bool sendPackageData(string message)
        {
            for (int i = 0; i < message.Length; i+=dataSize)
            {
                if (!sendPackage(message.Substring(i, Math.Min(message.Length - i, dataSize)))) return false;
            }
            if (message.Length % dataSize == 0)
                if (!sendPackage("")) return false;
            return true;
        }

        public bool sendData(string message)
        {
            if (isChecked)
            {
                return checkedSendData(message);
            }
            else
            {
                return uncheckedSendData(message);
            }
        }

        private System.Timers.Timer startTimer()
        {
            timerIsStart = true;
            System.Timers.Timer timer = new System.Timers.Timer(timeout);
            timer.Elapsed += stopTimer;
            timer.AutoReset = false;
            timer.Enabled = true;
            return timer;
        }

        private void stopTimer(object source, ElapsedEventArgs e)
        {
            timerIsStart = false;
        }

        private void printMessage()
        {
            mainForm.addOutputString(recivingMessage);
            mainForm.addControlDebugString("message was got");
            recivingMessage = "";
        }

        private void reciveChar()
        {
            try
            {
                char recived = (char)serialPort.ReadChar();
                mainForm.addControlDebugString("char was got");
                if (recived == '\0') printMessage();
                else recivingMessage += recived;
            }
            catch (TimeoutException)
            {
                recivingMessage = "";
                mainForm.addControlDebugString("read char timeout");
            }
            catch (Exception)
            {
                recivingMessage = "";
                mainForm.addControlDebugString("read char error");
            }
        }

        private void flushRecivingMessage()
        {
            if (!recivingMessage.Equals("") && recivingMessage.Length > 0)
            {
                mainForm.addOutputString(recivingMessage);                
            }
            recivingMessage = "";
        }

        private bool waitCTSRecive()
        {
            System.Timers.Timer timer = startTimer();
            while (serialPort.CtsHolding)
            {
                if (!timerIsStart)
                {
                    flushRecivingMessage();
                    mainForm.addControlDebugString("wait CTS timeout");
                    serialPort.RtsEnable = false;
                    mainForm.addControlDebugString("RTS reset");
                    inSendProcess = false;
                    return false;
                }
            }
            deleteTimer(timer);
            return true;
        }

        private void resiveRTSChecked()
        {
            if (serialPort == null) return; 
            if (serialPort.CtsHolding && !inSendProcess)
            {
                serialPort?.ReadExisting();
                inSendProcess = true;
                mainForm.addControlDebugString("CTS set");
                serialPort.RtsEnable = true;
                mainForm.addControlDebugString("RTS set");
                if (!waitCTSRecive()) return;
                mainForm.addControlDebugString("CTS reset");
                serialPort.RtsEnable = false;
                mainForm.addControlDebugString("RTS reset");
                reciveChar();
                inSendProcess = false;
            }
        }

        private void deleteTimer(System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Dispose();
        }

        private bool waitDSRRecive()
        {
            System.Timers.Timer timer = startTimer();
            while (serialPort.DsrHolding)
            {
                if (!timerIsStart)
                {
                    flushRecivingMessage();
                    mainForm.addControlDebugString("wait DSR timeout");
                    serialPort.DtrEnable = false;
                    mainForm.addControlDebugString("DTR reset");
                    inSendProcess = false;
                    return false;
                }
            }
            deleteTimer(timer);
            return true;
        }

        private void resiveDTRChecked()
        {
            if (serialPort.DsrHolding && !inSendProcess)
            {
                serialPort?.ReadExisting();
                inSendProcess = true;
                mainForm.addControlDebugString("DSR set");
                serialPort.DtrEnable = true;
                mainForm.addControlDebugString("DTR set");
                if (!waitDSRRecive()) return;
                mainForm.addControlDebugString("DSR reset");
                serialPort.DtrEnable = false;
                mainForm.addControlDebugString("DTR reset");
                reciveChar();
                inSendProcess = false;
            }
        }
        
        private void reciverLoop()
        {
            try
            {
                while (isChecked)
                {
                    if(!inSendProcess)
                    {
                        if (isRTS) resiveRTSChecked();
                        else resiveDTRChecked();
                    }
                }
            }
            catch (ThreadAbortException) { }
        }
        
        private void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            mainForm.addControlDebugString("Receive error");
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string message = serialPort.ReadLine();
            DataRecived?.Invoke(message);
            mainForm.addOutputString(message);
            mainForm.addControlDebugString("message was got");
        }

        private void sendChar(char a)
        {
            try
            {
                serialPort.Write(new char[] { a }, 0, 1);
                mainForm.addControlDebugString("char was sent");
            }
            catch (TimeoutException)
            {
                flushRecivingMessage();
                mainForm.addControlDebugString("char wasn't sent");
                throw new SendException();
            }
        }

        private void waitCTS(bool state)
        {
            System.Timers.Timer timer = startTimer();
            while (serialPort.CtsHolding != state)
            {
                if (!timerIsStart)
                {
                    mainForm.addControlDebugString("wait CTS timeout");
                    if (state)
                    {
                        serialPort.RtsEnable = false;
                        mainForm.addControlDebugString("RTS reset");
                    }
                    throw new SendException();
                }
            }
            deleteTimer(timer);
        }

        private void sendRTSCheckedData(char message)
        {
            serialPort.RtsEnable = true;
            mainForm.addControlDebugString("RTS set");
            waitCTS(true);
            mainForm.addControlDebugString("CTS set");
            serialPort.RtsEnable = false;
            mainForm.addControlDebugString("RTS reset");
            waitCTS(false);
            mainForm.addControlDebugString("CTS reset");
            sendChar(message);
        }

        private void waitDSR(bool state)
        {
            System.Timers.Timer timer = startTimer();
            while (serialPort.DsrHolding != state)
            {
                if (!timerIsStart)
                {
                    mainForm.addControlDebugString("wait DSR timeout");
                    if(state)
                    {
                        serialPort.DtrEnable = false;
                        mainForm.addControlDebugString("DTR reset");
                    }
                    throw new SendException();
                }
            }
            deleteTimer(timer);
        }

        private void sendDTRCheckedData(char message)
        {
            serialPort.DtrEnable = true;
            mainForm.addControlDebugString("DTR set");
            waitDSR(true);
            mainForm.addControlDebugString("DSR set");
            serialPort.DtrEnable = false;
            mainForm.addControlDebugString("DTR reset");
            waitDSR(false);
            mainForm.addControlDebugString("DSR reset");
            sendChar(message);
        }

        private bool isChanelFree()
        {
            System.Timers.Timer timer = startTimer();
            while (inSendProcess)
            {
                if (!timerIsStart)
                {
                    mainForm.addControlDebugString("wait Send Process timeout");
                    return false;
                }
            }
            deleteTimer(timer);
            return true;
        }

        private bool sendMessageForBytes(string message)
        {
            try
            {
                foreach (char a in message)
                {
                    if (isRTS) sendRTSCheckedData(a);
                    else sendDTRCheckedData(a);
                }
                return true;
            }
            catch (SendException e)
            {
                mainForm.addControlDebugString("error in sending");
                return false;
            }
        }

        private void sendEndOfMessage()
        {
            try
            {
                if (isRTS) sendRTSCheckedData('\0');
                else sendDTRCheckedData('\0');
                mainForm.addControlDebugString("message was sent");
            }
            catch (SendException e)
            {
                mainForm.addControlDebugString("message wasn't sent");
            }
        }

        private bool checkedSendData(string message)
        {
            if (!isChanelFree()) return false;
            inSendProcess = true;
            bool answer = sendMessageForBytes(message);
            sendEndOfMessage();
            inSendProcess = false;
            return answer;
        }

        private bool uncheckedSendData(string message)
        {
            try
            {
                serialPort.WriteLine(message);
                while (serialPort.BytesToWrite > 0) ;
                mainForm.addControlDebugString("message was sent");
                return true;
            }
            catch (Exception ex)
            {
                mainForm.addControlDebugString("Transmit error");
                return false;
            }
        }
     }
}