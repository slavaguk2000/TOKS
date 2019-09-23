using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public partial class MainForm : Form
    {
        ComPortTransmitter transmitter;

        public MainForm()
        {
            InitializeComponent();
            transmitter = new ComPortTransmitter("COM1", this);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void radioButtonDTR_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonRTS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void outputLabl_Click(object sender, EventArgs e)
        {

        }

        private void outputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeControlRadioButtonEnable(bool flag)
        {
            radioButtonDTR.Enabled = radioButtonRTS.Enabled = flag;
        }
       
        private void controlEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeControlRadioButtonEnable(((CheckBox)sender).Checked);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                TextBox inputTextBox = (TextBox)sender;
                
                addOutputString(inputTextBox.Text);

                inputTextBox.Text = string.Empty;
            }            
        }

        public void addOutputString(string message)
        {
            outputLabel.Text += message + "\n";
        }
    }
}
