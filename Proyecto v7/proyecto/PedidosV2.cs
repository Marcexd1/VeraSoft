using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
	public partial class PedidosV2 : Form
	{
		public PedidosV2()
		{
			InitializeComponent();
		}
		int codP = 1;
		private void BotonAgregar_Click(object sender, EventArgs e)
		{
			String Pedido = cProd.Text;
			String cantidad = ccant.Text;
			String Preferencias = CPreferencias.Text;
			String Mesa_Dire = CMoD.Text;
			String Precio = cprecio.Text;
				dgv.Rows.Add(codP++, Pedido, cantidad, Preferencias, Mesa_Dire, Precio);
		}

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            String Pedido = cProd.Text;
            String cantidad = ccant.Text;
            String Preferencias = CPreferencias.Text;
            String Mesa_Dire = CMoD.Text;
            String Precio = cprecio.Text;

            // Limpia las TextBox
            cProd.Text = "";
            ccant.Text = "";
            CPreferencias.Text = "";
            CMoD.Text = "";
            cprecio.Text = "";

        }


           private void BotonModificar_Click(object sender, EventArgs e)
{
    int filaSeleccionada = dgv.CurrentCell.RowIndex;

    if (filaSeleccionada >= 0)
    {
        // Obtiene los valores actuales de la fila seleccionada en el DataGridView
        string PedidoDGV = dgv.Rows[filaSeleccionada].Cells["NombP"].Value.ToString();
        int cantidadDGV = Convert.ToInt32(dgv.Rows[filaSeleccionada].Cells["Canti"].Value);
        int PrecioDGV = Convert.ToInt32(dgv.Rows[filaSeleccionada].Cells["Prec"].Value);
        string PreferenciasDGV = dgv.Rows[filaSeleccionada].Cells["Prefere"].Value.ToString();
        string Mesa_DireDGV = dgv.Rows[filaSeleccionada].Cells["Mesa_o_Direccion"].Value.ToString();

        // Obtén los valores de las TextBox
        string Pedido = cProd.Text;
        string Preferencias = CPreferencias.Text;
        string Mesa_Dire = CMoD.Text;
        int cantidad;
        int Precio;

        // Verifica si los datos en las TextBox no son nulos y son valores enteros válidos
        if (!string.IsNullOrEmpty(ccant.Text) && int.TryParse(ccant.Text, out cantidad))
        {
            cantidad = cantidad; // Usa el valor ingresado
        }
        else
        {
            cantidad = cantidadDGV; // Mantén el valor original
        }

        if (!string.IsNullOrEmpty(cprecio.Text) && int.TryParse(cprecio.Text, out Precio))
        {
            Precio = Precio; // Usa el valor ingresado
        }
        else
        {
            Precio = PrecioDGV; // Mantén el valor original
        }

        if (!string.IsNullOrEmpty(Pedido))
        {
            dgv.Rows[filaSeleccionada].Cells["NombP"].Value = Pedido;
        }

        if (!string.IsNullOrEmpty(Preferencias))
        {
            dgv.Rows[filaSeleccionada].Cells["Prefere"].Value = Preferencias;
        }

        if (!string.IsNullOrEmpty(Mesa_Dire))
        {
            dgv.Rows[filaSeleccionada].Cells["Mesa_o_Direccion"].Value = Mesa_Dire;
        }

        // Actualiza los valores de cantidad y precio
        dgv.Rows[filaSeleccionada].Cells["Canti"].Value = cantidad;
        dgv.Rows[filaSeleccionada].Cells["Prec"].Value = Precio;

        // Limpia las TextBox
        cProd.Text = "";
        ccant.Text = "";
        CPreferencias.Text = "";
        CMoD.Text = "";
        cprecio.Text = "";
    }
    else
    {
        MessageBox.Show("Selecciona una fila para modificar.");
                }
        }

    }
}
