namespace IWSK_RS232
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gro = new System.Windows.Forms.GroupBox();
            this.rescanPortsButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.flowControlComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bitCountComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.pingButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lfButton = new System.Windows.Forms.Button();
            this.crButton = new System.Windows.Forms.Button();
            this.setTerminatorButton = new System.Windows.Forms.Button();
            this.terminatorTextBox = new System.Windows.Forms.TextBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ctsCheckBox = new System.Windows.Forms.CheckBox();
            this.dsrCheckBox = new System.Windows.Forms.CheckBox();
            this.rtsCheckBox = new System.Windows.Forms.CheckBox();
            this.dtrCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pingTimeOutTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.decReadRadioButton = new System.Windows.Forms.RadioButton();
            this.asciiReadRadioButton = new System.Windows.Forms.RadioButton();
            this.hexReadradioButton = new System.Windows.Forms.RadioButton();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readSplitContainer = new System.Windows.Forms.SplitContainer();
            this.readRawDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.readFrameListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.writeRawDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transactionCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transactionTextBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.fileRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.delTextCheckBox = new System.Windows.Forms.CheckBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pingTimer = new System.Windows.Forms.Timer(this.components);
            this.gro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readSplitContainer)).BeginInit();
            this.readSplitContainer.Panel1.SuspendLayout();
            this.readSplitContainer.Panel2.SuspendLayout();
            this.readSplitContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gro
            // 
            this.gro.Controls.Add(this.rescanPortsButton);
            this.gro.Controls.Add(this.connectButton);
            this.gro.Controls.Add(this.flowControlComboBox);
            this.gro.Controls.Add(this.label6);
            this.gro.Controls.Add(this.stopBitComboBox);
            this.gro.Controls.Add(this.parityComboBox);
            this.gro.Controls.Add(this.label5);
            this.gro.Controls.Add(this.label4);
            this.gro.Controls.Add(this.label3);
            this.gro.Controls.Add(this.bitCountComboBox);
            this.gro.Controls.Add(this.label2);
            this.gro.Controls.Add(this.label1);
            this.gro.Controls.Add(this.baudRateComboBox);
            this.gro.Controls.Add(this.portComboBox);
            this.gro.Location = new System.Drawing.Point(3, 3);
            this.gro.Name = "gro";
            this.gro.Size = new System.Drawing.Size(210, 225);
            this.gro.TabIndex = 0;
            this.gro.TabStop = false;
            this.gro.Text = "Konfiguracja połączenia";
            // 
            // rescanPortsButton
            // 
            this.rescanPortsButton.Location = new System.Drawing.Point(152, 15);
            this.rescanPortsButton.Name = "rescanPortsButton";
            this.rescanPortsButton.Size = new System.Drawing.Size(55, 23);
            this.rescanPortsButton.TabIndex = 13;
            this.rescanPortsButton.Text = "Skanuj";
            this.rescanPortsButton.UseVisualStyleBackColor = true;
            this.rescanPortsButton.Click += new System.EventHandler(this.rescanPortsButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 187);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(201, 24);
            this.connectButton.TabIndex = 12;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // flowControlComboBox
            // 
            this.flowControlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flowControlComboBox.FormattingEnabled = true;
            this.flowControlComboBox.Items.AddRange(new object[] {
            "Brak kontroli",
            "Kontrola sprzętowa",
            "Kontrola programowa"});
            this.flowControlComboBox.Location = new System.Drawing.Point(86, 152);
            this.flowControlComboBox.Name = "flowControlComboBox";
            this.flowControlComboBox.Size = new System.Drawing.Size(121, 21);
            this.flowControlComboBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kontrola\r\nprzepływu:";
            // 
            // stopBitComboBox
            // 
            this.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitComboBox.Location = new System.Drawing.Point(86, 125);
            this.stopBitComboBox.Name = "stopBitComboBox";
            this.stopBitComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitComboBox.TabIndex = 9;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parityComboBox.Location = new System.Drawing.Point(120, 89);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(87, 21);
            this.parityComboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bit stopu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bit parzystości:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liczba bitów:";
            // 
            // bitCountComboBox
            // 
            this.bitCountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitCountComboBox.FormattingEnabled = true;
            this.bitCountComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.bitCountComboBox.Location = new System.Drawing.Point(15, 89);
            this.bitCountComboBox.Name = "bitCountComboBox";
            this.bitCountComboBox.Size = new System.Drawing.Size(86, 21);
            this.bitCountComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szybkość:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRateComboBox.Location = new System.Drawing.Point(86, 44);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 1;
            this.baudRateComboBox.Text = "9600";
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(86, 17);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(65, 21);
            this.portComboBox.TabIndex = 0;
            // 
            // pingButton
            // 
            this.pingButton.Location = new System.Drawing.Point(6, 48);
            this.pingButton.Name = "pingButton";
            this.pingButton.Size = new System.Drawing.Size(193, 23);
            this.pingButton.TabIndex = 2;
            this.pingButton.Text = "PING";
            this.pingButton.UseVisualStyleBackColor = true;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lfButton);
            this.groupBox1.Controls.Add(this.crButton);
            this.groupBox1.Controls.Add(this.setTerminatorButton);
            this.groupBox1.Controls.Add(this.terminatorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminator";
            // 
            // lfButton
            // 
            this.lfButton.Location = new System.Drawing.Point(106, 15);
            this.lfButton.Name = "lfButton";
            this.lfButton.Size = new System.Drawing.Size(96, 23);
            this.lfButton.TabIndex = 3;
            this.lfButton.Text = "LF";
            this.lfButton.UseVisualStyleBackColor = true;
            this.lfButton.Click += new System.EventHandler(this.lfButton_Click);
            // 
            // crButton
            // 
            this.crButton.Location = new System.Drawing.Point(9, 15);
            this.crButton.Name = "crButton";
            this.crButton.Size = new System.Drawing.Size(91, 23);
            this.crButton.TabIndex = 2;
            this.crButton.Text = "CR";
            this.crButton.UseVisualStyleBackColor = true;
            this.crButton.Click += new System.EventHandler(this.crButton_Click);
            // 
            // setTerminatorButton
            // 
            this.setTerminatorButton.Location = new System.Drawing.Point(127, 44);
            this.setTerminatorButton.Name = "setTerminatorButton";
            this.setTerminatorButton.Size = new System.Drawing.Size(75, 23);
            this.setTerminatorButton.TabIndex = 1;
            this.setTerminatorButton.Text = "Ustaw";
            this.setTerminatorButton.UseVisualStyleBackColor = true;
            this.setTerminatorButton.Click += new System.EventHandler(this.setTerminatorButton_Click);
            // 
            // terminatorTextBox
            // 
            this.terminatorTextBox.Location = new System.Drawing.Point(9, 44);
            this.terminatorTextBox.Name = "terminatorTextBox";
            this.terminatorTextBox.Size = new System.Drawing.Size(114, 20);
            this.terminatorTextBox.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.groupBox6);
            this.leftPanel.Controls.Add(this.groupBox5);
            this.leftPanel.Controls.Add(this.groupBox4);
            this.leftPanel.Controls.Add(this.gro);
            this.leftPanel.Controls.Add(this.groupBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(218, 539);
            this.leftPanel.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ctsCheckBox);
            this.groupBox6.Controls.Add(this.dsrCheckBox);
            this.groupBox6.Controls.Add(this.rtsCheckBox);
            this.groupBox6.Controls.Add(this.dtrCheckBox);
            this.groupBox6.Location = new System.Drawing.Point(3, 440);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 70);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Ręczne sterowanie";
            // 
            // ctsCheckBox
            // 
            this.ctsCheckBox.AutoSize = true;
            this.ctsCheckBox.Enabled = false;
            this.ctsCheckBox.Location = new System.Drawing.Point(127, 42);
            this.ctsCheckBox.Name = "ctsCheckBox";
            this.ctsCheckBox.Size = new System.Drawing.Size(47, 17);
            this.ctsCheckBox.TabIndex = 3;
            this.ctsCheckBox.Text = "CTS";
            this.ctsCheckBox.UseVisualStyleBackColor = true;
            // 
            // dsrCheckBox
            // 
            this.dsrCheckBox.AutoSize = true;
            this.dsrCheckBox.Enabled = false;
            this.dsrCheckBox.Location = new System.Drawing.Point(35, 42);
            this.dsrCheckBox.Name = "dsrCheckBox";
            this.dsrCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dsrCheckBox.TabIndex = 2;
            this.dsrCheckBox.Text = "DSR";
            this.dsrCheckBox.UseVisualStyleBackColor = true;
            // 
            // rtsCheckBox
            // 
            this.rtsCheckBox.AutoSize = true;
            this.rtsCheckBox.Location = new System.Drawing.Point(127, 18);
            this.rtsCheckBox.Name = "rtsCheckBox";
            this.rtsCheckBox.Size = new System.Drawing.Size(48, 17);
            this.rtsCheckBox.TabIndex = 1;
            this.rtsCheckBox.Text = "RTS";
            this.rtsCheckBox.UseVisualStyleBackColor = true;
            this.rtsCheckBox.CheckedChanged += new System.EventHandler(this.rtsCheckBox_CheckedChanged);
            // 
            // dtrCheckBox
            // 
            this.dtrCheckBox.AutoSize = true;
            this.dtrCheckBox.Location = new System.Drawing.Point(35, 19);
            this.dtrCheckBox.Name = "dtrCheckBox";
            this.dtrCheckBox.Size = new System.Drawing.Size(49, 17);
            this.dtrCheckBox.TabIndex = 0;
            this.dtrCheckBox.Text = "DTR";
            this.dtrCheckBox.UseVisualStyleBackColor = true;
            this.dtrCheckBox.CheckedChanged += new System.EventHandler(this.dtrCheckBox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.pingButton);
            this.groupBox5.Controls.Add(this.pingTimeOutTextBox);
            this.groupBox5.Location = new System.Drawing.Point(3, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 77);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Timeout:";
            // 
            // pingTimeOutTextBox
            // 
            this.pingTimeOutTextBox.Location = new System.Drawing.Point(57, 21);
            this.pingTimeOutTextBox.Name = "pingTimeOutTextBox";
            this.pingTimeOutTextBox.Size = new System.Drawing.Size(111, 20);
            this.pingTimeOutTextBox.TabIndex = 14;
            this.pingTimeOutTextBox.Text = "100";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.decReadRadioButton);
            this.groupBox4.Controls.Add(this.asciiReadRadioButton);
            this.groupBox4.Controls.Add(this.hexReadradioButton);
            this.groupBox4.Location = new System.Drawing.Point(3, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 40);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyświetlanie danych";
            // 
            // decReadRadioButton
            // 
            this.decReadRadioButton.AutoSize = true;
            this.decReadRadioButton.Location = new System.Drawing.Point(86, 17);
            this.decReadRadioButton.Name = "decReadRadioButton";
            this.decReadRadioButton.Size = new System.Drawing.Size(47, 17);
            this.decReadRadioButton.TabIndex = 2;
            this.decReadRadioButton.Tag = "2";
            this.decReadRadioButton.Text = "DEC";
            this.decReadRadioButton.UseVisualStyleBackColor = true;
            this.decReadRadioButton.CheckedChanged += new System.EventHandler(this.asciiReadRadioButton_CheckedChanged);
            // 
            // asciiReadRadioButton
            // 
            this.asciiReadRadioButton.AutoSize = true;
            this.asciiReadRadioButton.Checked = true;
            this.asciiReadRadioButton.Location = new System.Drawing.Point(11, 17);
            this.asciiReadRadioButton.Name = "asciiReadRadioButton";
            this.asciiReadRadioButton.Size = new System.Drawing.Size(52, 17);
            this.asciiReadRadioButton.TabIndex = 0;
            this.asciiReadRadioButton.TabStop = true;
            this.asciiReadRadioButton.Tag = "0";
            this.asciiReadRadioButton.Text = "ASCII";
            this.asciiReadRadioButton.UseVisualStyleBackColor = true;
            this.asciiReadRadioButton.CheckedChanged += new System.EventHandler(this.asciiReadRadioButton_CheckedChanged);
            // 
            // hexReadradioButton
            // 
            this.hexReadradioButton.AutoSize = true;
            this.hexReadradioButton.Location = new System.Drawing.Point(152, 17);
            this.hexReadradioButton.Name = "hexReadradioButton";
            this.hexReadradioButton.Size = new System.Drawing.Size(47, 17);
            this.hexReadradioButton.TabIndex = 1;
            this.hexReadradioButton.Tag = "1";
            this.hexReadradioButton.Text = "HEX";
            this.hexReadradioButton.UseVisualStyleBackColor = true;
            this.hexReadradioButton.CheckedChanged += new System.EventHandler(this.asciiReadRadioButton_CheckedChanged);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(218, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.groupBox2);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.groupBox3);
            this.mainSplitContainer.Size = new System.Drawing.Size(648, 539);
            this.mainSplitContainer.SplitterDistance = 278;
            this.mainSplitContainer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.readSplitContainer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odbiór danych";
            // 
            // readSplitContainer
            // 
            this.readSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.readSplitContainer.Name = "readSplitContainer";
            // 
            // readSplitContainer.Panel1
            // 
            this.readSplitContainer.Panel1.Controls.Add(this.readRawDataRichTextBox);
            // 
            // readSplitContainer.Panel2
            // 
            this.readSplitContainer.Panel2.Controls.Add(this.readFrameListBox);
            this.readSplitContainer.Size = new System.Drawing.Size(642, 259);
            this.readSplitContainer.SplitterDistance = 315;
            this.readSplitContainer.TabIndex = 0;
            // 
            // readRawDataRichTextBox
            // 
            this.readRawDataRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readRawDataRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.readRawDataRichTextBox.Name = "readRawDataRichTextBox";
            this.readRawDataRichTextBox.ReadOnly = true;
            this.readRawDataRichTextBox.Size = new System.Drawing.Size(315, 259);
            this.readRawDataRichTextBox.TabIndex = 0;
            this.readRawDataRichTextBox.Text = "";
            // 
            // readFrameListBox
            // 
            this.readFrameListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readFrameListBox.FormattingEnabled = true;
            this.readFrameListBox.Location = new System.Drawing.Point(0, 0);
            this.readFrameListBox.Name = "readFrameListBox";
            this.readFrameListBox.Size = new System.Drawing.Size(323, 259);
            this.readFrameListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.writeRawDataRichTextBox);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 257);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wysyłanie danych";
            // 
            // writeRawDataRichTextBox
            // 
            this.writeRawDataRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.writeRawDataRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.writeRawDataRichTextBox.Name = "writeRawDataRichTextBox";
            this.writeRawDataRichTextBox.ReadOnly = true;
            this.writeRawDataRichTextBox.Size = new System.Drawing.Size(642, 170);
            this.writeRawDataRichTextBox.TabIndex = 1;
            this.writeRawDataRichTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.transactionCheckBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.transactionTextBox);
            this.panel1.Controls.Add(this.loadFileButton);
            this.panel1.Controls.Add(this.fileRadioButton);
            this.panel1.Controls.Add(this.textRadioButton);
            this.panel1.Controls.Add(this.filePathTextBox);
            this.panel1.Controls.Add(this.delTextCheckBox);
            this.panel1.Controls.Add(this.sendTextBox);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 68);
            this.panel1.TabIndex = 0;
            // 
            // transactionCheckBox
            // 
            this.transactionCheckBox.AutoSize = true;
            this.transactionCheckBox.Location = new System.Drawing.Point(455, 47);
            this.transactionCheckBox.Name = "transactionCheckBox";
            this.transactionCheckBox.Size = new System.Drawing.Size(112, 17);
            this.transactionCheckBox.TabIndex = 10;
            this.transactionCheckBox.Text = "Wyślij w transakcji";
            this.transactionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Czas na transakcję:";
            // 
            // transactionTextBox
            // 
            this.transactionTextBox.Location = new System.Drawing.Point(344, 45);
            this.transactionTextBox.Name = "transactionTextBox";
            this.transactionTextBox.Size = new System.Drawing.Size(79, 20);
            this.transactionTextBox.TabIndex = 7;
            this.transactionTextBox.Text = "100";
            // 
            // loadFileButton
            // 
            this.loadFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFileButton.Location = new System.Drawing.Point(344, 21);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(129, 23);
            this.loadFileButton.TabIndex = 6;
            this.loadFileButton.Text = "Załaduj plik";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // fileRadioButton
            // 
            this.fileRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileRadioButton.AutoSize = true;
            this.fileRadioButton.Location = new System.Drawing.Point(485, 24);
            this.fileRadioButton.Name = "fileRadioButton";
            this.fileRadioButton.Size = new System.Drawing.Size(42, 17);
            this.fileRadioButton.TabIndex = 5;
            this.fileRadioButton.Text = "Plik";
            this.fileRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Checked = true;
            this.textRadioButton.Location = new System.Drawing.Point(485, 1);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(76, 17);
            this.textRadioButton.TabIndex = 4;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "Pole edycji";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(0, 22);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(338, 20);
            this.filePathTextBox.TabIndex = 3;
            // 
            // delTextCheckBox
            // 
            this.delTextCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delTextCheckBox.AutoSize = true;
            this.delTextCheckBox.Checked = true;
            this.delTextCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.delTextCheckBox.Location = new System.Drawing.Point(344, 2);
            this.delTextCheckBox.Name = "delTextCheckBox";
            this.delTextCheckBox.Size = new System.Drawing.Size(129, 17);
            this.delTextCheckBox.TabIndex = 2;
            this.delTextCheckBox.Text = "Wyczyść po wysłaniu";
            this.delTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTextBox.Location = new System.Drawing.Point(0, 0);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(338, 20);
            this.sendTextBox.TabIndex = 0;
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(567, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 68);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Wyślij";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.send_Design);
            // 
            // pingTimer
            // 
            this.pingTimer.Tick += new System.EventHandler(this.pingTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 539);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.leftPanel);
            this.Name = "MainForm";
            this.Text = "IWSK-RS232";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gro.ResumeLayout(false);
            this.gro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.readSplitContainer.Panel1.ResumeLayout(false);
            this.readSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.readSplitContainer)).EndInit();
            this.readSplitContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gro;
        private System.Windows.Forms.ComboBox stopBitComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bitCountComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox flowControlComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rescanPortsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setTerminatorButton;
        private System.Windows.Forms.TextBox terminatorTextBox;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton decReadRadioButton;
        private System.Windows.Forms.RadioButton asciiReadRadioButton;
        private System.Windows.Forms.RadioButton hexReadradioButton;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer readSplitContainer;
        private System.Windows.Forms.RichTextBox readRawDataRichTextBox;
        private System.Windows.Forms.ListBox readFrameListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox writeRawDataRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.CheckBox delTextCheckBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.RadioButton fileRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pingTimeOutTextBox;
        private System.Windows.Forms.Timer pingTimer;
        private System.Windows.Forms.Button lfButton;
        private System.Windows.Forms.Button crButton;
        private System.Windows.Forms.CheckBox transactionCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transactionTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox rtsCheckBox;
        private System.Windows.Forms.CheckBox dtrCheckBox;
        private System.Windows.Forms.CheckBox ctsCheckBox;
        private System.Windows.Forms.CheckBox dsrCheckBox;
    }
}

