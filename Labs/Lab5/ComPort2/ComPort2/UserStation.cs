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
        private Label output;
        private TextBox input;
        private ComboBox destinationAddressBox;
        public int destinationAddress;
        int myAddress;
        string transmitBuffer = "";
        string recieveBuffer = "";
        char controlSetSymbol = 'C';
        public UserStation(Label output, TextBox input, Label tockenDetect, ComboBox destinationAddressBox, Label packageLabel, int myAddress) : base(tockenDetect, packageLabel)
        {
            this.output = output;
            this.input = input;
            this.destinationAddressBox = destinationAddressBox;
            this.myAddress = myAddress;
            destinationAddressBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < 3; i++)
            {
                destinationAddressBox.Items.Add(i + 1);
            }
        }
        public void addStringToTransmitBuffer(TextBox inputTextBox)
        {
            if (input != inputTextBox) return;
            if (destinationAddressBox == null) throw new NullReferenceException();
            destinationAddress = int.Parse(destinationAddressBox.Text);
            string message = input.Text;
            message += '\n';
            if (destinationAddress == myAddress) addOutputString(message);
            else transmitBuffer += message;
            input.Text = "";
        }
        private void addOutputString(string message)
        {
            output.BeginInvoke((MethodInvoker)(delegate { output.Text += message; }));
        }
        protected override void receiveMessage(string message)
        {
            if (message[0] != frameSymbol) throw new FormatException();
            if (message[1] == myAddress && message[3] == controlSetSymbol)
            {
                sendMyMessage();
                return;
            }
            if (message[2] == myAddress)
            {
                char received = message[5];
                recieveBuffer += received;
                if (received == '\n')
                {
                    addOutputString(recieveBuffer);
                    recieveBuffer = "";
                }
                ReplaceCharInString(ref message, 3, controlSetSymbol);
            }
            sendToNextStation(message);
        }
        private string createPackage()
        {
            string message = "";
            message += frameSymbol;
            message += (char)myAddress;
            message += (char)destinationAddress;
            for (int i = 0; i < 2; i++) message += emptySymbol;
            message += transmitBuffer[0];
            return message;
        }
        protected override void sendMyMessage()
        {
            if (transmitBuffer.Length == 0) sendToNextStation(tokenMessage);
            else
            {
                if (destinationAddress == myAddress)
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
