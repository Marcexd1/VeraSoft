using System;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FrMainStock : Form
    {


        public FrMainStock()
        {
            InitializeComponent();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            string nombre = Nombree.Text;
            int cantidad = 0;
            decimal precio = decimal.Parse(Precio.Text);

            if (int.TryParse(Cantidad.Text, out cantidad))
            {

                string producto = $" {nombre}       Cantidad:  {cantidad}       Precio:  ${precio} ";

                lstProductos.Items.Add(producto);

                LimpiarCampos();

            }
            else
                MessageBox.Show("ingrese una cantidad valida");
        }


        private void listProductos(object sender, EventArgs e)
        {

        }



        private void BBorrar_Click_1(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                lstProductos.Items.RemoveAt(lstProductos.SelectedIndex);
                LimpiarCampos();
            }
        }



        private void BEditar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                int indice = lstProductos.SelectedIndex;

                string nombre = Nombree.Text;
                int cantidad = 0;
                decimal precio = decimal.Parse(Precio.Text);

                if (int.TryParse(Cantidad.Text, out cantidad))
                {
                    string producto = $"{nombre} - Cantidad: {cantidad}, Precio: {precio:C}";

                    lstProductos.Items.Add(producto);

                    LimpiarCampos();
                }
                else
                    MessageBox.Show("ingrese una cantidad  valida");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            Nombree.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";
            lstProductos.ClearSelected();
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
