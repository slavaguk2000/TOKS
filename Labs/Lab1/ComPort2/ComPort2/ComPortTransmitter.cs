using System;
using System.IO.Ports;
using System.Threading;
using System.Timers;

namespace ComPort
{
    class ComPortTransmitter
    {
        private const int timeout = 10000000;
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
            serialPort.Open();//TODO: close on the end of application
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
            }
            else
            {
                serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                reciveThread.Abort();
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

        public void reciveChar()
        {
            try
            {
                char recived = (char)serialPort.ReadChar();
                mainForm.addControlDebugString("char was got");
                if (recived == '\0') printMessage();
                recivingMessage += recived;
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

        public void resiveRTSChecked()
        {
            if (serialPort.CtsHolding && !inSendProcess)
            {
                inSendProcess = true;
                mainForm.addControlDebugString("CTS set");
                serialPort.RtsEnable = true;
                mainForm.addControlDebugString("RTS set");
                System.Timers.Timer timer = startTimer();
                while (serialPort.CtsHolding)
                {
                    if (!timerIsStart)
                    {
                        mainForm.addControlDebugString("wait CTS timeout");
                        serialPort.RtsEnable = false;
                        mainForm.addControlDebugString("RTS reset");
                        inSendProcess = false;
                        return;
                    }
                }
                deleteTimer(timer);
                mainForm.addControlDebugString("CTS reset");
                serialPort.RtsEnable = false;
                mainForm.addControlDebugString("RTS reset");
                reciveChar();
                inSendProcess = false;
            }
        }

        public void deleteTimer(System.Timers.Timer timer)
        {
            timer.Stop();
            timer.Dispose();
        }

        public void resiveDTRChecked()
        {
            if (serialPort.DsrHolding && !inSendProcess)
            {
                inSendProcess = true;
                mainForm.addControlDebugString("DSR set");
                serialPort.DtrEnable = true;
                mainForm.addControlDebugString("DTR set");
                System.Timers.Timer timer = startTimer();
                while (serialPort.DsrHolding)
                {
                    if (!timerIsStart)
                    {
                        mainForm.addControlDebugString("wait DSR timeout");
                        serialPort.DtrEnable = false;
                        mainForm.addControlDebugString("DTR reset");
                        inSendProcess = false;
                        return;
                    }
                }
                deleteTimer(timer);
                mainForm.addControlDebugString("DSR reset");
                serialPort.DtrEnable = false;
                mainForm.addControlDebugString("DTR reset");
                reciveChar();
                inSendProcess = false;
            }
        }
        
        void reciverLoop()
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

        public void close()
        {
            serialPort.Close();
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
                recivingMessage = "";
                mainForm.addControlDebugString("char wasn't sent");
            }
        }

        private void sendRTSCheckedData(char message)
        {
            serialPort.RtsEnable = true;
            mainForm.addControlDebugString("RTS set");
            System.Timers.Timer timer = startTimer();
            while (!serialPort.CtsHolding)
            {
                if (!timerIsStart)
                {
                    mainForm.addControlDebugString("wait CTS timeout");
                    serialPort.RtsEnable = false;
                    mainForm.addControlDebugString("RTS reset");
                    return;
                }
            }
            deleteTimer(timer);
            mainForm.addControlDebugString("CTS set");
            serialPort.RtsEnable = false;
            mainForm.addControlDebugString("RTS reset");
            sendChar(message);
        }

        private void sendDTRCheckedData(char message)
        {
            serialPort.DtrEnable = true;
            mainForm.addControlDebugString("DTR set");
            System.Timers.Timer timer = startTimer();
            while (!serialPort.DsrHolding)
            {
                if (!timerIsStart)
                {
                    mainForm.addControlDebugString("wait DSR timeout");
                    serialPort.DtrEnable = false;
                    mainForm.addControlDebugString("DTR reset");
                    return;
                }
            }
            deleteTimer(timer);
            mainForm.addControlDebugString("DSR set");
            serialPort.DtrEnable = false;
            mainForm.addControlDebugString("DTR reset");
            sendChar(message);
        }

        public void sendData(string message)
        {
            if (isChecked)
            {
                foreach(char a in message)
                {
                    if (isRTS) sendRTSCheckedData(a);
                    else sendDTRCheckedData(a);
                }
                if (isRTS) sendRTSCheckedData('\0');
                else sendDTRCheckedData('\0');
                mainForm.addControlDebugString("message was sent");
            }
            else
            {
                try
                {
                    serialPort.WriteLine(message);
                    while (serialPort.BytesToWrite > 0);
                    mainForm.addControlDebugString("message was sent");
                }
                catch (Exception ex)
                {
                    mainForm.addControlDebugString("Transmit error");
                }
            }
        }
    }
}