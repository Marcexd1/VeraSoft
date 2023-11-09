namespace proyecto
{
    partial class FrMainStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BAgregar = new System.Windows.Forms.Button();
            this.BBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LbNP = new System.Windows.Forms.Label();
            this.LbP = new System.Windows.Forms.Label();
            this.LbCant = new System.Windows.Forms.Label();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.dgvNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.SuspendLayout();
            // 
            // BAgregar
            // 
            this.BAgregar.ForeColor = System.Drawing.Color.Crimson;
            this.BAgregar.Location = new System.Drawing.Point(348, 415);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 9;
            this.BAgregar.Text = "agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // BBorrar
            // 
            this.BBorrar.ForeColor = System.Drawing.Color.Crimson;
            this.BBorrar.Location = new System.Drawing.Point(12, 415);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(75, 23);
            this.BBorrar.TabIndex = 12;
            this.BBorrar.Text = "eliminar";
            this.BBorrar.UseVisualStyleBackColor = true;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click_1);
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(177, 380);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 20);
            this.Precio.TabIndex = 15;
  
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Pedidos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbNP
            // 
            this.LbNP.AutoSize = true;
            this.LbNP.Location = new System.Drawing.Point(9, 364);
            this.LbNP.Name = "LbNP";
            this.LbNP.Size = new System.Drawing.Size(107, 13);
            this.LbNP.TabIndex = 21;
            this.LbNP.Text = "Nombre del Producto";
            // 
            // LbP
            // 
            this.LbP.AutoSize = true;
            this.LbP.Location = new System.Drawing.Point(212, 364);
            this.LbP.Name = "LbP";
            this.LbP.Size = new System.Drawing.Size(37, 13);
            this.LbP.TabIndex = 22;
            this.LbP.Text = "Precio";
            // 
            // LbCant
            // 
            this.LbCant.AutoSize = true;
            this.LbCant.Location = new System.Drawing.Point(354, 364);
            this.LbCant.Name = "LbCant";
            this.LbCant.Size = new System.Drawing.Size(49, 13);
            this.LbCant.TabIndex = 23;
            this.LbCant.Text = "Cantidad";
            // 
            // dgvInv
            // 
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNom,
            this.dgvPrecio,
            this.dgvCantidad,
            this.dgvGT});
            this.dgvInv.Location = new System.Drawing.Point(6, 12);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.Size = new System.Drawing.Size(788, 274);
            this.dgvInv.TabIndex = 1;
            // 
            // dgvNom
            // 
            this.dgvNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvNom.HeaderText = "Nombre";
            this.dgvNom.Name = "dgvNom";
            this.dgvNom.Width = 69;
            // 
            // dgvPrecio
            // 
            this.dgvPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvPrecio.HeaderText = "Precio/KG";
            this.dgvPrecio.Name = "dgvPrecio";
            this.dgvPrecio.Width = 82;
            // 
            // dgvCantidad
            // 
            this.dgvCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvCantidad.HeaderText = "Cantidad/KG";
            this.dgvCantidad.Name = "dgvCantidad";
            this.dgvCantidad.Width = 94;
            // 
            // dgvGT
            // 
            this.dgvGT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvGT.HeaderText = "Gasto Total";
            this.dgvGT.Name = "dgvGT";
            this.dgvGT.ReadOnly = true;
            this.dgvGT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGT.Width = 87;

        }

        #endregion

        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LbNP;
        private System.Windows.Forms.Label LbP;
        private System.Windows.Forms.Label LbCant;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGT;
    }
}