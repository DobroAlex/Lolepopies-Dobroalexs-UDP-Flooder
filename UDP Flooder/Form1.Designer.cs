namespace UDP_Flooder
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
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.isRandomMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.MessgaSizeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MessageSizeTextBox = new System.Windows.Forms.TextBox();
            this.BytesLabel = new System.Windows.Forms.Label();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ThreadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RequestPerThreadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestPerThreadNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(13, 13);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(59, 17);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(12, 44);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(12, 78);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(34, 17);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(79, 44);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextBox.TabIndex = 3;
            this.AddressTextBox.Text = "127.0.0.1";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(79, 76);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 22);
            this.PortTextBox.TabIndex = 4;
            this.PortTextBox.Text = "9898";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(218, 49);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(65, 17);
            this.MessageLabel.TabIndex = 5;
            this.MessageLabel.Text = "Message";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(290, 44);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(100, 22);
            this.MessageTextBox.TabIndex = 6;
            this.MessageTextBox.Text = "GET RECKT";
            // 
            // isRandomMessageCheckBox
            // 
            this.isRandomMessageCheckBox.AutoSize = true;
            this.isRandomMessageCheckBox.Location = new System.Drawing.Point(414, 44);
            this.isRandomMessageCheckBox.Name = "isRandomMessageCheckBox";
            this.isRandomMessageCheckBox.Size = new System.Drawing.Size(152, 21);
            this.isRandomMessageCheckBox.TabIndex = 7;
            this.isRandomMessageCheckBox.Text = "Random message?";
            this.isRandomMessageCheckBox.UseVisualStyleBackColor = true;
            // 
            // MessgaSizeLabel
            // 
            this.MessgaSizeLabel.AutoSize = true;
            this.MessgaSizeLabel.Location = new System.Drawing.Point(221, 76);
            this.MessgaSizeLabel.Name = "MessgaSizeLabel";
            this.MessgaSizeLabel.Size = new System.Drawing.Size(96, 17);
            this.MessgaSizeLabel.TabIndex = 8;
            this.MessgaSizeLabel.Text = "Message Size";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(224, 97);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 56);
            this.trackBar1.TabIndex = 9;
            // 
            // MessageSizeTextBox
            // 
            this.MessageSizeTextBox.Location = new System.Drawing.Point(414, 75);
            this.MessageSizeTextBox.Name = "MessageSizeTextBox";
            this.MessageSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.MessageSizeTextBox.TabIndex = 10;
            // 
            // BytesLabel
            // 
            this.BytesLabel.AutoSize = true;
            this.BytesLabel.Location = new System.Drawing.Point(524, 76);
            this.BytesLabel.Name = "BytesLabel";
            this.BytesLabel.Size = new System.Drawing.Size(42, 17);
            this.BytesLabel.TabIndex = 11;
            this.BytesLabel.Text = "bytes";
            // 
            // ThreadsLabel
            // 
            this.ThreadsLabel.AutoSize = true;
            this.ThreadsLabel.Location = new System.Drawing.Point(13, 136);
            this.ThreadsLabel.Name = "ThreadsLabel";
            this.ThreadsLabel.Size = new System.Drawing.Size(61, 17);
            this.ThreadsLabel.TabIndex = 12;
            this.ThreadsLabel.Text = "Threads";
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(218, 135);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(72, 17);
            this.DelayLabel.TabIndex = 14;
            this.DelayLabel.Text = "Delay(ms)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Request per thread";
            // 
            // ThreadsNumericUpDown
            // 
            this.ThreadsNumericUpDown.Location = new System.Drawing.Point(79, 136);
            this.ThreadsNumericUpDown.Name = "ThreadsNumericUpDown";
            this.ThreadsNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.ThreadsNumericUpDown.TabIndex = 17;
            this.ThreadsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DelayNumericUpDown
            // 
            this.DelayNumericUpDown.Location = new System.Drawing.Point(297, 135);
            this.DelayNumericUpDown.Name = "DelayNumericUpDown";
            this.DelayNumericUpDown.Size = new System.Drawing.Size(93, 22);
            this.DelayNumericUpDown.TabIndex = 18;
            this.DelayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RequestPerThreadNumericUpDown
            // 
            this.RequestPerThreadNumericUpDown.Location = new System.Drawing.Point(548, 136);
            this.RequestPerThreadNumericUpDown.Name = "RequestPerThreadNumericUpDown";
            this.RequestPerThreadNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.RequestPerThreadNumericUpDown.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.RequestPerThreadNumericUpDown);
            this.Controls.Add(this.DelayNumericUpDown);
            this.Controls.Add(this.ThreadsNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.BytesLabel);
            this.Controls.Add(this.MessageSizeTextBox);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.MessgaSizeLabel);
            this.Controls.Add(this.isRandomMessageCheckBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.SettingsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestPerThreadNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.CheckBox isRandomMessageCheckBox;
        private System.Windows.Forms.Label MessgaSizeLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox MessageSizeTextBox;
        private System.Windows.Forms.Label BytesLabel;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ThreadsNumericUpDown;
        private System.Windows.Forms.NumericUpDown DelayNumericUpDown;
        private System.Windows.Forms.NumericUpDown RequestPerThreadNumericUpDown;
    }
}