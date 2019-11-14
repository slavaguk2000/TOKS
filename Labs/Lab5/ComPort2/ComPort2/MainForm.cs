using System;
using System.Windows.Forms;

namespace ComPort2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserStation station1 = new UserStation(outputLabel, inputTextBox1, Station1Token, distanationAddress1, 1);
            UserStation station2 = new UserStation(label4, inputTextBox2, Station2Token, distanationAddress2, 2);
            UserStation station3 = new UserStation(label7, inputTextBox3, Station3Token, distanationAddress3, 3);            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
