using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = this.Font;
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.ForeColor;
            colorDialog1.ShowDialog();
            this.ForeColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newBox = new AboutBox1();
            newBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fullname ="My Full Name is: "+textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            MessageBox.Show(fullname);
        }
    }
}
