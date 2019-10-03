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
        private ComPortTransmitter transmitter;
        private string oldSource = "0";
        private string oldDistanition = "0";
        public Packager packager;

        private void updateCompPortComboBox()
        {
            ComPortComboBox.Items.Clear();
            ComPortComboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        public MainForm()
        {
            InitializeComponent();
            updateCompPortComboBox();
            FormClosing += MainForm_FormClosing;
            packager = new Packager((byte)int.Parse(DistanitionAddressTextBox.Text), (byte)int.Parse(SourceAddressTextBox.Text), ErrorGenerationCheckBox.Checked);
        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            transmitter?.close();
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

                if(transmitter.sendData(inputTextBox.Text))
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

        private void Transmitter_DataRecived(string message)
        {
            addOutputString(message);
        }

        private void ComPortComboBox_DropDown(object sender, EventArgs e)
        {
            updateCompPortComboBox();
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
                    oldPort = portName;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ComPortComboBox_DropDown_1(object sender, EventArgs e)
        {
            updateCompPortComboBox();
        }

        private void ComPortComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedItem == null) 
                if (!oldPort.Equals(""))
                    comboBox.SelectedItem = oldPort;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAddressTextBox(TextBox textBox, bool source)
        {
            int newAddress;
            if (int.TryParse(textBox.Text, out newAddress))
            {
                if (newAddress > 255) newAddress = 255;
                if (newAddress < 0) newAddress = 0;
                if (source) packager.sourceAddress = (char)newAddress;
                else packager.distanitionAddress = (char)newAddress;
            }
            else
            {
                if (source) textBox.Text = oldSource;
                else textBox.Text = oldDistanition;
            }
        }

        private void SourceAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            checkAddressTextBox((TextBox)sender, true);            
        }

        private void DistanitionAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            checkAddressTextBox((TextBox)sender, false);
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {

        }

        private void SourceAddressTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void SourceAddressTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void SourceAddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ActiveControl = null;
            }
        }

        private void controlGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ErrorGenerationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            packager.error = ((CheckBox)sender).Checked;
        }
    }
}
