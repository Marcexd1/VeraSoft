namespace proyecto
{
    partial class PedidosV2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CPreferencias = new System.Windows.Forms.TextBox();
            this.CMoD = new System.Windows.Forms.TextBox();
            this.cprecio = new System.Windows.Forms.TextBox();
            this.ccant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.cProd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Canti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa_o_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CPreferencias);
            this.panel1.Controls.Add(this.CMoD);
            this.panel1.Controls.Add(this.cprecio);
            this.panel1.Controls.Add(this.ccant);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cProd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 450);
            this.panel1.TabIndex = 0;
            // 
            // CPreferencias
            // 
            this.CPreferencias.Location = new System.Drawing.Point(399, 360);
            this.CPreferencias.Multiline = true;
            this.CPreferencias.Name = "CPreferencias";
            this.CPreferencias.Size = new System.Drawing.Size(282, 73);
            this.CPreferencias.TabIndex = 5;
            // 
            // CMoD
            // 
            this.CMoD.Location = new System.Drawing.Point(399, 314);
            this.CMoD.Multiline = true;
            this.CMoD.Name = "CMoD";
            this.CMoD.Size = new System.Drawing.Size(282, 27);
            this.CMoD.TabIndex = 4;
            // 
            // cprecio
            // 
            this.cprecio.Location = new System.Drawing.Point(207, 406);
            this.cprecio.Multiline = true;
            this.cprecio.Name = "cprecio";
            this.cprecio.Size = new System.Drawing.Size(165, 27);
            this.cprecio.TabIndex = 3;
            // 
            // ccant
            // 
            this.ccant.Location = new System.Drawing.Point(207, 360);
            this.ccant.Multiline = true;
            this.ccant.Name = "ccant";
            this.ccant.Size = new System.Drawing.Size(165, 27);
            this.ccant.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BotonEliminar);
            this.panel3.Controls.Add(this.BotonAgregar);
            this.panel3.Controls.Add(this.BotonModificar);
            this.panel3.Location = new System.Drawing.Point(12, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 138);
            this.panel3.TabIndex = 0;
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(3, 95);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(149, 40);
            this.BotonEliminar.TabIndex = 6;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(3, 3);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(149, 40);
            this.BotonAgregar.TabIndex = 5;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(3, 49);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(149, 40);
            this.BotonModificar.TabIndex = 4;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // cProd
            // 
            this.cProd.Location = new System.Drawing.Point(207, 314);
            this.cProd.Multiline = true;
            this.cProd.Name = "cProd";
            this.cProd.Size = new System.Drawing.Size(165, 27);
            this.cProd.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 227);
            this.panel2.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NombP,
            this.Canti,
            this.Prefere,
            this.Mesa_o_Direccion,
            this.Prec});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(711, 227);
            this.dgv.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 28;
            // 
            // NombP
            // 
            this.NombP.HeaderText = "Nombre  Producto";
            this.NombP.Name = "NombP";
            this.NombP.ReadOnly = true;
            this.NombP.Width = 166;
            // 
            // Canti
            // 
            this.Canti.HeaderText = "Cantidad";
            this.Canti.Name = "Canti";
            this.Canti.ReadOnly = true;
            // 
            // Prefere
            // 
            this.Prefere.HeaderText = "Preferencias";
            this.Prefere.Name = "Prefere";
            this.Prefere.ReadOnly = true;
            this.Prefere.Width = 133;
            // 
            // Mesa_o_Direccion
            // 
            this.Mesa_o_Direccion.HeaderText = "Mesa o Direccion";
            this.Mesa_o_Direccion.Name = "Mesa_o_Direccion";
            this.Mesa_o_Direccion.Width = 166;
            // 
            // Prec
            // 
            this.Prec.HeaderText = "Precio";
            this.Prec.Name = "Prec";
            this.Prec.Width = 75;
            // 
            // PedidosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PedidosV2";
            this.Text = "PedidosV2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox CPreferencias;
        private System.Windows.Forms.TextBox CMoD;
        private System.Windows.Forms.TextBox cprecio;
        private System.Windows.Forms.TextBox ccant;
        private System.Windows.Forms.TextBox cProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Canti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa_o_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prec;
    }
}