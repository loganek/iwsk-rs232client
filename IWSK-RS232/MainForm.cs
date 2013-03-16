﻿using System;
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
        List<byte> pongList = new List<byte>();
        byte[] pongArr = new byte[] { 80, 79, 78, 71 };
        byte[] pingArr = new byte[] { 80, 73, 78, 71 };
        bool connectedDuePing = false;
        
        public MainForm()
        {
            InitializeComponent();

            rsPort.Connected += rsPort_Connected;
            rsPort.Disconnected += rsPort_Disconnected;
            rsPort.DataReceived += rsPort_DataReceived;
            rsPort.DataSent += rsPort_DataSent;
            rsPort.TransactionFinished += (sender, e) => logger.LogMessage("Transakcja zakończona " + (e.TransactionResult ? "powodzeniem" : "niepowodzeniem"));

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

        private void rsPort_Connected(object sender, EventArgs e)
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

        private bool IsPongData()
        {
            for (int i = 0; i < pongArr.Length; i++)
            {
                if (pongList[i] != pongArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void TerminatePing(byte[] data)
        {
            foreach (var b in data)
            {
                pingList.Add(b);

                if (b == pingArr[pingList.Count - 1])
                {
                    if (pingList.Count == pingArr.Length)
                    {
                        rsPort.Send(pongArr, true);
                    }
                }
                else
                {
                    pingList.Clear();
                }
            }
        }

        private void rsPort_DataReceived(object sender, EventArgs e)
        {
            byte[] data = rsPort.GetReadBytes().ToArray();

            TerminatePing(data);

            if (pingWatch.IsRunning)
            {
                pongList.AddRange(data.Take(pongArr.Length - pongList.Count));

                if (pongList.Count == pongArr.Length)
                {
                    if (IsPongData())
                    {
                        logger.LogMessage("PING: " + pingWatch.Elapsed);
                        data = data.Skip(pongList.Count).Take(data.Length - pongList.Count).ToArray();
                    }
                    else
                    {
                        logger.LogMessage("PING: " + pingWatch.Elapsed + "\nNiepoprawne dane.");
                    }

                    PingStop();
                }
            }

            if (!connectedDuePing)
                InvokeOrNot(() =>
                {
                    readRawDataRichTextBox.AppendText(StringParser.ByteToDisplay(data));
                    parser.AppendToParser(data);
                }, readRawDataRichTextBox);
        }

        private void InitTransaction()
        {
            if (rsPort.IsTransaction)
            {
                logger.LogMessage("Aktualnie wykonywana już jest transakcja, nie można wysłać danych jako transakcji.");
                return;
            }

            int interval;

            if (!int.TryParse(transactionTextBox.Text, out interval))
            {
                transactionTextBox.Text = (pingTimer.Interval = 100).ToString();
            }

            rsPort.SetTransaction(interval);
        }


        private void send_Design(object sender, EventArgs e)
        {
            if (rsPort.IsOpen)
            {
                bool bug = false;

                if (textRadioButton.Checked)
                {
                    List<byte> sendByte = new List<byte>(StringParser.StrToByteArray(sendTextBox.Text));

                    if (parser.Terminator != null)
                    {
                        sendByte.AddRange(parser.Terminator);
                    }

                    if (!rsPort.Send(sendByte.ToArray()))
                    {
                        bug = true;
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
                        if (!rsPort.Send(File.ReadAllBytes(filePathTextBox.Text), true))
                            throw new Exception(rsPort.ErrorMessage);

                        readRawDataRichTextBox.AppendText("\n *** Wysłano plik " + filePathTextBox.Text + " *** \n");
                    }
                    catch (Exception ex)
                    {
                        logger.LogMessage("Nie można wysłać pliku " + filePathTextBox.Text + "\n" + ex.Message);
                        bug = true;
                    }
                }

                if (!bug && transactionCheckBox.Checked)
                {
                    InitTransaction();
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
            int interval;

            if (int.TryParse(pingTimeOutTextBox.Text, out interval))
            {
                pingTimer.Interval = interval;
            }
            else 
            {
                pingTimeOutTextBox.Text = (pingTimer.Interval = 100).ToString();
            }
            pingTimer.Start();
            pingButton.Enabled = false;
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void PingStop(bool timeout = false)
        {
            pingTimer.Stop();

            if(timeout)
                logger.LogMessage("PING: Timeout");

            pingWatch.Stop();
            pongList.Clear();

            InvokeOrNot(() => pingButton.Enabled = true, pingButton);

            if (connectedDuePing)
            {
                disconnectButton_Click(null, null);
            }
        }

        private void pingTimer_Tick(object sender, EventArgs e)
        {
            PingStop(true);
        }

        private void crButton_Click(object sender, EventArgs e)
        {
            terminatorTextBox.Text += "\\r";
        }

        private void lfButton_Click(object sender, EventArgs e)
        {
            terminatorTextBox.Text += "\\n";
        }

        private void asciiReadRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
                dataFormat = (DataFormat)Convert.ToInt32(rb.Tag);
        }

        private void dtrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rsPort.DTREnable = dtrCheckBox.Checked;
        }

        private void rtsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            rsPort.RTSEnable = rtsCheckBox.Checked;
        }
    }
}
