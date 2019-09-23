using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort
{
    public partial class MainForm : Form
    {
        ComPortTransmitter transmitter;

        private void updateCompPortComboBox()
        {
            ComPortComboBox.Items.Clear();
            ComPortComboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        public MainForm()
        {
            InitializeComponent();
            updateCompPortComboBox();
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
                if(transmitter == null)
                {
                    MessageBox.Show("Choose COM-Port please", "ERROR!!!");
                    return;
                }
                TextBox inputTextBox = (TextBox)sender;
                
                addOutputString(inputTextBox.Text);

                inputTextBox.Text = string.Empty;
            }            
        }

        public void addOutputString(string message)
        {
            outputLabel.Text += message + "\n";
        }

        private void ComPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            transmitter = new ComPortTransmitter(((ComboBox)sender).SelectedItem.ToString(), this);
        }

        private void ComPortComboBox_DropDown(object sender, EventArgs e)
        {
            updateCompPortComboBox();
        }
    }
}
