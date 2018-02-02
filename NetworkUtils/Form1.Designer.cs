namespace NetworkUtils
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.pingButton = new System.Windows.Forms.Button();
            this.pingGroupBox = new System.Windows.Forms.GroupBox();
            this.pingProgressBar = new System.Windows.Forms.ProgressBar();
            this.pingDelayLabel = new System.Windows.Forms.Label();
            this.pingDelayPingInput = new System.Windows.Forms.NumericUpDown();
            this.pingBufferSizeLabel = new System.Windows.Forms.Label();
            this.bufferSizePingInput = new System.Windows.Forms.NumericUpDown();
            this.fragmentPingInput = new System.Windows.Forms.CheckBox();
            this.timeOutPingInput = new System.Windows.Forms.NumericUpDown();
            this.ttlPingInput = new System.Windows.Forms.NumericUpDown();
            this.numTimesPingInput = new System.Windows.Forms.NumericUpDown();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.ttlLabel = new System.Windows.Forms.Label();
            this.numTimesLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portNumberSelector = new System.Windows.Forms.NumericUpDown();
            this.stressTestButton = new System.Windows.Forms.Button();
            this.packetLimitLabel = new System.Windows.Forms.Label();
            this.packetLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.tcpUdpGroupBox = new System.Windows.Forms.GroupBox();
            this.udpRadioButton = new System.Windows.Forms.RadioButton();
            this.tcpRadioButton = new System.Windows.Forms.RadioButton();
            this.IPAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.ipRangeCheckbox = new System.Windows.Forms.CheckBox();
            this.IPAddressTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddress1Label = new System.Windows.Forms.Label();
            this.IPAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.tracertBox = new System.Windows.Forms.GroupBox();
            this.tracerouteTTLUpDown = new System.Windows.Forms.NumericUpDown();
            this.tracerouteTimeoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tracerouteButton = new System.Windows.Forms.Button();
            this.clearTextBoxButton = new System.Windows.Forms.Button();
            this.pingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingDelayPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSizePingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttlPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPingInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetLimitUpDown)).BeginInit();
            this.tcpUdpGroupBox.SuspendLayout();
            this.IPAddressGroupBox.SuspendLayout();
            this.tracertBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracerouteTTLUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracerouteTimeoutUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.outputTextBox.ForeColor = System.Drawing.Color.Lime;
            this.outputTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.outputTextBox.Location = new System.Drawing.Point(2, 261);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.ShortcutsEnabled = false;
            this.outputTextBox.Size = new System.Drawing.Size(469, 98);
            this.outputTextBox.TabIndex = 0;
            // 
            // pingButton
            // 
            this.pingButton.BackColor = System.Drawing.Color.Green;
            this.pingButton.ForeColor = System.Drawing.Color.White;
            this.pingButton.Location = new System.Drawing.Point(6, 220);
            this.pingButton.Name = "pingButton";
            this.pingButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pingButton.Size = new System.Drawing.Size(161, 26);
            this.pingButton.TabIndex = 2;
            this.pingButton.Text = "Ping";
            this.pingButton.UseMnemonic = false;
            this.pingButton.UseVisualStyleBackColor = false;
            this.pingButton.Click += new System.EventHandler(this.pingButton_Click);
            // 
            // pingGroupBox
            // 
            this.pingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pingGroupBox.Controls.Add(this.pingProgressBar);
            this.pingGroupBox.Controls.Add(this.pingDelayLabel);
            this.pingGroupBox.Controls.Add(this.pingDelayPingInput);
            this.pingGroupBox.Controls.Add(this.pingBufferSizeLabel);
            this.pingGroupBox.Controls.Add(this.bufferSizePingInput);
            this.pingGroupBox.Controls.Add(this.fragmentPingInput);
            this.pingGroupBox.Controls.Add(this.timeOutPingInput);
            this.pingGroupBox.Controls.Add(this.ttlPingInput);
            this.pingGroupBox.Controls.Add(this.numTimesPingInput);
            this.pingGroupBox.Controls.Add(this.timeOutLabel);
            this.pingGroupBox.Controls.Add(this.ttlLabel);
            this.pingGroupBox.Controls.Add(this.numTimesLabel);
            this.pingGroupBox.Controls.Add(this.pingButton);
            this.pingGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pingGroupBox.ForeColor = System.Drawing.Color.Lime;
            this.pingGroupBox.Location = new System.Drawing.Point(294, 3);
            this.pingGroupBox.Name = "pingGroupBox";
            this.pingGroupBox.Size = new System.Drawing.Size(173, 252);
            this.pingGroupBox.TabIndex = 4;
            this.pingGroupBox.TabStop = false;
            this.pingGroupBox.Text = "Ping";
            // 
            // pingProgressBar
            // 
            this.pingProgressBar.Location = new System.Drawing.Point(5, 191);
            this.pingProgressBar.Name = "pingProgressBar";
            this.pingProgressBar.Size = new System.Drawing.Size(162, 23);
            this.pingProgressBar.TabIndex = 19;
            // 
            // pingDelayLabel
            // 
            this.pingDelayLabel.AutoSize = true;
            this.pingDelayLabel.Location = new System.Drawing.Point(75, 141);
            this.pingDelayLabel.Name = "pingDelayLabel";
            this.pingDelayLabel.Size = new System.Drawing.Size(76, 17);
            this.pingDelayLabel.TabIndex = 18;
            this.pingDelayLabel.Text = "Ping Delay";
            // 
            // pingDelayPingInput
            // 
            this.pingDelayPingInput.BackColor = System.Drawing.Color.Black;
            this.pingDelayPingInput.ForeColor = System.Drawing.Color.Lime;
            this.pingDelayPingInput.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.pingDelayPingInput.Location = new System.Drawing.Point(7, 139);
            this.pingDelayPingInput.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.pingDelayPingInput.Name = "pingDelayPingInput";
            this.pingDelayPingInput.Size = new System.Drawing.Size(62, 23);
            this.pingDelayPingInput.TabIndex = 17;
            // 
            // pingBufferSizeLabel
            // 
            this.pingBufferSizeLabel.AutoSize = true;
            this.pingBufferSizeLabel.Location = new System.Drawing.Point(75, 111);
            this.pingBufferSizeLabel.Name = "pingBufferSizeLabel";
            this.pingBufferSizeLabel.Size = new System.Drawing.Size(75, 17);
            this.pingBufferSizeLabel.TabIndex = 16;
            this.pingBufferSizeLabel.Text = "Buffer size";
            // 
            // bufferSizePingInput
            // 
            this.bufferSizePingInput.BackColor = System.Drawing.Color.Black;
            this.bufferSizePingInput.ForeColor = System.Drawing.Color.Lime;
            this.bufferSizePingInput.Location = new System.Drawing.Point(6, 109);
            this.bufferSizePingInput.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.bufferSizePingInput.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.bufferSizePingInput.Name = "bufferSizePingInput";
            this.bufferSizePingInput.Size = new System.Drawing.Size(63, 23);
            this.bufferSizePingInput.TabIndex = 15;
            this.bufferSizePingInput.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // fragmentPingInput
            // 
            this.fragmentPingInput.AutoSize = true;
            this.fragmentPingInput.Location = new System.Drawing.Point(6, 168);
            this.fragmentPingInput.Name = "fragmentPingInput";
            this.fragmentPingInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fragmentPingInput.Size = new System.Drawing.Size(141, 21);
            this.fragmentPingInput.TabIndex = 14;
            this.fragmentPingInput.Text = "Fragment packet?";
            this.fragmentPingInput.UseVisualStyleBackColor = true;
            // 
            // timeOutPingInput
            // 
            this.timeOutPingInput.BackColor = System.Drawing.Color.Black;
            this.timeOutPingInput.ForeColor = System.Drawing.Color.Lime;
            this.timeOutPingInput.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeOutPingInput.Location = new System.Drawing.Point(6, 80);
            this.timeOutPingInput.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.timeOutPingInput.Name = "timeOutPingInput";
            this.timeOutPingInput.Size = new System.Drawing.Size(63, 23);
            this.timeOutPingInput.TabIndex = 13;
            this.timeOutPingInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ttlPingInput
            // 
            this.ttlPingInput.BackColor = System.Drawing.Color.Black;
            this.ttlPingInput.ForeColor = System.Drawing.Color.Lime;
            this.ttlPingInput.Location = new System.Drawing.Point(6, 51);
            this.ttlPingInput.Name = "ttlPingInput";
            this.ttlPingInput.Size = new System.Drawing.Size(63, 23);
            this.ttlPingInput.TabIndex = 12;
            this.ttlPingInput.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numTimesPingInput
            // 
            this.numTimesPingInput.BackColor = System.Drawing.Color.Black;
            this.numTimesPingInput.ForeColor = System.Drawing.Color.Lime;
            this.numTimesPingInput.Location = new System.Drawing.Point(6, 22);
            this.numTimesPingInput.Name = "numTimesPingInput";
            this.numTimesPingInput.Size = new System.Drawing.Size(63, 23);
            this.numTimesPingInput.TabIndex = 11;
            this.numTimesPingInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Location = new System.Drawing.Point(75, 82);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(91, 17);
            this.timeOutLabel.TabIndex = 10;
            this.timeOutLabel.Text = "Timeout (ms)";
            // 
            // ttlLabel
            // 
            this.ttlLabel.AutoSize = true;
            this.ttlLabel.Location = new System.Drawing.Point(75, 53);
            this.ttlLabel.Name = "ttlLabel";
            this.ttlLabel.Size = new System.Drawing.Size(34, 17);
            this.ttlLabel.TabIndex = 8;
            this.ttlLabel.Text = "TTL";
            // 
            // numTimesLabel
            // 
            this.numTimesLabel.AutoSize = true;
            this.numTimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numTimesLabel.Location = new System.Drawing.Point(75, 24);
            this.numTimesLabel.Name = "numTimesLabel";
            this.numTimesLabel.Size = new System.Drawing.Size(51, 17);
            this.numTimesLabel.TabIndex = 6;
            this.numTimesLabel.Text = "time(s)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portLabel);
            this.groupBox1.Controls.Add(this.portNumberSelector);
            this.groupBox1.Controls.Add(this.stressTestButton);
            this.groupBox1.Controls.Add(this.packetLimitLabel);
            this.groupBox1.Controls.Add(this.packetLimitUpDown);
            this.groupBox1.Controls.Add(this.tcpUdpGroupBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(166, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stress Test";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(6, 94);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "Port";
            // 
            // portNumberSelector
            // 
            this.portNumberSelector.BackColor = System.Drawing.Color.Black;
            this.portNumberSelector.ForeColor = System.Drawing.Color.Lime;
            this.portNumberSelector.Location = new System.Drawing.Point(46, 92);
            this.portNumberSelector.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portNumberSelector.Name = "portNumberSelector";
            this.portNumberSelector.Size = new System.Drawing.Size(70, 23);
            this.portNumberSelector.TabIndex = 5;
            this.portNumberSelector.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // stressTestButton
            // 
            this.stressTestButton.BackColor = System.Drawing.Color.Green;
            this.stressTestButton.ForeColor = System.Drawing.Color.White;
            this.stressTestButton.Location = new System.Drawing.Point(6, 176);
            this.stressTestButton.Name = "stressTestButton";
            this.stressTestButton.Size = new System.Drawing.Size(110, 26);
            this.stressTestButton.TabIndex = 4;
            this.stressTestButton.Text = "Fire";
            this.stressTestButton.UseVisualStyleBackColor = false;
            this.stressTestButton.Click += new System.EventHandler(this.stressTestButtonClick);
            // 
            // packetLimitLabel
            // 
            this.packetLimitLabel.AutoSize = true;
            this.packetLimitLabel.Location = new System.Drawing.Point(6, 124);
            this.packetLimitLabel.Name = "packetLimitLabel";
            this.packetLimitLabel.Size = new System.Drawing.Size(84, 17);
            this.packetLimitLabel.TabIndex = 3;
            this.packetLimitLabel.Text = "Packet Limit";
            // 
            // packetLimitUpDown
            // 
            this.packetLimitUpDown.BackColor = System.Drawing.Color.Black;
            this.packetLimitUpDown.ForeColor = System.Drawing.Color.Lime;
            this.packetLimitUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.packetLimitUpDown.Location = new System.Drawing.Point(6, 147);
            this.packetLimitUpDown.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.packetLimitUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.packetLimitUpDown.Name = "packetLimitUpDown";
            this.packetLimitUpDown.Size = new System.Drawing.Size(110, 23);
            this.packetLimitUpDown.TabIndex = 2;
            // 
            // tcpUdpGroupBox
            // 
            this.tcpUdpGroupBox.BackColor = System.Drawing.Color.Black;
            this.tcpUdpGroupBox.Controls.Add(this.udpRadioButton);
            this.tcpUdpGroupBox.Controls.Add(this.tcpRadioButton);
            this.tcpUdpGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tcpUdpGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tcpUdpGroupBox.ForeColor = System.Drawing.Color.Lime;
            this.tcpUdpGroupBox.Location = new System.Drawing.Point(6, 18);
            this.tcpUdpGroupBox.Name = "tcpUdpGroupBox";
            this.tcpUdpGroupBox.Size = new System.Drawing.Size(110, 73);
            this.tcpUdpGroupBox.TabIndex = 1;
            this.tcpUdpGroupBox.TabStop = false;
            this.tcpUdpGroupBox.Text = "TCP / UDP";
            this.tcpUdpGroupBox.Enter += new System.EventHandler(this.tcpUdpGroupBox_Enter);
            // 
            // udpRadioButton
            // 
            this.udpRadioButton.AutoSize = true;
            this.udpRadioButton.Location = new System.Drawing.Point(7, 46);
            this.udpRadioButton.Name = "udpRadioButton";
            this.udpRadioButton.Size = new System.Drawing.Size(55, 21);
            this.udpRadioButton.TabIndex = 1;
            this.udpRadioButton.Text = "UDP";
            this.udpRadioButton.UseVisualStyleBackColor = true;
            // 
            // tcpRadioButton
            // 
            this.tcpRadioButton.AutoSize = true;
            this.tcpRadioButton.Checked = true;
            this.tcpRadioButton.Location = new System.Drawing.Point(7, 19);
            this.tcpRadioButton.Name = "tcpRadioButton";
            this.tcpRadioButton.Size = new System.Drawing.Size(53, 21);
            this.tcpRadioButton.TabIndex = 0;
            this.tcpRadioButton.TabStop = true;
            this.tcpRadioButton.Text = "TCP";
            this.tcpRadioButton.UseVisualStyleBackColor = true;
            // 
            // IPAddressGroupBox
            // 
            this.IPAddressGroupBox.Controls.Add(this.ipRangeCheckbox);
            this.IPAddressGroupBox.Controls.Add(this.IPAddressTextBox2);
            this.IPAddressGroupBox.Controls.Add(this.label1);
            this.IPAddressGroupBox.Controls.Add(this.IPAddress1Label);
            this.IPAddressGroupBox.Controls.Add(this.IPAddressTextBox1);
            this.IPAddressGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IPAddressGroupBox.ForeColor = System.Drawing.Color.Lime;
            this.IPAddressGroupBox.Location = new System.Drawing.Point(2, 3);
            this.IPAddressGroupBox.Name = "IPAddressGroupBox";
            this.IPAddressGroupBox.Size = new System.Drawing.Size(158, 141);
            this.IPAddressGroupBox.TabIndex = 6;
            this.IPAddressGroupBox.TabStop = false;
            this.IPAddressGroupBox.Text = "IP Information";
            // 
            // ipRangeCheckbox
            // 
            this.ipRangeCheckbox.AutoSize = true;
            this.ipRangeCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ipRangeCheckbox.ForeColor = System.Drawing.Color.Lime;
            this.ipRangeCheckbox.Location = new System.Drawing.Point(10, 114);
            this.ipRangeCheckbox.Name = "ipRangeCheckbox";
            this.ipRangeCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ipRangeCheckbox.Size = new System.Drawing.Size(85, 21);
            this.ipRangeCheckbox.TabIndex = 15;
            this.ipRangeCheckbox.Text = "IP Range";
            this.ipRangeCheckbox.UseVisualStyleBackColor = true;
            // 
            // IPAddressTextBox2
            // 
            this.IPAddressTextBox2.BackColor = System.Drawing.Color.Black;
            this.IPAddressTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IPAddressTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.IPAddressTextBox2.Location = new System.Drawing.Point(6, 85);
            this.IPAddressTextBox2.Name = "IPAddressTextBox2";
            this.IPAddressTextBox2.Size = new System.Drawing.Size(146, 23);
            this.IPAddressTextBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(66, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // IPAddress1Label
            // 
            this.IPAddress1Label.AutoSize = true;
            this.IPAddress1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IPAddress1Label.ForeColor = System.Drawing.Color.Lime;
            this.IPAddress1Label.Location = new System.Drawing.Point(10, 19);
            this.IPAddress1Label.Name = "IPAddress1Label";
            this.IPAddress1Label.Size = new System.Drawing.Size(76, 17);
            this.IPAddress1Label.TabIndex = 1;
            this.IPAddress1Label.Text = "IP Address";
            // 
            // IPAddressTextBox1
            // 
            this.IPAddressTextBox1.BackColor = System.Drawing.Color.Black;
            this.IPAddressTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IPAddressTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.IPAddressTextBox1.Location = new System.Drawing.Point(6, 39);
            this.IPAddressTextBox1.Name = "IPAddressTextBox1";
            this.IPAddressTextBox1.Size = new System.Drawing.Size(146, 23);
            this.IPAddressTextBox1.TabIndex = 0;
            // 
            // tracertBox
            // 
            this.tracertBox.Controls.Add(this.tracerouteTTLUpDown);
            this.tracertBox.Controls.Add(this.tracerouteTimeoutUpDown);
            this.tracertBox.Controls.Add(this.label3);
            this.tracertBox.Controls.Add(this.label2);
            this.tracertBox.Controls.Add(this.tracerouteButton);
            this.tracertBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tracertBox.ForeColor = System.Drawing.Color.Lime;
            this.tracertBox.Location = new System.Drawing.Point(2, 150);
            this.tracertBox.Name = "tracertBox";
            this.tracertBox.Size = new System.Drawing.Size(158, 105);
            this.tracertBox.TabIndex = 7;
            this.tracertBox.TabStop = false;
            this.tracertBox.Text = "Traceroute";
            this.tracertBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tracerouteTTLUpDown
            // 
            this.tracerouteTTLUpDown.BackColor = System.Drawing.Color.Black;
            this.tracerouteTTLUpDown.ForeColor = System.Drawing.Color.Lime;
            this.tracerouteTTLUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tracerouteTTLUpDown.Location = new System.Drawing.Point(6, 18);
            this.tracerouteTTLUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.tracerouteTTLUpDown.Name = "tracerouteTTLUpDown";
            this.tracerouteTTLUpDown.Size = new System.Drawing.Size(80, 23);
            this.tracerouteTTLUpDown.TabIndex = 21;
            // 
            // tracerouteTimeoutUpDown
            // 
            this.tracerouteTimeoutUpDown.BackColor = System.Drawing.Color.Black;
            this.tracerouteTimeoutUpDown.ForeColor = System.Drawing.Color.Lime;
            this.tracerouteTimeoutUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tracerouteTimeoutUpDown.Location = new System.Drawing.Point(6, 44);
            this.tracerouteTimeoutUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.tracerouteTimeoutUpDown.Name = "tracerouteTimeoutUpDown";
            this.tracerouteTimeoutUpDown.Size = new System.Drawing.Size(80, 23);
            this.tracerouteTimeoutUpDown.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Timeout";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "TTL";
            // 
            // tracerouteButton
            // 
            this.tracerouteButton.BackColor = System.Drawing.Color.Green;
            this.tracerouteButton.ForeColor = System.Drawing.Color.White;
            this.tracerouteButton.Location = new System.Drawing.Point(6, 73);
            this.tracerouteButton.Name = "tracerouteButton";
            this.tracerouteButton.Size = new System.Drawing.Size(146, 26);
            this.tracerouteButton.TabIndex = 0;
            this.tracerouteButton.Text = "Traceroute";
            this.tracerouteButton.UseVisualStyleBackColor = false;
            this.tracerouteButton.Click += new System.EventHandler(this.tracerouteButton_Click);
            // 
            // clearTextBoxButton
            // 
            this.clearTextBoxButton.BackColor = System.Drawing.Color.Green;
            this.clearTextBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clearTextBoxButton.ForeColor = System.Drawing.Color.White;
            this.clearTextBoxButton.Location = new System.Drawing.Point(167, 223);
            this.clearTextBoxButton.Name = "clearTextBoxButton";
            this.clearTextBoxButton.Size = new System.Drawing.Size(121, 26);
            this.clearTextBoxButton.TabIndex = 8;
            this.clearTextBoxButton.Text = "Clear Output";
            this.clearTextBoxButton.UseVisualStyleBackColor = false;
            this.clearTextBoxButton.Click += new System.EventHandler(this.clearTextBoxButton_click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 361);
            this.Controls.Add(this.clearTextBoxButton);
            this.Controls.Add(this.tracertBox);
            this.Controls.Add(this.IPAddressGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pingGroupBox);
            this.Controls.Add(this.outputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Network Utilities";
            this.pingGroupBox.ResumeLayout(false);
            this.pingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingDelayPingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSizePingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutPingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttlPingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPingInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portNumberSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packetLimitUpDown)).EndInit();
            this.tcpUdpGroupBox.ResumeLayout(false);
            this.tcpUdpGroupBox.PerformLayout();
            this.IPAddressGroupBox.ResumeLayout(false);
            this.IPAddressGroupBox.PerformLayout();
            this.tracertBox.ResumeLayout(false);
            this.tracertBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracerouteTTLUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tracerouteTimeoutUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.GroupBox pingGroupBox;
        private System.Windows.Forms.Label numTimesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox IPAddressGroupBox;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label ttlLabel;
        private System.Windows.Forms.NumericUpDown numTimesPingInput;
        private System.Windows.Forms.NumericUpDown ttlPingInput;
        private System.Windows.Forms.NumericUpDown timeOutPingInput;
        private System.Windows.Forms.CheckBox fragmentPingInput;
        private System.Windows.Forms.TextBox IPAddressTextBox1;
        private System.Windows.Forms.Label IPAddress1Label;
        private System.Windows.Forms.Label pingBufferSizeLabel;
        private System.Windows.Forms.NumericUpDown bufferSizePingInput;
        private System.Windows.Forms.Label pingDelayLabel;
        private System.Windows.Forms.NumericUpDown pingDelayPingInput;
        private System.Windows.Forms.ProgressBar pingProgressBar;
        private System.Windows.Forms.GroupBox tcpUdpGroupBox;
        private System.Windows.Forms.Label packetLimitLabel;
        private System.Windows.Forms.NumericUpDown packetLimitUpDown;
        private System.Windows.Forms.RadioButton udpRadioButton;
        private System.Windows.Forms.RadioButton tcpRadioButton;
        private System.Windows.Forms.Button stressTestButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown portNumberSelector;
        private System.Windows.Forms.CheckBox ipRangeCheckbox;
        private System.Windows.Forms.TextBox IPAddressTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tracertBox;
        private System.Windows.Forms.Button tracerouteButton;
        private System.Windows.Forms.NumericUpDown tracerouteTTLUpDown;
        private System.Windows.Forms.NumericUpDown tracerouteTimeoutUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearTextBoxButton;
    }
}

