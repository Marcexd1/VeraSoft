namespace proyecto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picOjoMostrar = new System.Windows.Forms.PictureBox();
            this.picOjoOcultar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOjoMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOjoOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImage = global::proyecto.Properties.Resources.BotonDeselected;
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(195, 227);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(164, 67);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = " Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(139, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassWord.Location = new System.Drawing.Point(139, 183);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(220, 20);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPassWord.Location = new System.Drawing.Point(29, 180);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(111, 24);
            this.lblPassWord.TabIndex = 3;
            this.lblPassWord.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblUser.Location = new System.Drawing.Point(59, 127);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 24);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iniciar Secion";
            // 
            // picOjoMostrar
            // 
            this.picOjoMostrar.BackColor = System.Drawing.Color.Transparent;
            this.picOjoMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOjoMostrar.Image = global::proyecto.Properties.Resources.Mostrando_Contra;
            this.picOjoMostrar.Location = new System.Drawing.Point(366, 178);
            this.picOjoMostrar.Name = "picOjoMostrar";
            this.picOjoMostrar.Size = new System.Drawing.Size(30, 30);
            this.picOjoMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOjoMostrar.TabIndex = 7;
            this.picOjoMostrar.TabStop = false;
            this.picOjoMostrar.Click += new System.EventHandler(this.picOjoMostrar_Click);
            // 
            // picOjoOcultar
            // 
            this.picOjoOcultar.BackColor = System.Drawing.Color.Transparent;
            this.picOjoOcultar.Image = global::proyecto.Properties.Resources.Ocultando_Contra;
            this.picOjoOcultar.Location = new System.Drawing.Point(366, 178);
            this.picOjoOcultar.Name = "picOjoOcultar";
            this.picOjoOcultar.Size = new System.Drawing.Size(30, 30);
            this.picOjoOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOjoOcultar.TabIndex = 8;
            this.picOjoOcultar.TabStop = false;
            this.picOjoOcultar.Click += new System.EventHandler(this.picOjoOcultar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::proyecto.Properties.Resources.Login_Diseño;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.Controls.Add(this.picOjoOcultar);
            this.Controls.Add(this.picOjoMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnIniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picOjoMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOjoOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOjoMostrar;
        private System.Windows.Forms.PictureBox picOjoOcultar;
    }
}