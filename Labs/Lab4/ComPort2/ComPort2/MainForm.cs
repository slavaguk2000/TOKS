using System;
using System.Windows.Forms;

namespace ComPort
{
    public partial class MainForm : Form
    {
        private int attemptCount;
        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
            attemptCount = int.Parse(attemptCountTextBox.Text);
        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            
        }        
        private void clearInput()
        {
            inputTextBox.Text = string.Empty;
        }
        private void sendChar(char a)
        {
            addControlDebugSymbol('{');//MY ADDING!!!!!!!!!!!!!!!!!!!!
            for (int i = 0; i < attemptCount; i++)
            { 
                if(checkCollision())
                {
                    addControlDebugSymbol('X');
                    waitCollisionWindow();
                }
                else
                {
                    addControlDebugSymbol('\n');
                    addOutputSymbol(a);
                    waitCollisionWindow();
                    return;
                }                
            }
            addControlDebugSymbol('\n');
            //TODO : write error
        }

        private void waitCollisionWindow()
        {
            //50000см/(15..20)см/нс = 3000нс = 30 ticks (длина сегмента - 500м)
            var startTicks = DateTime.UtcNow.Ticks;
            while (DateTime.UtcNow.Ticks < startTicks + 12453) ;
            //while (DateTime.UtcNow.Ticks < startTicks + 30) ;
        }

        private bool checkCollision()
        {
            if (((DateTime.UtcNow.Ticks / 100 % 31)* (DateTime.UtcNow.Ticks / 100 % 17)) % 4 == 2) //1 tick = 100 nanoseconds = 0.1 microseconds
                return false;
            return true;
        }
        private void addLine()
        {
            for (int i = 0; i < 10; i++)
                addControlDebugSymbol('-');//MY ADDING!!!!!!!!!!!!!!!!!!!!
            addControlDebugSymbol('\n');//MY ADDING!!!!!!!!!!!!!!!!!!!!
        }
        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                TextBox inputTextBox = (TextBox)sender;
                string input = inputTextBox.Text;
                foreach (char a in input)
                    sendChar(a);
                addOutputSymbol('\n');
                addLine();
                clearInput();
            }            
        }
        public void addOutputSymbol(char message)
        {
            outputLabel.BeginInvoke((MethodInvoker)(delegate { outputLabel.Text += message; }));
        }
        public void addControlDebugSymbol(char message)
        {
            controlLabel.BeginInvoke((MethodInvoker)(delegate { controlLabel.Text += message; }));
        }
        private void attemptCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                TextBox number = (TextBox)sender;
                try
                {
                    attemptCount = int.Parse(number.Text);
                    if (attemptCount > 10)
                    {
                        MessageBox.Show("Too large count of attempt(max = 10)", "ERROR");
                        throw new FormatException("");
                    }
                }
                catch (FormatException)
                {
                    number.Text = "10";
                    attemptCount = 10;
                }
                ActiveControl = null;
            }
        }
    }
}
