using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Form_vaildator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "right";
            lbloutput.Left = 240;
        }

        private void btnLatinMedium_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "center";
            lbloutput.Left = (ClientSize.Width - lbloutput.Width) / 2);
        }

        private void btnLatinsisiter_Click(object sender, EventArgs e)
        {
            lbloutput.Text = "left";
            lbloutput.Left = 50;
        }
    }
}
