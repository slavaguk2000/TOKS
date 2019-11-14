using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort2
{
    class UserStation : Station
    {
        Label output;
        TextBox input;
        ComboBox distanitionAddress { get; }
        public int distanationAddress;
        int myAddress;
        string transmitBuffer = "";
        string recieveBuffer = "";
        char controlSetSymbol = 'C';
        public UserStation(Label output, TextBox input, Label tockenDetect, ComboBox distanitionAddress, int myAddress) : base(tockenDetect)
        {
            this.output = output;
            this.input = input;
            this.distanitionAddress = distanitionAddress;
            this.myAddress = myAddress;
            distanitionAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < 3; i++)
            {
                distanitionAddress.Items.Add(i + 1);
            }
        }
        private void addOutputString(string message)
        {
            output.BeginInvoke((MethodInvoker)(delegate { output.Text += message; }));
        }
        private void ReplaceCharInString(ref String str, int index, Char newSymb)
        {
            str = str.Remove(index, 1).Insert(index, newSymb.ToString());
        }
        private void sendToNextStation(string message)
        {
            nextStation.sendMessage(message);
        }
        protected override void receiveMessage(string message)
        {
            if (message[0] != frameSymbol) throw new FormatException();
            if (message[1] == myAddress && message[3] != controlSetSymbol)
            {
                sendMyMessage();
                return;
            }
            if (message[2] == myAddress)
            {
                char received = message[5];
                recieveBuffer += received;
                if (received == '\n') addOutputString(recieveBuffer);
                recieveBuffer = "";
                ReplaceCharInString(ref message, 3, controlSetSymbol);
            }
            sendToNextStation(message);
        }
        private string createPackage()
        {
            string message = "";
            message += frameSymbol;
            message += myAddress;
            message += distanationAddress;
            for (int i = 0; i < 2; i++) message += emptySymbol;
            message += transmitBuffer[0];
            return message;
        }
        protected override void sendMyMessage()
        {
            if (transmitBuffer.Length == 0) sendToNextStation("T");
            else
            {
                if (distanationAddress == myAddress)
                {
                    addOutputString(transmitBuffer.Substring(0, transmitBuffer.Length - 1));
                    transmitBuffer = "";
                }
                else
                {
                    sendToNextStation(createPackage());
                    transmitBuffer = transmitBuffer.Substring(1);
                }
            }
        }
    }
}
