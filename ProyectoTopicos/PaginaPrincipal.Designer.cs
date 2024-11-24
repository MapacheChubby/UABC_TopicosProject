namespace ProyectoTopicos
{
    partial class PaginaPrincipal
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
            this.BIENVENIDO = new System.Windows.Forms.Label();
            this.labelSubtitulo = new System.Windows.Forms.Label();
            this.CimarronImagen = new System.Windows.Forms.PictureBox();
            this.CimaImagen2 = new System.Windows.Forms.PictureBox();
            this.BotonCatalogoFacultades = new System.Windows.Forms.Button();
            this.BotonCatálogoPrácticas = new System.Windows.Forms.Button();
            this.BotónCatálogoMaterias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CimarronImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CimaImagen2)).BeginInit();
            this.SuspendLayout();
            // 
            // BIENVENIDO
            // 
            this.BIENVENIDO.AutoSize = true;
            this.BIENVENIDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIENVENIDO.ForeColor = System.Drawing.Color.Gold;
            this.BIENVENIDO.Location = new System.Drawing.Point(270, 42);
            this.BIENVENIDO.Name = "BIENVENIDO";
            this.BIENVENIDO.Size = new System.Drawing.Size(381, 64);
            this.BIENVENIDO.TabIndex = 0;
            this.BIENVENIDO.Text = "BIENVENIDO";
            this.BIENVENIDO.Click += new System.EventHandler(this.BIENVENIDO_Click);
            // 
            // labelSubtitulo
            // 
            this.labelSubtitulo.AutoSize = true;
            this.labelSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitulo.ForeColor = System.Drawing.Color.Gold;
            this.labelSubtitulo.Location = new System.Drawing.Point(12, 143);
            this.labelSubtitulo.Name = "labelSubtitulo";
            this.labelSubtitulo.Size = new System.Drawing.Size(870, 64);
            this.labelSubtitulo.TabIndex = 1;
            this.labelSubtitulo.Text = "Sistema de Gestión de Prácticas";
            this.labelSubtitulo.Click += new System.EventHandler(this.labelSubtitulo_Click);
            // 
            // CimarronImagen
            // 
            this.CimarronImagen.Image = global::ProyectoTopicos.Properties.Resources.OIP;
            this.CimarronImagen.Location = new System.Drawing.Point(23, 12);
            this.CimarronImagen.Name = "CimarronImagen";
            this.CimarronImagen.Size = new System.Drawing.Size(133, 128);
            this.CimarronImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CimarronImagen.TabIndex = 2;
            this.CimarronImagen.TabStop = false;
            this.CimarronImagen.Click += new System.EventHandler(this.CimarronImagen_Click);
            // 
            // CimaImagen2
            // 
            this.CimaImagen2.Image = global::ProyectoTopicos.Properties.Resources.OIP;
            this.CimaImagen2.Location = new System.Drawing.Point(765, 12);
            this.CimaImagen2.Name = "CimaImagen2";
            this.CimaImagen2.Size = new System.Drawing.Size(133, 128);
            this.CimaImagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CimaImagen2.TabIndex = 3;
            this.CimaImagen2.TabStop = false;
            this.CimaImagen2.Click += new System.EventHandler(this.CimaImagen2_Click);
            // 
            // BotonCatalogoFacultades
            // 
            this.BotonCatalogoFacultades.BackColor = System.Drawing.Color.Green;
            this.BotonCatalogoFacultades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCatalogoFacultades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCatalogoFacultades.Location = new System.Drawing.Point(281, 246);
            this.BotonCatalogoFacultades.Name = "BotonCatalogoFacultades";
            this.BotonCatalogoFacultades.Size = new System.Drawing.Size(360, 78);
            this.BotonCatalogoFacultades.TabIndex = 4;
            this.BotonCatalogoFacultades.Text = "Catálogo de Facultades";
            this.BotonCatalogoFacultades.UseVisualStyleBackColor = false;
            this.BotonCatalogoFacultades.Click += new System.EventHandler(this.BotonCatalogoFacultades_Click);
            // 
            // BotonCatálogoPrácticas
            // 
            this.BotonCatálogoPrácticas.BackColor = System.Drawing.Color.Green;
            this.BotonCatálogoPrácticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCatálogoPrácticas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonCatálogoPrácticas.Location = new System.Drawing.Point(281, 455);
            this.BotonCatálogoPrácticas.Name = "BotonCatálogoPrácticas";
            this.BotonCatálogoPrácticas.Size = new System.Drawing.Size(360, 78);
            this.BotonCatálogoPrácticas.TabIndex = 5;
            this.BotonCatálogoPrácticas.Text = "Catálogo de Prácticas";
            this.BotonCatálogoPrácticas.UseVisualStyleBackColor = false;
            this.BotonCatálogoPrácticas.Click += new System.EventHandler(this.BotonCatálogoPrácticas_Click);
            // 
            // BotónCatálogoMaterias
            // 
            this.BotónCatálogoMaterias.BackColor = System.Drawing.Color.Green;
            this.BotónCatálogoMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónCatálogoMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotónCatálogoMaterias.Location = new System.Drawing.Point(281, 351);
            this.BotónCatálogoMaterias.Name = "BotónCatálogoMaterias";
            this.BotónCatálogoMaterias.Size = new System.Drawing.Size(360, 78);
            this.BotónCatálogoMaterias.TabIndex = 6;
            this.BotónCatálogoMaterias.Text = "Catálogo de Materias";
            this.BotónCatálogoMaterias.UseVisualStyleBackColor = false;
            this.BotónCatálogoMaterias.Click += new System.EventHandler(this.BotónCatálogoMaterias_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(910, 580);
            this.Controls.Add(this.BotónCatálogoMaterias);
            this.Controls.Add(this.BotonCatálogoPrácticas);
            this.Controls.Add(this.BotonCatalogoFacultades);
            this.Controls.Add(this.CimaImagen2);
            this.Controls.Add(this.CimarronImagen);
            this.Controls.Add(this.labelSubtitulo);
            this.Controls.Add(this.BIENVENIDO);
            this.Name = "PaginaPrincipal";
            this.Text = "PaginaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.CimarronImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CimaImagen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BIENVENIDO;
        private System.Windows.Forms.Label labelSubtitulo;
        private System.Windows.Forms.PictureBox CimarronImagen;
        private System.Windows.Forms.PictureBox CimaImagen2;
        private System.Windows.Forms.Button BotonCatalogoFacultades;
        private System.Windows.Forms.Button BotonCatálogoPrácticas;
        private System.Windows.Forms.Button BotónCatálogoMaterias;
    }
}