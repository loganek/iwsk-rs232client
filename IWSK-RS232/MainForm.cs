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
        private RS232Port rsPort = new RS232Port();
        private Logger logger = new Logger();
        private DataFormat dataFormat = DataFormat.ASCII;

        public MainForm()
        {
            InitializeComponent();

            rsPort.Connected += spPort_Connected;
            rsPort.Disconnected += rsPort_Disconnected;
            rsPort.DataReceived += rsPort_DataReceived;
            rsPort.DataSent += rsPort_DataSent;
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
                logger.LogMessage("Nie odnaleziono portów COM w komputerze.");
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

        #region Connection
        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                rsPort.SetConnectionParameters(portComboBox.SelectedItem.ToString(),
                    Convert.ToInt32(baudRateComboBox.Text),
                    RS232Port.ParityArray(parityComboBox.SelectedIndex),
                    Convert.ToInt32(bitCountComboBox.SelectedItem),
                    RS232Port.StopBitsArray(stopBitComboBox.SelectedIndex));

                if (!rsPort.Connect())
                {
                    logger.LogMessage("Nie można otworzyć portu: " + rsPort.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                logger.LogMessage("Podano niepoprawne argumenty: " + ex.Message);
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (!rsPort.Disconnect())
                logger.LogMessage("Nie można zamknąć portu.");
        }

        private void spPort_Connected(object sender, EventArgs e)
        {
            connectButton.Text = "Rozłącz";
            connectButton.Click -= connectButton_Click;
            connectButton.Click += disconnectButton_Click;
            sendButton.Enabled = true;
        }


        private void rsPort_Disconnected(object sender, EventArgs e)
        {
            connectButton.Text = "Połącz";
            connectButton.Click -= disconnectButton_Click;
            connectButton.Click += connectButton_Click;
            sendButton.Enabled = false;
        }
        #endregion Connection

        private void InvokeOrNot(Action f, Control ctrl)
        {
            if (ctrl.InvokeRequired)
                ctrl.Invoke(f);
            else
                f.Invoke();
        }

        private void rsPort_DataSent(object sender, SentEventArgs e)
        {
            InvokeOrNot(() => writeRawDataRichTextBox.AppendText(StringParser.ByteToDisplay(e.Buff, dataFormat)), writeRawDataRichTextBox);
        }

        private void rsPort_DataReceived(object sender, EventArgs e)
        {
            InvokeOrNot(() => readRawDataRichTextBox.AppendText(StringParser.ByteToDisplay(rsPort.GetReadBytes().ToArray())), readRawDataRichTextBox);
        }

        private void send_Design(object sender, EventArgs e)
        {
            if (rsPort.IsOpen)
            {
                if (!rsPort.Send(StringParser.StrToByteArray(sendTextBox.Text)))
                {
                    logger.LogMessage("Nie można wysłać danych: " + rsPort.ErrorMessage);
                }
                else
                {
                    if (delTextCheckBox.Checked)
                        sendTextBox.Clear();
                }
            }
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                send_Design(this, e);
            }
        }
    }
}
