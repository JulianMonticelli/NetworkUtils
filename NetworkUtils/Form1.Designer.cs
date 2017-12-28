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
            this.label3 = new System.Windows.Forms.Label();
            this.IPAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IPAddressTextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddress1Label = new System.Windows.Forms.Label();
            this.IPAddressTextBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingDelayPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bufferSizePingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeOutPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttlPingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimesPingInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.IPAddressGroupBox.SuspendLayout();
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
            this.outputTextBox.Size = new System.Drawing.Size(580, 98);
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
            this.pingGroupBox.Controls.Add(this.progressBar1);
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
            this.pingGroupBox.Location = new System.Drawing.Point(409, 3);
            this.pingGroupBox.Name = "pingGroupBox";
            this.pingGroupBox.Size = new System.Drawing.Size(173, 252);
            this.pingGroupBox.TabIndex = 4;
            this.pingGroupBox.TabStop = false;
            this.pingGroupBox.Text = "Ping";
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(166, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stress Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // IPAddressGroupBox
            // 
            this.IPAddressGroupBox.Controls.Add(this.checkBox1);
            this.IPAddressGroupBox.Controls.Add(this.IPAddressTextBox2);
            this.IPAddressGroupBox.Controls.Add(this.label1);
            this.IPAddressGroupBox.Controls.Add(this.IPAddress1Label);
            this.IPAddressGroupBox.Controls.Add(this.IPAddressTextBox1);
            this.IPAddressGroupBox.Location = new System.Drawing.Point(2, 3);
            this.IPAddressGroupBox.Name = "IPAddressGroupBox";
            this.IPAddressGroupBox.Size = new System.Drawing.Size(158, 132);
            this.IPAddressGroupBox.TabIndex = 6;
            this.IPAddressGroupBox.TabStop = false;
            this.IPAddressGroupBox.Text = "groupBox2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.ForeColor = System.Drawing.Color.Lime;
            this.checkBox1.Location = new System.Drawing.Point(10, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(85, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "IP Range";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // IPAddressTextBox2
            // 
            this.IPAddressTextBox2.BackColor = System.Drawing.Color.Black;
            this.IPAddressTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IPAddressTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.IPAddressTextBox2.Location = new System.Drawing.Point(6, 76);
            this.IPAddressTextBox2.Name = "IPAddressTextBox2";
            this.IPAddressTextBox2.Size = new System.Drawing.Size(146, 23);
            this.IPAddressTextBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(66, 56);
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
            this.IPAddress1Label.Location = new System.Drawing.Point(10, 10);
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
            this.IPAddressTextBox1.Location = new System.Drawing.Point(6, 30);
            this.IPAddressTextBox1.Name = "IPAddressTextBox1";
            this.IPAddressTextBox1.Size = new System.Drawing.Size(146, 23);
            this.IPAddressTextBox1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 191);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 23);
            this.progressBar1.TabIndex = 19;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.IPAddressGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pingGroupBox);
            this.Controls.Add(this.outputTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.IPAddressGroupBox.ResumeLayout(false);
            this.IPAddressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button pingButton;
        private System.Windows.Forms.GroupBox pingGroupBox;
        private System.Windows.Forms.Label numTimesLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox IPAddressGroupBox;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.Label ttlLabel;
        private System.Windows.Forms.NumericUpDown numTimesPingInput;
        private System.Windows.Forms.NumericUpDown ttlPingInput;
        private System.Windows.Forms.NumericUpDown timeOutPingInput;
        private System.Windows.Forms.CheckBox fragmentPingInput;
        private System.Windows.Forms.TextBox IPAddressTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPAddress1Label;
        private System.Windows.Forms.TextBox IPAddressTextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label pingBufferSizeLabel;
        private System.Windows.Forms.NumericUpDown bufferSizePingInput;
        private System.Windows.Forms.Label pingDelayLabel;
        private System.Windows.Forms.NumericUpDown pingDelayPingInput;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

