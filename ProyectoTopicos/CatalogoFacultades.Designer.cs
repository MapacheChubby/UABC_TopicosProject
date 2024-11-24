namespace ProyectoTopicos
{
    partial class CatalogoFacultades
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
            this.DataGrid_CatalogoFacultades = new System.Windows.Forms.DataGridView();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.TextBoxNombreFacultad = new System.Windows.Forms.TextBox();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CatalogoFacultades)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_CatalogoFacultades
            // 
            this.DataGrid_CatalogoFacultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_CatalogoFacultades.Location = new System.Drawing.Point(12, 12);
            this.DataGrid_CatalogoFacultades.Name = "DataGrid_CatalogoFacultades";
            this.DataGrid_CatalogoFacultades.RowHeadersWidth = 62;
            this.DataGrid_CatalogoFacultades.RowTemplate.Height = 28;
            this.DataGrid_CatalogoFacultades.Size = new System.Drawing.Size(811, 476);
            this.DataGrid_CatalogoFacultades.TabIndex = 0;
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Green;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonRegresar.Location = new System.Drawing.Point(12, 506);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(202, 44);
            this.BotonRegresar.TabIndex = 1;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Green;
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonAgregar.Location = new System.Drawing.Point(925, 288);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(202, 44);
            this.BotonAgregar.TabIndex = 2;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // TextBoxNombreFacultad
            // 
            this.TextBoxNombreFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNombreFacultad.Location = new System.Drawing.Point(853, 57);
            this.TextBoxNombreFacultad.Name = "TextBoxNombreFacultad";
            this.TextBoxNombreFacultad.Size = new System.Drawing.Size(343, 32);
            this.TextBoxNombreFacultad.TabIndex = 3;
            this.TextBoxNombreFacultad.Text = "Nombre Facultad";
            this.TextBoxNombreFacultad.TextChanged += new System.EventHandler(this.TextBoxNombreFacultad_TextChanged);
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUbicacion.Location = new System.Drawing.Point(853, 124);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(343, 32);
            this.textBoxUbicacion.TabIndex = 4;
            this.textBoxUbicacion.Text = "Ubicación";
            this.textBoxUbicacion.TextChanged += new System.EventHandler(this.textBoxUbicacion_TextChanged);
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContacto.Location = new System.Drawing.Point(853, 201);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(343, 32);
            this.textBoxContacto.TabIndex = 5;
            this.textBoxContacto.Text = "Telefono/Email";
            this.textBoxContacto.TextChanged += new System.EventHandler(this.textBoxContacto_TextChanged);
            // 
            // CatalogoFacultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1224, 611);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.TextBoxNombreFacultad);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.DataGrid_CatalogoFacultades);
            this.Name = "CatalogoFacultades";
            this.Text = "CatalogoFacultades";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_CatalogoFacultades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_CatalogoFacultades;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.TextBox TextBoxNombreFacultad;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.TextBox textBoxContacto;
    }
}