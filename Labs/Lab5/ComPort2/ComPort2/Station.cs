using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort2
{
    abstract class Station
    {        
        protected const string tokenMessage = 'T';
        protected const char frameSymbol = 'F';
        protected const char emptySymbol = ' ';
        protected const int sizeOfPackage = 6;
        private Label tokenDetect;
        protected Station nextStation = null;
        public Station(Label tokenDetect)
        {
            this.tokenDetect = tokenDetect;
            resetTokenDetect();
        }
        public void setNextStation(Station nextStation)
        {
            this.nextStation = nextStation;
        }
        private void selectTokenDetect(string selection)
        {
            tokenDetect.BeginInvoke((MethodInvoker)(delegate { tokenDetect.Text = selection; }));
        }
        public void setTokenDetect()
        {
            selectTokenDetect("*");
        }
        public void resetTokenDetect()
        {
            selectTokenDetect("");
        }
        private void delay(int seconds)
        {
            var startMilliseconds = DateTime.UtcNow.Millisecond;
            while (DateTime.UtcNow.Millisecond < startMilliseconds + seconds*1000);
        }
        abstract protected void sendMyMessage();
        abstract protected void receiveMessage(string message);

        public void sendMessage(string message)
        {
            setTokenDetect();
            delay(1);
            resetTokenDetect();
            if (message == "T") sendMyMessage();
            else receiveMessage(message);
        }
    }
}
