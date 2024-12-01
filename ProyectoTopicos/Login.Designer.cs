namespace ProyectoTopicos
{
    partial class Login
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
            this.ImagenCimarron2 = new System.Windows.Forms.PictureBox();
            this.ImagenCimarron1 = new System.Windows.Forms.PictureBox();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelContraseña = new System.Windows.Forms.Label();
            this.MostrarContraseña = new System.Windows.Forms.CheckBox();
            this.buttonInicioDeCesion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenCimarron2
            // 
            this.ImagenCimarron2.Image = global::ProyectoTopicos.Properties.Resources.strong_ram_mascot_free_vector;
            this.ImagenCimarron2.Location = new System.Drawing.Point(226, 383);
            this.ImagenCimarron2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImagenCimarron2.Name = "ImagenCimarron2";
            this.ImagenCimarron2.Size = new System.Drawing.Size(133, 126);
            this.ImagenCimarron2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenCimarron2.TabIndex = 1;
            this.ImagenCimarron2.TabStop = false;
            this.ImagenCimarron2.Click += new System.EventHandler(this.ImagenCimarron2_Click);
            // 
            // ImagenCimarron1
            // 
            this.ImagenCimarron1.Image = global::ProyectoTopicos.Properties.Resources.OIP;
            this.ImagenCimarron1.Location = new System.Drawing.Point(95, 11);
            this.ImagenCimarron1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImagenCimarron1.Name = "ImagenCimarron1";
            this.ImagenCimarron1.Size = new System.Drawing.Size(206, 192);
            this.ImagenCimarron1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenCimarron1.TabIndex = 0;
            this.ImagenCimarron1.TabStop = false;
            this.ImagenCimarron1.Click += new System.EventHandler(this.ImagenCimarron1_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(34, 227);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(142, 18);
            this.LabelUsuario.TabIndex = 2;
            this.LabelUsuario.Text = "Usuario Cimarron";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(34, 307);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(139, 18);
            this.LabelContraseña.TabIndex = 3;
            this.LabelContraseña.Text = "Cima Contraseña";
            this.LabelContraseña.Click += new System.EventHandler(this.LabelContraseña_Click);
            // 
            // MostrarContraseña
            // 
            this.MostrarContraseña.AutoSize = true;
            this.MostrarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarContraseña.Location = new System.Drawing.Point(37, 383);
            this.MostrarContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostrarContraseña.Name = "MostrarContraseña";
            this.MostrarContraseña.Size = new System.Drawing.Size(85, 21);
            this.MostrarContraseña.TabIndex = 6;
            this.MostrarContraseña.Text = "Mostrar";
            this.MostrarContraseña.UseVisualStyleBackColor = true;
            this.MostrarContraseña.CheckedChanged += new System.EventHandler(this.MostrarContraseña_CheckedChanged);
            // 
            // buttonInicioDeCesion
            // 
            this.buttonInicioDeCesion.BackColor = System.Drawing.Color.Green;
            this.buttonInicioDeCesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicioDeCesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonInicioDeCesion.Location = new System.Drawing.Point(37, 462);
            this.buttonInicioDeCesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInicioDeCesion.Name = "buttonInicioDeCesion";
            this.buttonInicioDeCesion.Size = new System.Drawing.Size(172, 47);
            this.buttonInicioDeCesion.TabIndex = 7;
            this.buttonInicioDeCesion.Text = "Iniciar Sesión";
            this.buttonInicioDeCesion.UseVisualStyleBackColor = false;
            this.buttonInicioDeCesion.Click += new System.EventHandler(this.buttonInicioDeCesion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(389, 529);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInicioDeCesion);
            this.Controls.Add(this.MostrarContraseña);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.ImagenCimarron2);
            this.Controls.Add(this.ImagenCimarron1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login UABC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenCimarron1;
        private System.Windows.Forms.PictureBox ImagenCimarron2;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelContraseña;
        private System.Windows.Forms.CheckBox MostrarContraseña;
        private System.Windows.Forms.Button buttonInicioDeCesion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

