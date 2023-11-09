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
            String sPass = Encrypt.GetSHA256(Contra.Text.Trim());

            //using (Models.WindowsFormsEntities db = new Models.WindowsFormsEntities())
            // {
            //     var lst = from d in db.user
            //              where d.email == txtUser.text
            //              && d.password == sPass
            //              select d;
            //        if (lst.Count > 0 ) {
            //        MessageBox.Show("Usuario Existe");
            //    }
            //   else
            //    {
            //        MessageBox.Show("Usuario No Existe");
            //    }

            //if (User == )
            //0;
            {

            }
            this.Hide();
            FrMain frm = new FrMain();
            frm.Show();
            frm.FormClosed += (S, Args) => this.Close();
            this.Close();
            FrMainStock frmS = new FrMainStock();
            frmS.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrMainStock frmS = new FrMainStock();
            frmS.Show();

        }
    }
}

