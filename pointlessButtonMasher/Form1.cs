using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pointlessButtonMasher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bagpuss;
        string radio;
        private void button1_Click(object sender, EventArgs e)
        {
            bagpuss ++;
            label2.Text = ("I have been pressed");
            radio = bagpuss.ToString();
            label1.Text = (radio + " Times");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created with love by OliPicard \n github.com/olipicard");
        }
    }
}
