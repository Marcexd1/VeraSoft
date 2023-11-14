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
            MessageBox.Show("a");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrPedidos frmS = new FrPedidos();
            frmS.Show();

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrPedidos frmS = new FrPedidos();
            frmS.Show();
        }


        private void btnInterfazGO_Click(object sender, EventArgs e)
        {
            InterfazPrincipal frmS = new InterfazPrincipal();
            frmS.Show();
        }
    }
}

