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
        Int64 beginTicks = 0;
        public bool holdTimeCheck = false;
        public int holdTime { get; set; }
        public UserStation(Label output, TextBox input, Label tockenDetect, ComboBox destinationAddressBox, Label packageLabel, int myAddress) : base(tockenDetect, packageLabel)
        {
            holdTime = 10;
            this.output = output;
            this.input = input;
            this.destinationAddressBox = destinationAddressBox;
            this.myAddress = myAddress;
            destinationAddressBox.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < 4; i++)
            {
                destinationAddressBox.Items.Add(i + 1);
            }
        }
        public void setHoldTimeCheck(bool flag)
        {
            holdTimeCheck = flag;
            beginTicks = 0;
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
            setDestinationEnable(false);
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
        private void setDestinationEnable(bool flag)
        {
            destinationAddressBox.Invoke((MethodInvoker)delegate { destinationAddressBox.Enabled = flag; });
        }
        protected override void sendMyMessage()
        {
            if (transmitBuffer.Length == 0)
            {
                setDestinationEnable(true);
                sendToNextStation(tokenMessage);
                beginTicks = 0;
            }
            else
            {
                if (destinationAddress == myAddress)
                {
                    addOutputString(transmitBuffer.Substring(0, transmitBuffer.Length - 1));
                    transmitBuffer = "";
                }
                else
                {
                    if(holdTimeCheck)
                    {
                        if (beginTicks == 0) beginTicks = getNowTicks();
                        if (getNowTicks() > beginTicks + ticksFromSeconds(holdTime))
                        {
                            sendToNextStation(tokenMessage);
                            beginTicks = 0;
                            return;
                        }
                    }
                    sendToNextStation(createPackage());
                    transmitBuffer = transmitBuffer.Substring(1);
                }
            }
        }
    }
}
