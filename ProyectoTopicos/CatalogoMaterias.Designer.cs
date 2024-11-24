namespace ProyectoTopicos
{
    partial class CatalogoMaterias
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
            this.TextBoxNombreMateria = new System.Windows.Forms.TextBox();
            this.textBoxCodigoMateria = new System.Windows.Forms.TextBox();
            this.textBoxSemestre = new System.Windows.Forms.TextBox();
            this.dataGridMaterias = new System.Windows.Forms.DataGridView();
            this.LabelRegistro = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFacultades = new System.Windows.Forms.ComboBox();
            this.BotónAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxNombreMateria
            // 
            this.TextBoxNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNombreMateria.Location = new System.Drawing.Point(972, 92);
            this.TextBoxNombreMateria.Name = "TextBoxNombreMateria";
            this.TextBoxNombreMateria.Size = new System.Drawing.Size(343, 32);
            this.TextBoxNombreMateria.TabIndex = 4;
            this.TextBoxNombreMateria.Text = "Nombre Materia";
            this.TextBoxNombreMateria.TextChanged += new System.EventHandler(this.TextBoxNombreMateria_TextChanged);
            // 
            // textBoxCodigoMateria
            // 
            this.textBoxCodigoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoMateria.Location = new System.Drawing.Point(972, 167);
            this.textBoxCodigoMateria.Name = "textBoxCodigoMateria";
            this.textBoxCodigoMateria.Size = new System.Drawing.Size(343, 32);
            this.textBoxCodigoMateria.TabIndex = 5;
            this.textBoxCodigoMateria.Text = " Código Materia";
            this.textBoxCodigoMateria.TextChanged += new System.EventHandler(this.textBoxCodigoMateria_TextChanged);
            // 
            // textBoxSemestre
            // 
            this.textBoxSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemestre.Location = new System.Drawing.Point(972, 236);
            this.textBoxSemestre.Name = "textBoxSemestre";
            this.textBoxSemestre.Size = new System.Drawing.Size(343, 32);
            this.textBoxSemestre.TabIndex = 6;
            this.textBoxSemestre.Text = "Semestre";
            this.textBoxSemestre.TextChanged += new System.EventHandler(this.textBoxSemestre_TextChanged);
            // 
            // dataGridMaterias
            // 
            this.dataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterias.Location = new System.Drawing.Point(12, 12);
            this.dataGridMaterias.Name = "dataGridMaterias";
            this.dataGridMaterias.RowHeadersWidth = 62;
            this.dataGridMaterias.RowTemplate.Height = 28;
            this.dataGridMaterias.Size = new System.Drawing.Size(933, 385);
            this.dataGridMaterias.TabIndex = 7;
            this.dataGridMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaterias_CellContentClick);
            // 
            // LabelRegistro
            // 
            this.LabelRegistro.AutoSize = true;
            this.LabelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistro.ForeColor = System.Drawing.Color.Gold;
            this.LabelRegistro.Location = new System.Drawing.Point(1048, 40);
            this.LabelRegistro.Name = "LabelRegistro";
            this.LabelRegistro.Size = new System.Drawing.Size(199, 25);
            this.LabelRegistro.TabIndex = 13;
            this.LabelRegistro.Text = "Registro de Materia";
            this.LabelRegistro.Click += new System.EventHandler(this.LabelRegistro_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Green;
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonAgregar.Location = new System.Drawing.Point(1045, 308);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(202, 44);
            this.BotonAgregar.TabIndex = 14;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Green;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonRegresar.Location = new System.Drawing.Point(12, 583);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(202, 44);
            this.BotonRegresar.TabIndex = 15;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(614, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Asignación de Facultades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxFacultades
            // 
            this.comboBoxFacultades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultades.FormattingEnabled = true;
            this.comboBoxFacultades.Location = new System.Drawing.Point(573, 482);
            this.comboBoxFacultades.Name = "comboBoxFacultades";
            this.comboBoxFacultades.Size = new System.Drawing.Size(332, 33);
            this.comboBoxFacultades.TabIndex = 17;
            this.comboBoxFacultades.Text = "Facultades";
            this.comboBoxFacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultades_SelectedIndexChanged);
            // 
            // BotónAsignar
            // 
            this.BotónAsignar.BackColor = System.Drawing.Color.Green;
            this.BotónAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónAsignar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotónAsignar.Location = new System.Drawing.Point(644, 539);
            this.BotónAsignar.Name = "BotónAsignar";
            this.BotónAsignar.Size = new System.Drawing.Size(202, 44);
            this.BotónAsignar.TabIndex = 18;
            this.BotónAsignar.Text = "Asignar";
            this.BotónAsignar.UseVisualStyleBackColor = false;
            this.BotónAsignar.Click += new System.EventHandler(this.BotónAsignar_Click);
            // 
            // CatalogoMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1345, 651);
            this.Controls.Add(this.BotónAsignar);
            this.Controls.Add(this.comboBoxFacultades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.LabelRegistro);
            this.Controls.Add(this.dataGridMaterias);
            this.Controls.Add(this.textBoxSemestre);
            this.Controls.Add(this.textBoxCodigoMateria);
            this.Controls.Add(this.TextBoxNombreMateria);
            this.Name = "CatalogoMaterias";
            this.Text = "CatalogoMaterias";
            this.Load += new System.EventHandler(this.CatalogoMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNombreMateria;
        private System.Windows.Forms.TextBox textBoxCodigoMateria;
        private System.Windows.Forms.TextBox textBoxSemestre;
        private System.Windows.Forms.DataGridView dataGridMaterias;
        private System.Windows.Forms.Label LabelRegistro;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFacultades;
        private System.Windows.Forms.Button BotónAsignar;
    }
}