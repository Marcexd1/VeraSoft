﻿namespace proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInterfazGO = new System.Windows.Forms.Button();
            this.btnOtroLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(115, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(202, 20);
            this.txtUser.TabIndex = 0;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(115, 98);
            this.Contra.Name = "Contra";
            this.Contra.PasswordChar = '*';
            this.Contra.Size = new System.Drawing.Size(202, 20);
            this.Contra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lilita One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(271, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stocks";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnInterfazGO
            // 
            this.btnInterfazGO.BackColor = System.Drawing.Color.White;
            this.btnInterfazGO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInterfazGO.BackgroundImage")));
            this.btnInterfazGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInterfazGO.FlatAppearance.BorderSize = 0;
            this.btnInterfazGO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnInterfazGO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterfazGO.Font = new System.Drawing.Font("Lilita One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterfazGO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInterfazGO.Location = new System.Drawing.Point(69, 142);
            this.btnInterfazGO.Name = "btnInterfazGO";
            this.btnInterfazGO.Size = new System.Drawing.Size(75, 23);
            this.btnInterfazGO.TabIndex = 6;
            this.btnInterfazGO.Text = "Interfaz";
            this.btnInterfazGO.UseVisualStyleBackColor = false;
            this.btnInterfazGO.Click += new System.EventHandler(this.btnInterfazGO_Click);
            // 
            // btnOtroLogin
            // 
            this.btnOtroLogin.Location = new System.Drawing.Point(171, 69);
            this.btnOtroLogin.Name = "btnOtroLogin";
            this.btnOtroLogin.Size = new System.Drawing.Size(75, 23);
            this.btnOtroLogin.TabIndex = 7;
            this.btnOtroLogin.Text = "Login 2.0";
            this.btnOtroLogin.UseVisualStyleBackColor = true;
            this.btnOtroLogin.Click += new System.EventHandler(this.btnOtroLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 183);
            this.Controls.Add(this.btnOtroLogin);
            this.Controls.Add(this.btnInterfazGO);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInterfazGO;
        private System.Windows.Forms.Button btnOtroLogin;
    }
}

