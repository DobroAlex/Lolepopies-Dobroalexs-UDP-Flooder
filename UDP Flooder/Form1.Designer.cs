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
            this.MessageSizeLabel = new System.Windows.Forms.Label();
            this.BytesLabel = new System.Windows.Forms.Label();
            this.ThreadsLabel = new System.Windows.Forms.Label();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.RequestsPerThreadLabel = new System.Windows.Forms.Label();
            this.ThreadsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RequestsPerThreadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isRandomMessageChackBox = new System.Windows.Forms.CheckBox();
            this.MessageSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsPerThreadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsLabel.Location = new System.Drawing.Point(13, 13);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(108, 29);
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
            this.MessageTextBox.Size = new System.Drawing.Size(83, 22);
            this.MessageTextBox.TabIndex = 6;
            this.MessageTextBox.Text = "GET RECKT";
            this.MessageTextBox.TextChanged += new System.EventHandler(this.MessageTextBox_TextChanged);
            // 
            // MessageSizeLabel
            // 
            this.MessageSizeLabel.AutoSize = true;
            this.MessageSizeLabel.Location = new System.Drawing.Point(218, 78);
            this.MessageSizeLabel.Name = "MessageSizeLabel";
            this.MessageSizeLabel.Size = new System.Drawing.Size(96, 17);
            this.MessageSizeLabel.TabIndex = 8;
            this.MessageSizeLabel.Text = "Message Size";
            // 
            // BytesLabel
            // 
            this.BytesLabel.AutoSize = true;
            this.BytesLabel.Location = new System.Drawing.Point(388, 81);
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
            // RequestsPerThreadLabel
            // 
            this.RequestsPerThreadLabel.AutoSize = true;
            this.RequestsPerThreadLabel.Location = new System.Drawing.Point(388, 134);
            this.RequestsPerThreadLabel.Name = "RequestsPerThreadLabel";
            this.RequestsPerThreadLabel.Size = new System.Drawing.Size(138, 17);
            this.RequestsPerThreadLabel.TabIndex = 16;
            this.RequestsPerThreadLabel.Text = "Requests per thread";
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
            this.DelayNumericUpDown.Location = new System.Drawing.Point(306, 135);
            this.DelayNumericUpDown.Name = "DelayNumericUpDown";
            this.DelayNumericUpDown.Size = new System.Drawing.Size(76, 22);
            this.DelayNumericUpDown.TabIndex = 18;
            this.DelayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RequestsPerThreadNumericUpDown
            // 
            this.RequestsPerThreadNumericUpDown.Location = new System.Drawing.Point(523, 134);
            this.RequestsPerThreadNumericUpDown.Name = "RequestsPerThreadNumericUpDown";
            this.RequestsPerThreadNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.RequestsPerThreadNumericUpDown.TabIndex = 19;
            // 
            // isRandomMessageChackBox
            // 
            this.isRandomMessageChackBox.AutoSize = true;
            this.isRandomMessageChackBox.Location = new System.Drawing.Point(391, 44);
            this.isRandomMessageChackBox.Name = "isRandomMessageChackBox";
            this.isRandomMessageChackBox.Size = new System.Drawing.Size(170, 21);
            this.isRandomMessageChackBox.TabIndex = 20;
            this.isRandomMessageChackBox.Text = "Randomize message?";
            this.isRandomMessageChackBox.UseVisualStyleBackColor = true;
            // 
            // MessageSizeNumericUpDown
            // 
            this.MessageSizeNumericUpDown.Location = new System.Drawing.Point(321, 75);
            this.MessageSizeNumericUpDown.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.MessageSizeNumericUpDown.Name = "MessageSizeNumericUpDown";
            this.MessageSizeNumericUpDown.Size = new System.Drawing.Size(61, 22);
            this.MessageSizeNumericUpDown.TabIndex = 21;
            this.MessageSizeNumericUpDown.ValueChanged += new System.EventHandler(this.MessageSizeNumericUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.MessageSizeNumericUpDown);
            this.Controls.Add(this.isRandomMessageChackBox);
            this.Controls.Add(this.RequestsPerThreadNumericUpDown);
            this.Controls.Add(this.DelayNumericUpDown);
            this.Controls.Add(this.ThreadsNumericUpDown);
            this.Controls.Add(this.RequestsPerThreadLabel);
            this.Controls.Add(this.DelayLabel);
            this.Controls.Add(this.ThreadsLabel);
            this.Controls.Add(this.BytesLabel);
            this.Controls.Add(this.MessageSizeLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.ThreadsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsPerThreadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessageSizeNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label MessageSizeLabel;
        private System.Windows.Forms.Label BytesLabel;
        private System.Windows.Forms.Label ThreadsLabel;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.NumericUpDown ThreadsNumericUpDown;
        private System.Windows.Forms.NumericUpDown DelayNumericUpDown;
        private System.Windows.Forms.NumericUpDown RequestsPerThreadNumericUpDown;
        private System.Windows.Forms.Label RequestsPerThreadLabel;
        private System.Windows.Forms.CheckBox isRandomMessageChackBox;
        private System.Windows.Forms.NumericUpDown MessageSizeNumericUpDown;
    }
}