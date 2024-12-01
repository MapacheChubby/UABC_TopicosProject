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
            this.textBoxSemestre = new System.Windows.Forms.TextBox();
            this.dataGridMaterias = new System.Windows.Forms.DataGridView();
            this.LabelRegistro = new System.Windows.Forms.Label();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFacultades = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnEliminarMateria = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxNombreMateria
            // 
            this.TextBoxNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNombreMateria.Location = new System.Drawing.Point(858, 92);
            this.TextBoxNombreMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNombreMateria.Name = "TextBoxNombreMateria";
            this.TextBoxNombreMateria.Size = new System.Drawing.Size(305, 28);
            this.TextBoxNombreMateria.TabIndex = 4;
            this.TextBoxNombreMateria.Text = "Nombre Materia";
            this.TextBoxNombreMateria.TextChanged += new System.EventHandler(this.TextBoxNombreMateria_TextChanged);
            // 
            // textBoxSemestre
            // 
            this.textBoxSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSemestre.Location = new System.Drawing.Point(858, 199);
            this.textBoxSemestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSemestre.Name = "textBoxSemestre";
            this.textBoxSemestre.Size = new System.Drawing.Size(305, 28);
            this.textBoxSemestre.TabIndex = 6;
            this.textBoxSemestre.Text = "Semestre";
            this.textBoxSemestre.TextChanged += new System.EventHandler(this.textBoxSemestre_TextChanged);
            // 
            // dataGridMaterias
            // 
            this.dataGridMaterias.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dataGridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMaterias.Location = new System.Drawing.Point(12, 67);
            this.dataGridMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMaterias.Name = "dataGridMaterias";
            this.dataGridMaterias.RowHeadersWidth = 62;
            this.dataGridMaterias.RowTemplate.Height = 28;
            this.dataGridMaterias.Size = new System.Drawing.Size(829, 377);
            this.dataGridMaterias.TabIndex = 7;
            this.dataGridMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMaterias_CellContentClick);
            // 
            // LabelRegistro
            // 
            this.LabelRegistro.AutoSize = true;
            this.LabelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegistro.ForeColor = System.Drawing.Color.Gold;
            this.LabelRegistro.Location = new System.Drawing.Point(854, 70);
            this.LabelRegistro.Name = "LabelRegistro";
            this.LabelRegistro.Size = new System.Drawing.Size(175, 20);
            this.LabelRegistro.TabIndex = 13;
            this.LabelRegistro.Text = "Registro de Materia";
            this.LabelRegistro.Click += new System.EventHandler(this.LabelRegistro_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.Green;
            this.BotonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonAgregar.Location = new System.Drawing.Point(858, 292);
            this.BotonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(305, 52);
            this.BotonAgregar.TabIndex = 14;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.YellowGreen;
            this.BotonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BotonRegresar.Location = new System.Drawing.Point(12, 466);
            this.BotonRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(180, 52);
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
            this.label1.Location = new System.Drawing.Point(854, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Asignar Semestre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxFacultades
            // 
            this.comboBoxFacultades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFacultades.FormattingEnabled = true;
            this.comboBoxFacultades.Location = new System.Drawing.Point(858, 254);
            this.comboBoxFacultades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFacultades.Name = "comboBoxFacultades";
            this.comboBoxFacultades.Size = new System.Drawing.Size(305, 28);
            this.comboBoxFacultades.TabIndex = 17;
            this.comboBoxFacultades.Text = "Facultades";
            this.comboBoxFacultades.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacultades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(854, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Asignación de Facultades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 58);
            this.label4.TabIndex = 21;
            this.label4.Text = "Catalogo De Materias";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(858, 147);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(305, 28);
            this.textBoxCodigo.TabIndex = 4;
            this.textBoxCodigo.Text = "Nombre Materia";
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.TextBoxNombreMateria_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(854, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Asignar Codigo Materia";
            this.label3.Click += new System.EventHandler(this.LabelRegistro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orange;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(858, 422);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 52);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditarMateria_Click);
            // 
            // BtnEliminarMateria
            // 
            this.BtnEliminarMateria.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarMateria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarMateria.Location = new System.Drawing.Point(1018, 422);
            this.BtnEliminarMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarMateria.Name = "BtnEliminarMateria";
            this.BtnEliminarMateria.Size = new System.Drawing.Size(145, 52);
            this.BtnEliminarMateria.TabIndex = 14;
            this.BtnEliminarMateria.Text = "Eliminar";
            this.BtnEliminarMateria.UseVisualStyleBackColor = false;
            this.BtnEliminarMateria.Click += new System.EventHandler(this.BtnEliminarMateria_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(858, 367);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(107, 41);
            this.textBoxID.TabIndex = 22;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Location = new System.Drawing.Point(1018, 494);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(145, 46);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "button1";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatalogoMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1202, 552);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFacultades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.BtnEliminarMateria);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelRegistro);
            this.Controls.Add(this.dataGridMaterias);
            this.Controls.Add(this.textBoxSemestre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.TextBoxNombreMateria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogoMaterias";
            this.Text = "Catalogo Materias";
            this.Load += new System.EventHandler(this.CatalogoMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNombreMateria;
        private System.Windows.Forms.TextBox textBoxSemestre;
        private System.Windows.Forms.DataGridView dataGridMaterias;
        private System.Windows.Forms.Label LabelRegistro;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFacultades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnEliminarMateria;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button BtnEliminar;
    }
}