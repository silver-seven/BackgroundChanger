namespace BackgroundChangerForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SwitchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.chooseDirButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pathLabel = new System.Windows.Forms.Label();
            this.imageNameLabel = new System.Windows.Forms.Label();
            this.styleLabel = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.imageNameTextBox = new System.Windows.Forms.TextBox();
            this.imageDirLabel = new System.Windows.Forms.TextBox();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.numericUpDownBuffer = new System.Windows.Forms.NumericUpDown();
            this.timerLabel = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.switchCounter = new System.Windows.Forms.Timer(this.components);
            this.imageDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.startupTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextIconRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteFreq_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.favFrequencyLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextIconRightClick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favoriteFreq_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SwitchButton
            // 
            this.SwitchButton.Location = new System.Drawing.Point(202, 121);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(75, 23);
            this.SwitchButton.TabIndex = 0;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.Switch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.favoriteCheckBox);
            this.panel1.Controls.Add(this.pauseButton);
            this.panel1.Controls.Add(this.hideButton);
            this.panel1.Controls.Add(this.chooseDirButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SwitchButton);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 177);
            this.panel1.TabIndex = 2;
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.AutoSize = true;
            this.favoriteCheckBox.Location = new System.Drawing.Point(213, 19);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(64, 17);
            this.favoriteCheckBox.TabIndex = 6;
            this.favoriteCheckBox.Text = "Favorite";
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            this.favoriteCheckBox.Click += new System.EventHandler(this.favoriteCheckBox_CheckedChanged);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(202, 92);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(202, 63);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 4;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // chooseDirButton
            // 
            this.chooseDirButton.Location = new System.Drawing.Point(202, 150);
            this.chooseDirButton.Name = "chooseDirButton";
            this.chooseDirButton.Size = new System.Drawing.Size(75, 23);
            this.chooseDirButton.TabIndex = 3;
            this.chooseDirButton.Text = "Select";
            this.chooseDirButton.UseVisualStyleBackColor = true;
            this.chooseDirButton.Click += new System.EventHandler(this.chooseDirButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.favFrequencyLabel);
            this.panel3.Controls.Add(this.favoriteFreq_numericUpDown1);
            this.panel3.Controls.Add(this.pathLabel);
            this.panel3.Controls.Add(this.imageNameLabel);
            this.panel3.Controls.Add(this.styleLabel);
            this.panel3.Controls.Add(this.styleComboBox);
            this.panel3.Controls.Add(this.imageNameTextBox);
            this.panel3.Controls.Add(this.imageDirLabel);
            this.panel3.Controls.Add(this.bufferLabel);
            this.panel3.Controls.Add(this.numericUpDownBuffer);
            this.panel3.Controls.Add(this.timerLabel);
            this.panel3.Controls.Add(this.numericUpDownTimer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 177);
            this.panel3.TabIndex = 2;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(3, 153);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(33, 13);
            this.pathLabel.TabIndex = 10;
            this.pathLabel.Text = "Path";
            // 
            // imageNameLabel
            // 
            this.imageNameLabel.AutoSize = true;
            this.imageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageNameLabel.Location = new System.Drawing.Point(3, 19);
            this.imageNameLabel.Name = "imageNameLabel";
            this.imageNameLabel.Size = new System.Drawing.Size(39, 13);
            this.imageNameLabel.TabIndex = 9;
            this.imageNameLabel.Text = "Name";
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleLabel.Location = new System.Drawing.Point(3, 48);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(35, 13);
            this.styleLabel.TabIndex = 8;
            this.styleLabel.Text = "Style";
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Items.AddRange(new object[] {
            "Tile",
            "Center",
            "Stretch",
            "Fit",
            "Fill",
            "Span"});
            this.styleComboBox.Location = new System.Drawing.Point(74, 45);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(76, 21);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.SelectionChangeCommitted += new System.EventHandler(this.styleComboBox_SelectionChangeCommitted);
            // 
            // imageNameTextBox
            // 
            this.imageNameTextBox.Location = new System.Drawing.Point(74, 16);
            this.imageNameTextBox.Name = "imageNameTextBox";
            this.imageNameTextBox.Size = new System.Drawing.Size(76, 20);
            this.imageNameTextBox.TabIndex = 6;
            // 
            // imageDirLabel
            // 
            this.imageDirLabel.Location = new System.Drawing.Point(74, 150);
            this.imageDirLabel.Name = "imageDirLabel";
            this.imageDirLabel.Size = new System.Drawing.Size(76, 20);
            this.imageDirLabel.TabIndex = 5;
            // 
            // bufferLabel
            // 
            this.bufferLabel.AutoSize = true;
            this.bufferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bufferLabel.Location = new System.Drawing.Point(3, 100);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(69, 13);
            this.bufferLabel.TabIndex = 4;
            this.bufferLabel.Text = "Buffer Size";
            // 
            // numericUpDownBuffer
            // 
            this.numericUpDownBuffer.Location = new System.Drawing.Point(74, 98);
            this.numericUpDownBuffer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBuffer.Name = "numericUpDownBuffer";
            this.numericUpDownBuffer.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownBuffer.TabIndex = 3;
            this.numericUpDownBuffer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBuffer.ValueChanged += new System.EventHandler(this.numericUpDownBuffer_ValueChanged);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(3, 74);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(70, 13);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Timer (sec)";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTimer.Location = new System.Drawing.Point(74, 72);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDownTimer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownTimer.TabIndex = 1;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTimer.ValueChanged += new System.EventHandler(this.numericUpDownTimer_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 145);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(52, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // switchCounter
            // 
            this.switchCounter.Interval = 2000;
            this.switchCounter.Tick += new System.EventHandler(this.switchCounter_Tick);
            // 
            // startupTimer
            // 
            this.startupTimer.Enabled = true;
            this.startupTimer.Interval = 500;
            this.startupTimer.Tick += new System.EventHandler(this.startupTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextIconRightClick;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "NANI?!";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextIconRightClick
            // 
            this.contextIconRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.switchToolStripMenuItem,
            this.favoriteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextIconRightClick.Name = "contextIconRightClick";
            this.contextIconRightClick.Size = new System.Drawing.Size(117, 92);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            this.switchToolStripMenuItem.Click += new System.EventHandler(this.Switch_Click);
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.CheckOnClick = true;
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            this.favoriteToolStripMenuItem.Click += new System.EventHandler(this.favoriteToolStripMenuItem_CheckedChanged);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // favoriteFreq_numericUpDown1
            // 
            this.favoriteFreq_numericUpDown1.Location = new System.Drawing.Point(74, 124);
            this.favoriteFreq_numericUpDown1.Name = "favoriteFreq_numericUpDown1";
            this.favoriteFreq_numericUpDown1.Size = new System.Drawing.Size(76, 20);
            this.favoriteFreq_numericUpDown1.TabIndex = 11;
            this.favoriteFreq_numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.favoriteFreq_numericUpDown1.ValueChanged += new System.EventHandler(this.favoriteFreq_numericUpDown1_ValueChanged);
            // 
            // favFrequencyLabel
            // 
            this.favFrequencyLabel.AutoSize = true;
            this.favFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favFrequencyLabel.Location = new System.Drawing.Point(3, 126);
            this.favFrequencyLabel.Name = "favFrequencyLabel";
            this.favFrequencyLabel.Size = new System.Drawing.Size(70, 13);
            this.favFrequencyLabel.TabIndex = 12;
            this.favFrequencyLabel.Text = "Fav Freq %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(304, 337);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BackgroundChanger";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextIconRightClick.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.favoriteFreq_numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer switchCounter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label bufferLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownBuffer;
        private System.Windows.Forms.Button chooseDirButton;
        private System.Windows.Forms.TextBox imageDirLabel;
        private System.Windows.Forms.FolderBrowserDialog imageDirDialog;
        private System.Windows.Forms.TextBox imageNameTextBox;
        private System.Windows.Forms.Timer startupTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.ContextMenuStrip contextIconRightClick;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.Label styleLabel;
        private System.Windows.Forms.Label imageNameLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown favoriteFreq_numericUpDown1;
        private System.Windows.Forms.Label favFrequencyLabel;
    }
}

