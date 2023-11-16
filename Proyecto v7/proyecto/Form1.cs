using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexion;
        private conex ConexionDB;

        public Form1()
        {
            InitializeComponent();
            ConexionDB = new conex();
            Conexion = ConexionDB.GetConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();

            if (!string.IsNullOrEmpty(usuario))
            {
                // Conectar a la base de datos utilizando la instancia de conex
                using (MySqlConnection connection = ConexionDB.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO usuarios (Admin) VALUES (@Usuario)";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", usuario);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show($"Nombre de usuario '{usuario}' ingresado y almacenado en la base de datos.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al intentar insertar en la base de datos: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ingresó un nombre de usuario.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PedidosV2 frmS = new PedidosV2();
            frmS.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PedidosV2 frmS = new PedidosV2();
            frmS.Show();
        }

        private void btnInterfazGO_Click(object sender, EventArgs e)
        {
            InterfazPrincipal frmS = new InterfazPrincipal();
            frmS.Show();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            // Puedes realizar acciones relacionadas con el cambio de texto en el control User.
        }

        private void btnOtroLogin_Click(object sender, EventArgs e)
        {
            Login frms = new Login();
            frms.Show();
        }
    }
}
