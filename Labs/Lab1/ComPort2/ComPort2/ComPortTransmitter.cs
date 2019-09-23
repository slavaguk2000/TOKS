using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComPort
{
    class ComPortTransmitter
    {
        private SerialPort serialPort;
        private MainForm mainForm;

        public delegate void ComPortMessageHandler(string message);

        public event ComPortMessageHandler DataRecived;

        public ComPortTransmitter(string port, MainForm mainForm)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();
            serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

            this.mainForm = mainForm;
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
        }

        public void sendData(string message)
        {
            try
            {
                serialPort.RtsEnable = true;
                serialPort.WriteLine(message);
                while (serialPort.BytesToWrite > 0) ;
                serialPort.RtsEnable = false;
                mainForm.addControlDebugString("Transmit error");
            }
            catch (Exception ex)
            {
                mainForm.addControlDebugString("Transmit error");
            }
        }
    }
}
