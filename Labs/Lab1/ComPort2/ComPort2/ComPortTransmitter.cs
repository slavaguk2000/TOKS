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

        public ComPortTransmitter(string port, MainForm mainForm)
        {
            serialPort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();
            serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(serialPort_ErrorReceived);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

            this.mainForm = mainForm;
        }

        private void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[serialPort.BytesToRead];
            serialPort.Read(data, 0, data.Length);

        }

        void serialPort_SendData(byte[] data)
        {
            serialPort.RtsEnable = true;
            serialPort.Write(data, 0, data.Length);
            while (serialPort.BytesToWrite > 0);
            serialPort.RtsEnable = false;
        }
    }
}
