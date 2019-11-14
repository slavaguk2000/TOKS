using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort2
{
    class Monitor : Station
    {
        private const char monitorSymbol = 'M';
        private CheckBox holdTimeCheck;
        private TextBox holdTimeText;
        private Button start;
        public Monitor(Label tokenDetect, CheckBox holdTimeCheck, TextBox holdTimeText, Button start, Label packageLabel) : base(tokenDetect, packageLabel)
        {
            this.start = start;
            this.holdTimeCheck = holdTimeCheck;
            this.holdTimeText = holdTimeText;
            setTextEnable(false);
        }
        public void setTextEnable(bool flag)
        {
            holdTimeText.Enabled = flag;
        }
        protected override void receiveMessage(string message)
        {
            if (message[0] != frameSymbol) throw new FormatException();
            if (message[4] == emptySymbol)
            {
                ReplaceCharInString(ref message, 4, monitorSymbol);
                sendToNextStation(message);
            }
            else if (message[4] == monitorSymbol) sendMyMessage();
            else throw new FormatException();
            
        }

        protected override void sendMyMessage()
        {
            sendToNextStation(tokenMessage);
        }
        public void startToken()
        {
            sendMyMessage();
            start.Enabled = false;
        }
    }
}
