using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Flooder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MessageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!isRandomMessageChackBox.Checked)
            {
                MessageSizeNumericUpDown.Value = Encoding.Default.GetByteCount(MessageTextBox.Text);
            }
            else
            {
                MessageTextBox.Text = Encoding.Default.GetString( 
                    Utils.GenerateRandomByteArray(
                    (int)MessageSizeNumericUpDown.Value));
            }
        }

        private void MessageTextBox_TextChanged(object sender, EventArgs e)
        {
            MessageSizeNumericUpDown.Value = Encoding.Default.GetByteCount(MessageTextBox.Text);
        }
    }
}
