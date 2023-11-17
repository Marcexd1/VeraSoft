namespace proyecto
{
    partial class InterfazPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazPrincipal));
            this.panel = new System.Windows.Forms.Panel();
            this.panelVertical = new System.Windows.Forms.Panel();
            this.Ajustes = new System.Windows.Forms.Button();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelVertical.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(200, 61);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(680, 430);
            this.panel.TabIndex = 2;
            // 
            // panelVertical
            // 
            this.panelVertical.BackgroundImage = global::proyecto.Properties.Resources.Barra_Vertical;
            this.panelVertical.Controls.Add(this.Ajustes);
            this.panelVertical.Controls.Add(this.btnIngresarDatos);
            this.panelVertical.Controls.Add(this.btnMostrarDatos);
            this.panelVertical.Controls.Add(this.btnSalir);
            this.panelVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVertical.Location = new System.Drawing.Point(0, 61);
            this.panelVertical.Name = "panelVertical";
            this.panelVertical.Size = new System.Drawing.Size(200, 430);
            this.panelVertical.TabIndex = 0;
            // 
            // Ajustes
            // 
            this.Ajustes.BackColor = System.Drawing.Color.Transparent;
            this.Ajustes.BackgroundImage = global::proyecto.Properties.Resources.Ajustes;
            this.Ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ajustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ajustes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Ajustes.FlatAppearance.BorderSize = 3;
            this.Ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajustes.Location = new System.Drawing.Point(3, 2);
            this.Ajustes.Name = "Ajustes";
            this.Ajustes.Size = new System.Drawing.Size(71, 70);
            this.Ajustes.TabIndex = 5;
            this.Ajustes.UseVisualStyleBackColor = false;
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.BackgroundImage = global::proyecto.Properties.Resources.BotonDeselected;
            this.btnIngresarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIngresarDatos.FlatAppearance.BorderSize = 0;
            this.btnIngresarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIngresarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnIngresarDatos.ForeColor = System.Drawing.Color.White;
            this.btnIngresarDatos.Location = new System.Drawing.Point(0, 202);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(200, 76);
            this.btnIngresarDatos.TabIndex = 4;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.BackgroundImage = global::proyecto.Properties.Resources.BotonDeselected;
            this.btnMostrarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMostrarDatos.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMostrarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMostrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMostrarDatos.ForeColor = System.Drawing.Color.White;
            this.btnMostrarDatos.Location = new System.Drawing.Point(0, 278);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(200, 76);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::proyecto.Properties.Resources.BotonDeselected;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 354);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 76);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHorizontal.BackgroundImage")));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.pictureLogo);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(880, 61);
            this.panelHorizontal.TabIndex = 1;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(197, 53);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelVertical);
            this.Controls.Add(this.panelHorizontal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.panelVertical.ResumeLayout(false);
            this.panelHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVertical;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button Ajustes;
    }
}