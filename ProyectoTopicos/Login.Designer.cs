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
            this.TextBoxDeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxDeContraseña = new System.Windows.Forms.TextBox();
            this.MostrarContraseña = new System.Windows.Forms.CheckBox();
            this.buttonInicioDeCesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCimarron1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenCimarron2
            // 
            this.ImagenCimarron2.Image = global::ProyectoTopicos.Properties.Resources.strong_ram_mascot_free_vector;
            this.ImagenCimarron2.Location = new System.Drawing.Point(389, 491);
            this.ImagenCimarron2.Name = "ImagenCimarron2";
            this.ImagenCimarron2.Size = new System.Drawing.Size(172, 158);
            this.ImagenCimarron2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenCimarron2.TabIndex = 1;
            this.ImagenCimarron2.TabStop = false;
            this.ImagenCimarron2.Click += new System.EventHandler(this.ImagenCimarron2_Click);
            // 
            // ImagenCimarron1
            // 
            this.ImagenCimarron1.Image = global::ProyectoTopicos.Properties.Resources.OIP;
            this.ImagenCimarron1.Location = new System.Drawing.Point(160, 12);
            this.ImagenCimarron1.Name = "ImagenCimarron1";
            this.ImagenCimarron1.Size = new System.Drawing.Size(232, 240);
            this.ImagenCimarron1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenCimarron1.TabIndex = 0;
            this.ImagenCimarron1.TabStop = false;
            this.ImagenCimarron1.Click += new System.EventHandler(this.ImagenCimarron1_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(103, 283);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(166, 22);
            this.LabelUsuario.TabIndex = 2;
            this.LabelUsuario.Text = "Usuario Cimarron";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // LabelContraseña
            // 
            this.LabelContraseña.AutoSize = true;
            this.LabelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelContraseña.Location = new System.Drawing.Point(103, 382);
            this.LabelContraseña.Name = "LabelContraseña";
            this.LabelContraseña.Size = new System.Drawing.Size(164, 22);
            this.LabelContraseña.TabIndex = 3;
            this.LabelContraseña.Text = "Cima Contraseña";
            this.LabelContraseña.Click += new System.EventHandler(this.LabelContraseña_Click);
            // 
            // TextBoxDeUsuario
            // 
            this.TextBoxDeUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.TextBoxDeUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDeUsuario.ForeColor = System.Drawing.Color.Green;
            this.TextBoxDeUsuario.Location = new System.Drawing.Point(107, 323);
            this.TextBoxDeUsuario.Name = "TextBoxDeUsuario";
            this.TextBoxDeUsuario.Size = new System.Drawing.Size(312, 33);
            this.TextBoxDeUsuario.TabIndex = 4;
            this.TextBoxDeUsuario.Text = "Usuario";
            this.TextBoxDeUsuario.TextChanged += new System.EventHandler(this.TextBoxDeUsuario_TextChanged);
            // 
            // textBoxDeContraseña
            // 
            this.textBoxDeContraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxDeContraseña.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeContraseña.ForeColor = System.Drawing.Color.Green;
            this.textBoxDeContraseña.Location = new System.Drawing.Point(107, 432);
            this.textBoxDeContraseña.Name = "textBoxDeContraseña";
            this.textBoxDeContraseña.Size = new System.Drawing.Size(312, 33);
            this.textBoxDeContraseña.TabIndex = 5;
            this.textBoxDeContraseña.Text = "Contraseña";
            this.textBoxDeContraseña.TextChanged += new System.EventHandler(this.textBoxDeContraseña_TextChanged);
            // 
            // MostrarContraseña
            // 
            this.MostrarContraseña.AutoSize = true;
            this.MostrarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarContraseña.Location = new System.Drawing.Point(213, 491);
            this.MostrarContraseña.Name = "MostrarContraseña";
            this.MostrarContraseña.Size = new System.Drawing.Size(96, 24);
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
            this.buttonInicioDeCesion.Location = new System.Drawing.Point(175, 532);
            this.buttonInicioDeCesion.Name = "buttonInicioDeCesion";
            this.buttonInicioDeCesion.Size = new System.Drawing.Size(170, 42);
            this.buttonInicioDeCesion.TabIndex = 7;
            this.buttonInicioDeCesion.Text = "Iniciar Sesión";
            this.buttonInicioDeCesion.UseVisualStyleBackColor = false;
            this.buttonInicioDeCesion.Click += new System.EventHandler(this.buttonInicioDeCesion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(573, 661);
            this.Controls.Add(this.buttonInicioDeCesion);
            this.Controls.Add(this.MostrarContraseña);
            this.Controls.Add(this.textBoxDeContraseña);
            this.Controls.Add(this.TextBoxDeUsuario);
            this.Controls.Add(this.LabelContraseña);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.ImagenCimarron2);
            this.Controls.Add(this.ImagenCimarron1);
            this.Name = "Login";
            this.Text = "Login UABC";
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
        private System.Windows.Forms.TextBox TextBoxDeUsuario;
        private System.Windows.Forms.TextBox textBoxDeContraseña;
        private System.Windows.Forms.CheckBox MostrarContraseña;
        private System.Windows.Forms.Button buttonInicioDeCesion;
    }
}

