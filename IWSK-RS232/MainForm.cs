using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;

namespace IWSK_RS232
{
    public partial class MainForm : Form
    {
        private RS232Port rsPort = new RS232Port();
        private Logger logger = new Logger();
        private DataFormat dataFormat = DataFormat.ASCII;
        private Parser parser = new Parser();
        Stopwatch pingWatch = new Stopwatch();
        List<byte> pingList = new List<byte>();
        byte[] pingArr = new byte[] { 10, 20, 30, 40, 54 };
        bool connectedDuePing = false;

        public MainForm()
        {
            InitializeComponent();

            rsPort.Connected += spPort_Connected;
            rsPort.Disconnected += rsPort_Disconnected;
            rsPort.DataReceived += rsPort_DataReceived;
            rsPort.DataSent += rsPort_DataSent;

            parser.FrameParsed += parser_FrameParsed;
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
            InvokeOrNot(() =>
            {
                connectButton.Text = "Połącz";
                connectButton.Click -= disconnectButton_Click;
                connectButton.Click += connectButton_Click;
            }, connectButton);
            InvokeOrNot(() => sendButton.Enabled = false, sendButton);
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
            if (!pingWatch.IsRunning)
            {
                InvokeOrNot(() => writeRawDataRichTextBox.AppendText(StringParser.ByteToDisplay(e.Buff, dataFormat)), writeRawDataRichTextBox);
            }
        }

        private bool IsPingData()
        {
            for (int i = 0; i < pingList.Count; i++)
            {
                if (pingList[i] != pingArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void rsPort_DataReceived(object sender, EventArgs e)
        {
            byte[] data = rsPort.GetReadBytes().ToArray();

            if (pingWatch.IsRunning)
            {
                pingList.AddRange(data.Take(pingArr.Length));

                if (pingList.Count == pingArr.Length)
                {
                    if (IsPingData())
                    {
                        logger.LogMessage("PING: " + pingWatch.Elapsed);
                        data = data.Skip(pingList.Count).Take(data.Length - pingList.Count).ToArray();
                    }
                    else
                    {
                        logger.LogMessage("PING: " + pingWatch.Elapsed + "\nNiepoprawne dane.");
                    }
                    pingWatch.Stop();
                    pingList.Clear();

                    InvokeOrNot(() => pingButton.Enabled = true, pingButton);
                    
                    if (connectedDuePing)
                    {
                        disconnectButton_Click(null, e);
                    }
                }
            }

            InvokeOrNot(() =>
            {
                readRawDataRichTextBox.AppendText(StringParser.ByteToDisplay(data));
                parser.AppendToParser(data);
            }, readRawDataRichTextBox);
        }

        private void send_Design(object sender, EventArgs e)
        {
            if (rsPort.IsOpen)
            {
                if (textRadioButton.Checked)
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
                else 
                {
                    try
                    {
                        rsPort.Send(File.ReadAllBytes(filePathTextBox.Text), true);
                        readRawDataRichTextBox.AppendText("\n *** Wysłano plik " + filePathTextBox.Text + " *** \n");
                    }
                    catch (Exception ex)
                    {
                        logger.LogMessage("Nie można wysłać pliku " + filePathTextBox.Text + "\n" + ex.Message);
                    }
                }
            }
        }

        private void parser_FrameParsed(object sender, EventArgs e)
        {
            InvokeOrNot(() => readFrameListBox.Items.Add(StringParser.ByteToDisplay(parser.Frame, dataFormat)), readFrameListBox);
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                send_Design(this, e);
            }
        }

        private void setTerminatorButton_Click(object sender, EventArgs e)
        {
            parser.Terminator = StringParser.StrToByteArray(terminatorTextBox.Text);
            logger.LogMessage("Ustawiono terminator: " + terminatorTextBox.Text);
        }

        private void pingButton_Click(object sender, EventArgs e)
        {
            if (!rsPort.IsOpen)
            {
                connectButton_Click(sender, e);
                connectedDuePing = true;
            }

            if (!rsPort.Send(pingArr, true))
            {
                logger.LogMessage("Nie można zrobić PING: nie można ustanowić połączenia.");
            }

            pingWatch.Start();
            pingButton.Enabled = false;
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }
    }
}
