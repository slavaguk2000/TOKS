using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort2
{
    abstract class Station
    {        
        protected const string tokenMessage = "T";
        protected const char frameSymbol = 'F';
        protected const char emptySymbol = ' ';
        protected const int sizeOfPackage = 6;
        private Label tokenDetect;
        private Label packageLabel;
        protected Station nextStation = null;
        private string message;
        public Station(Label tokenDetect, Label packageLabel)
        {
            this.tokenDetect = tokenDetect;
            this.packageLabel = packageLabel;
            packageLabel.Text = "";
            selectTokenDetect("");
        }
        private void setPackage(string package)
        {
            byte[] packageByteArray = new byte[package.Length];
            for (int i = 0; i < package.Length; i++)
                packageByteArray[i] = (byte)package[i];
            packageLabel.BeginInvoke((MethodInvoker)delegate { packageLabel.Text = BitConverter.ToString(packageByteArray); });
        }
        public void setNextStation(Station nextStation)
        {
            this.nextStation = nextStation;
        }
        private void selectTokenDetect(string selection)
        {
            tokenDetect.Text = selection; 
        }
        private void selectTokenDetectInvoke(string selection)
        {
            tokenDetect.BeginInvoke((MethodInvoker)(delegate { selectTokenDetect(selection); }));
        }
        public void setTokenDetect()
        {
            selectTokenDetectInvoke("*");
        }
        public void resetTokenDetect()
        {
            selectTokenDetectInvoke("");
        }
        private void delay(int seconds)
        {
            var startTicks = DateTime.UtcNow.Ticks;
            while (DateTime.UtcNow.Ticks < startTicks + seconds*1000*1000*10);
        }
        protected void sendToNextStation(string message)
        {
            if (nextStation == null) throw new NullReferenceException();
            nextStation.sendMessage(message);
        }
        abstract protected void sendMyMessage();
        abstract protected void receiveMessage(string message);
        protected void ReplaceCharInString(ref String str, int index, Char newSymb)
        {
            str = str.Remove(index, 1).Insert(index, newSymb.ToString());
        }
        public void sendMessage(string message)
        {
            setTokenDetect();
            setPackage(message);
            this.message = message;
            Thread processMessageThread = new Thread(new ThreadStart(processMessage));
            processMessageThread.Start();
        }
        private void processMessage()
        {
            delay(1);
            resetTokenDetect();
            if (message[0] == tokenMessage[0]) sendMyMessage();
            else receiveMessage(message);
        }
    }
}
