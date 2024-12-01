namespace ProyectoTopicos
{
    partial class CatalogoPracticas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCatalogoPracticas = new System.Windows.Forms.DataGridView();
            this.BotonRegresar = new System.Windows.Forms.Button();
            this.BotónAgregar = new System.Windows.Forms.Button();
            this.BotónEditar = new System.Windows.Forms.Button();
            this.BotónEliminar = new System.Windows.Forms.Button();
            this.FechaLimite = new System.Windows.Forms.DateTimePicker();
            this.FechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.LabelFechaEntrega = new System.Windows.Forms.Label();
            this.LabelFechaLimite = new System.Windows.Forms.Label();
            this.RichTextDescripciónPráctica = new System.Windows.Forms.RichTextBox();
            this.LabelDescripción = new System.Windows.Forms.Label();
            this.textBoxTituloPráctica = new System.Windows.Forms.TextBox();
            this.LabelTituloPráctica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbMateria = new System.Windows.Forms.ComboBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoPracticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCatalogoPracticas
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridCatalogoPracticas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCatalogoPracticas.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dataGridCatalogoPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogoPracticas.Location = new System.Drawing.Point(11, 10);
            this.dataGridCatalogoPracticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCatalogoPracticas.Name = "dataGridCatalogoPracticas";
            this.dataGridCatalogoPracticas.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridCatalogoPracticas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCatalogoPracticas.RowTemplate.Height = 28;
            this.dataGridCatalogoPracticas.Size = new System.Drawing.Size(724, 447);
            this.dataGridCatalogoPracticas.TabIndex = 0;
            this.dataGridCatalogoPracticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCatalogoPracticas_CellContentClick);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Green;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.Location = new System.Drawing.Point(12, 461);
            this.BotonRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(143, 36);
            this.BotonRegresar.TabIndex = 1;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // BotónAgregar
            // 
            this.BotónAgregar.BackColor = System.Drawing.Color.Lime;
            this.BotónAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónAgregar.Location = new System.Drawing.Point(773, 461);
            this.BotónAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotónAgregar.Name = "BotónAgregar";
            this.BotónAgregar.Size = new System.Drawing.Size(290, 36);
            this.BotónAgregar.TabIndex = 2;
            this.BotónAgregar.Text = "Agregar";
            this.BotónAgregar.UseVisualStyleBackColor = false;
            this.BotónAgregar.Click += new System.EventHandler(this.BotónAgregar_Click);
            // 
            // BotónEditar
            // 
            this.BotónEditar.BackColor = System.Drawing.Color.Orange;
            this.BotónEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónEditar.Location = new System.Drawing.Point(385, 470);
            this.BotónEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotónEditar.Name = "BotónEditar";
            this.BotónEditar.Size = new System.Drawing.Size(143, 36);
            this.BotónEditar.TabIndex = 3;
            this.BotónEditar.Text = "Editar";
            this.BotónEditar.UseVisualStyleBackColor = false;
            this.BotónEditar.Click += new System.EventHandler(this.BotónEditar_Click);
            // 
            // BotónEliminar
            // 
            this.BotónEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BotónEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónEliminar.Location = new System.Drawing.Point(534, 470);
            this.BotónEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotónEliminar.Name = "BotónEliminar";
            this.BotónEliminar.Size = new System.Drawing.Size(143, 36);
            this.BotónEliminar.TabIndex = 4;
            this.BotónEliminar.Text = "Eliminar";
            this.BotónEliminar.UseVisualStyleBackColor = false;
            this.BotónEliminar.Click += new System.EventHandler(this.BotónEliminar_Click);
            // 
            // FechaLimite
            // 
            this.FechaLimite.Location = new System.Drawing.Point(775, 355);
            this.FechaLimite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.Size = new System.Drawing.Size(288, 22);
            this.FechaLimite.TabIndex = 5;
            this.FechaLimite.ValueChanged += new System.EventHandler(this.FechaLimite_ValueChanged);
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Location = new System.Drawing.Point(775, 298);
            this.FechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Size = new System.Drawing.Size(288, 22);
            this.FechaEntrega.TabIndex = 6;
            this.FechaEntrega.ValueChanged += new System.EventHandler(this.FechaEntrega_ValueChanged);
            // 
            // LabelFechaEntrega
            // 
            this.LabelFechaEntrega.AutoSize = true;
            this.LabelFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaEntrega.ForeColor = System.Drawing.Color.Gold;
            this.LabelFechaEntrega.Location = new System.Drawing.Point(771, 276);
            this.LabelFechaEntrega.Name = "LabelFechaEntrega";
            this.LabelFechaEntrega.Size = new System.Drawing.Size(161, 20);
            this.LabelFechaEntrega.TabIndex = 7;
            this.LabelFechaEntrega.Text = "Fecha de entrega ";
            this.LabelFechaEntrega.Click += new System.EventHandler(this.LabelFechaEntrega_Click);
            // 
            // LabelFechaLimite
            // 
            this.LabelFechaLimite.AutoSize = true;
            this.LabelFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaLimite.ForeColor = System.Drawing.Color.Gold;
            this.LabelFechaLimite.Location = new System.Drawing.Point(771, 333);
            this.LabelFechaLimite.Name = "LabelFechaLimite";
            this.LabelFechaLimite.Size = new System.Drawing.Size(213, 20);
            this.LabelFechaLimite.TabIndex = 8;
            this.LabelFechaLimite.Text = "Fecha limite de entrega ";
            this.LabelFechaLimite.Click += new System.EventHandler(this.LabelFechaLimite_Click);
            // 
            // RichTextDescripciónPráctica
            // 
            this.RichTextDescripciónPráctica.Location = new System.Drawing.Point(775, 170);
            this.RichTextDescripciónPráctica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RichTextDescripciónPráctica.Name = "RichTextDescripciónPráctica";
            this.RichTextDescripciónPráctica.Size = new System.Drawing.Size(288, 91);
            this.RichTextDescripciónPráctica.TabIndex = 9;
            this.RichTextDescripciónPráctica.Text = "";
            this.RichTextDescripciónPráctica.TextChanged += new System.EventHandler(this.RichTextDescripciónPráctica_TextChanged);
            // 
            // LabelDescripción
            // 
            this.LabelDescripción.AutoSize = true;
            this.LabelDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripción.ForeColor = System.Drawing.Color.Gold;
            this.LabelDescripción.Location = new System.Drawing.Point(771, 148);
            this.LabelDescripción.Name = "LabelDescripción";
            this.LabelDescripción.Size = new System.Drawing.Size(231, 20);
            this.LabelDescripción.TabIndex = 10;
            this.LabelDescripción.Text = "Descripción de la práctica";
            this.LabelDescripción.Click += new System.EventHandler(this.LabelDescripción_Click);
            // 
            // textBoxTituloPráctica
            // 
            this.textBoxTituloPráctica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloPráctica.Location = new System.Drawing.Point(775, 58);
            this.textBoxTituloPráctica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTituloPráctica.Name = "textBoxTituloPráctica";
            this.textBoxTituloPráctica.Size = new System.Drawing.Size(288, 26);
            this.textBoxTituloPráctica.TabIndex = 11;
            this.textBoxTituloPráctica.TextChanged += new System.EventHandler(this.textBoxTituloPráctica_TextChanged);
            // 
            // LabelTituloPráctica
            // 
            this.LabelTituloPráctica.AutoSize = true;
            this.LabelTituloPráctica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloPráctica.ForeColor = System.Drawing.Color.Gold;
            this.LabelTituloPráctica.Location = new System.Drawing.Point(771, 36);
            this.LabelTituloPráctica.Name = "LabelTituloPráctica";
            this.LabelTituloPráctica.Size = new System.Drawing.Size(179, 20);
            this.LabelTituloPráctica.TabIndex = 12;
            this.LabelTituloPráctica.Text = "Titulo de la Práctica";
            this.LabelTituloPráctica.Click += new System.EventHandler(this.LabelTituloPráctica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(771, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione materia";
            // 
            // CbMateria
            // 
            this.CbMateria.FormattingEnabled = true;
            this.CbMateria.Location = new System.Drawing.Point(775, 110);
            this.CbMateria.Name = "CbMateria";
            this.CbMateria.Size = new System.Drawing.Size(288, 24);
            this.CbMateria.TabIndex = 14;
            this.CbMateria.SelectedIndexChanged += new System.EventHandler(this.CbMateria_SelectedIndexChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(683, 472);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(52, 34);
            this.textBoxID.TabIndex = 15;
            // 
            // CatalogoPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1092, 518);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.CbMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelTituloPráctica);
            this.Controls.Add(this.textBoxTituloPráctica);
            this.Controls.Add(this.LabelDescripción);
            this.Controls.Add(this.RichTextDescripciónPráctica);
            this.Controls.Add(this.LabelFechaLimite);
            this.Controls.Add(this.LabelFechaEntrega);
            this.Controls.Add(this.FechaEntrega);
            this.Controls.Add(this.FechaLimite);
            this.Controls.Add(this.BotónEliminar);
            this.Controls.Add(this.BotónEditar);
            this.Controls.Add(this.BotónAgregar);
            this.Controls.Add(this.BotonRegresar);
            this.Controls.Add(this.dataGridCatalogoPracticas);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogoPracticas";
            this.Text = "Catálogo de Prácticas";
            this.Load += new System.EventHandler(this.CatalogoPracticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoPracticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCatalogoPracticas;
        private System.Windows.Forms.Button BotonRegresar;
        private System.Windows.Forms.Button BotónAgregar;
        private System.Windows.Forms.Button BotónEditar;
        private System.Windows.Forms.Button BotónEliminar;
        private System.Windows.Forms.DateTimePicker FechaLimite;
        private System.Windows.Forms.DateTimePicker FechaEntrega;
        private System.Windows.Forms.Label LabelFechaEntrega;
        private System.Windows.Forms.Label LabelFechaLimite;
        private System.Windows.Forms.RichTextBox RichTextDescripciónPráctica;
        private System.Windows.Forms.Label LabelDescripción;
        private System.Windows.Forms.TextBox textBoxTituloPráctica;
        private System.Windows.Forms.Label LabelTituloPráctica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbMateria;
        private System.Windows.Forms.TextBox textBoxID;
    }
}