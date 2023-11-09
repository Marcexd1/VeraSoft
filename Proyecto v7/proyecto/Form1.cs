using System;
using System.Windows.Forms;

namespace proyecto
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

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrMainStock frmS = new FrMainStock();
            frmS.Show();

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrMainStock frmS = new FrMainStock();
            frmS.Show();
        }
    }
}

