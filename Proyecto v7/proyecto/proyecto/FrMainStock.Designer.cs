﻿namespace proyecto
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
            this.BEditar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.Nombree = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAgregar
            // 
            this.BAgregar.ForeColor = System.Drawing.Color.Crimson;
            this.BAgregar.Location = new System.Drawing.Point(143, 415);
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
            this.BBorrar.Location = new System.Drawing.Point(499, 415);
            this.BBorrar.Name = "BBorrar";
            this.BBorrar.Size = new System.Drawing.Size(75, 23);
            this.BBorrar.TabIndex = 12;
            this.BBorrar.Text = "eliminar";
            this.BBorrar.UseVisualStyleBackColor = true;
            this.BBorrar.Click += new System.EventHandler(this.BBorrar_Click_1);
            // 
            // BEditar
            // 
            this.BEditar.ForeColor = System.Drawing.Color.Crimson;
            this.BEditar.Location = new System.Drawing.Point(324, 415);
            this.BEditar.Name = "BEditar";
            this.BEditar.Size = new System.Drawing.Size(75, 23);
            this.BEditar.TabIndex = 13;
            this.BEditar.Text = "editar";
            this.BEditar.UseVisualStyleBackColor = true;
            this.BEditar.Click += new System.EventHandler(this.BEditar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstProductos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 346);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario";
            // 
            // lstProductos
            // 
            this.lstProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(3, 16);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(794, 329);
            this.lstProductos.TabIndex = 0;
            // 
            // Nombree
            // 
            this.Nombree.Location = new System.Drawing.Point(143, 380);
            this.Nombree.Name = "Nombree";
            this.Nombree.Size = new System.Drawing.Size(100, 20);
            this.Nombree.TabIndex = 14;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(308, 380);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(100, 20);
            this.Precio.TabIndex = 15;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(489, 380);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Cantidad.TabIndex = 16;
            this.Cantidad.TextChanged += new System.EventHandler(this.Cantidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre del Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Precio";
            // 
            // FrMainStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.BAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BBorrar);
            this.Controls.Add(this.BEditar);
            this.Controls.Add(this.Nombree);
            this.Controls.Add(this.Precio);
            this.Name = "FrMainStock";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Button BBorrar;
        private System.Windows.Forms.Button BEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Nombree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}