using System;
using System.Windows.Forms;

namespace ComPort2
{
    public partial class MainForm : Form
    {
        private UserStation[] stations;
        Monitor monitor;
        public MainForm()
        {
            InitializeComponent();
            stations = new UserStation[3] {
                new UserStation(outputLabel, inputTextBox1, Station1Token, destinationAddress1, package1,1),
                new UserStation(label4, inputTextBox2, Station2Token, destinationAddress2, package2, 2),
                new UserStation(label7, inputTextBox3, Station3Token, destinationAddress3, package3, 3)
            };
            monitor = new Monitor(monitorToken, holdTimeCheckBox, holdTimeTextBox, startButton, packageMonitor);
            stations[0].setNextStation(stations[1]);
            stations[1].setNextStation(stations[2]);
            stations[2].setNextStation(monitor);
            monitor.setNextStation(stations[0]);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void startButton_Click(object sender, EventArgs e)
        {
            monitor.startToken();
        }
        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try 
                {
                    foreach (UserStation station in stations)
                        station.addStringToTransmitBuffer((TextBox)sender);
                }
                catch(Exception)
                {
                    MessageBox.Show("Choose destination address!", "ERROR!!!");
                }
            }
        }

        private void holdTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox holdTimeCheck = (CheckBox)sender;
            holdTimeTextBox.Enabled = holdTimeCheck.Checked;
            foreach(UserStation station in stations)
            {
                station.holdTimeCheck = holdTimeCheck.Checked;
            }
        }

        private void holdTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox holdTimeBox = (TextBox)sender;
            try
            {
                int holdTime = int.Parse(holdTimeBox.Text);
                if (holdTime < 1) throw new ArgumentException();
                foreach (UserStation station in stations)
                {
                    station.holdTime = holdTime;
                }
            }
            catch (Exception)
            {
                holdTimeBox.Text = "10";
                holdTimeTextBox_TextChanged(sender, e);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (UserStation station in stations)
            {
                station.stop();
            }
            monitor.stop();
        }
    }
}
