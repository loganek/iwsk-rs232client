using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace IWSK_RS232
{
    public partial class MainForm : Form
    {
        private RS232Port rsPort = null;

        public MainForm()
        {
            InitializeComponent();

            rsPort = new RS232Port();
        }

        private void ReloadPorts()
        {
            portComboBox.DataSource = SerialPort.GetPortNames();

            if (portComboBox.Items.Count > 0)
            {
                portComboBox.SelectedIndex = 0;
                connectButton.Enabled = true;
            }
            else 
            {
                MessageBox.Show("Nie odnaleziono portów COM w komputerze.");
                connectButton.Enabled = false | rsPort.IsOpen;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadPorts();

            bitCountComboBox.SelectedIndex = 1;
            stopBitComboBox.SelectedIndex = 0;
            parityComboBox.SelectedIndex = 0;
            flowControlComboBox.SelectedIndex = 0;
        }

        private void rescanPortsButton_Click(object sender, EventArgs e)
        {
            ReloadPorts();
        }
    }
}
