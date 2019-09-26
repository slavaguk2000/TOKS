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

        public bool getChecked()
        {
            return controlEnableCheckBox.Checked;
        }

        public bool isRTS()
        {
            return radioButtonRTS.Checked;
        }

        public bool isDTR()
        {
            return radioButtonDTR.Checked;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void radioButtonDTR_CheckedChanged(object sender, EventArgs e)
        {
            transmitter?.setIsRTS(!((RadioButton)sender).Checked);
        }

        private void radioButtonRTS_CheckedChanged(object sender, EventArgs e)
        {
            transmitter?.setIsRTS(((RadioButton)sender).Checked);
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
            bool flag = ((CheckBox)sender).Checked;
            changeControlRadioButtonEnable(flag);
            transmitter?.setChecked(flag);
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

                transmitter.sendData(inputTextBox.Text);

                inputTextBox.Text = string.Empty;
            }            
        }

        public void addOutputString(string message)
        {
            outputLabel.BeginInvoke((MethodInvoker)(delegate { outputLabel.Text += message + "\n"; }));
        }

        public void addControlDebugString(string message)
        {
            controlLabel.BeginInvoke((MethodInvoker)(delegate { controlLabel.Text += message + "\n"; }));
        }

        private void ComPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comPortsComboBox = (ComboBox)sender;
            if (transmitter != null)
            {
                transmitter.DataRecived -= Transmitter_DataRecived;
                transmitter.close();
            }
            if (comPortsComboBox.SelectedIndex == -1) return;
            try
            {
                transmitter = new ComPortTransmitter(comPortsComboBox.SelectedItem.ToString(), this);
            }catch(Exception ex)
            {
                comPortsComboBox.SelectedIndex = -1;
                MessageBox.Show("Can't open this port. Please try another.", "ERROR!!!!!!");               
                return;
            }
            transmitter.DataRecived += Transmitter_DataRecived;
        }

        private void Transmitter_DataRecived(string message)
        {
            addOutputString(message);
        }

        private void ComPortComboBox_DropDown(object sender, EventArgs e)
        {
            updateCompPortComboBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string oldPort = "";

        private void ComPortComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex == -1) return;
            string portName = (string)comboBox.SelectedItem;
            if (portName.Equals(""))
            {
                comboBox.SelectedItem = oldPort;
            }
            else
            {
                if (transmitter != null) transmitter.close();
                try
                {
                    transmitter = new ComPortTransmitter(portName, this);
                }
                catch(Exception ex)
                {
                    comboBox.SelectedIndex = -1;
                    oldPort = "";
                    transmitter = null;
                    MessageBox.Show("Try choose another port");
                }
            }                
        }
    }
}
