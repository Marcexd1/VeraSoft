using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Login : Form
    {
        private MySqlConnection Conexion;
        private conex ConexionDB;
        public Login()
        {
            InitializeComponent();
            ConexionDB = new conex();
            Conexion = ConexionDB.GetConnection();

        }

        private void picOjoOcultar_Click(object sender, EventArgs e)
        {
            picOjoMostrar.BringToFront();
            txtPassWord.PasswordChar = '*';
        }

        private void picOjoMostrar_Click(object sender, EventArgs e)
        {
            picOjoMostrar.BringToFront();
            txtPassWord.PasswordChar = '\0';
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string contraseña = txtPassWord.Text.Trim();

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contraseña))
            {
                using (MySqlConnection connection = ConexionDB.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        // Verificar las credenciales del usuario y obtener el rol
                        string query = "SELECT Rol FROM usuarios WHERE Rol = @Usuario AND Contraseña = @Contraseña";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", usuario);
                            cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                            // Obtener el rol del usuario
                            string rol = cmd.ExecuteScalar() as string;

                            if (!string.IsNullOrEmpty(rol))
                            {
                                // Inicio de sesión exitoso
                                HandleLoginInformation(rol);
                            }
                            else
                            {
                                // Credenciales incorrectas
                                MessageBox.Show("Credenciales incorrectas. Por favor, verifica el usuario y la contraseña.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al intentar verificar las credenciales: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa tanto el nombre de usuario como la contraseña.");
            }

            // ...

            void HandleLoginInformation(string rol)
            {
                switch (rol.ToLower())
                {
                    case "cocina":
                        MessageBox.Show("Inicio de sesión exitoso como Cocina. Realizar acciones específicas para Cocina.");
                        // Lógica específica para el rol de Cocina
                        break;
                    case "recepcion":
                        MessageBox.Show("Inicio de sesión exitoso como Recepcion. Realizar acciones específicas para Recepcion.");
                        // Lógica específica para el rol de Recepcion
                        break;
                    case "chiviteria":
                        MessageBox.Show("Inicio de sesión exitoso como Chiviteria. Realizar acciones específicas para Chiviteria.");
                        // Lógica específica para el rol de Chiviteria
                        break;
                    case "admin":
                        MessageBox.Show("Inicio de sesión exitoso como Admin. Realizar acciones específicas para Admin.");
                        // Lógica específica para el rol de Admin
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido. No se puede determinar la acción a realizar.");
                        break;
                }
            }
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
