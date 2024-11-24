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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCatalogoPracticas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCatalogoPracticas
            // 
            this.dataGridCatalogoPracticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCatalogoPracticas.Location = new System.Drawing.Point(12, 12);
            this.dataGridCatalogoPracticas.Name = "dataGridCatalogoPracticas";
            this.dataGridCatalogoPracticas.RowHeadersWidth = 62;
            this.dataGridCatalogoPracticas.RowTemplate.Height = 28;
            this.dataGridCatalogoPracticas.Size = new System.Drawing.Size(814, 488);
            this.dataGridCatalogoPracticas.TabIndex = 0;
            this.dataGridCatalogoPracticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCatalogoPracticas_CellContentClick);
            // 
            // BotonRegresar
            // 
            this.BotonRegresar.BackColor = System.Drawing.Color.Green;
            this.BotonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRegresar.Location = new System.Drawing.Point(12, 526);
            this.BotonRegresar.Name = "BotonRegresar";
            this.BotonRegresar.Size = new System.Drawing.Size(161, 45);
            this.BotonRegresar.TabIndex = 1;
            this.BotonRegresar.Text = "Regresar";
            this.BotonRegresar.UseVisualStyleBackColor = false;
            this.BotonRegresar.Click += new System.EventHandler(this.BotonRegresar_Click);
            // 
            // BotónAgregar
            // 
            this.BotónAgregar.BackColor = System.Drawing.Color.Green;
            this.BotónAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónAgregar.Location = new System.Drawing.Point(960, 436);
            this.BotónAgregar.Name = "BotónAgregar";
            this.BotónAgregar.Size = new System.Drawing.Size(161, 45);
            this.BotónAgregar.TabIndex = 2;
            this.BotónAgregar.Text = "Agregar";
            this.BotónAgregar.UseVisualStyleBackColor = false;
            this.BotónAgregar.Click += new System.EventHandler(this.BotónAgregar_Click);
            // 
            // BotónEditar
            // 
            this.BotónEditar.BackColor = System.Drawing.Color.Green;
            this.BotónEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónEditar.Location = new System.Drawing.Point(489, 526);
            this.BotónEditar.Name = "BotónEditar";
            this.BotónEditar.Size = new System.Drawing.Size(161, 45);
            this.BotónEditar.TabIndex = 3;
            this.BotónEditar.Text = "Editar";
            this.BotónEditar.UseVisualStyleBackColor = false;
            this.BotónEditar.Click += new System.EventHandler(this.BotónEditar_Click);
            // 
            // BotónEliminar
            // 
            this.BotónEliminar.BackColor = System.Drawing.Color.Green;
            this.BotónEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotónEliminar.Location = new System.Drawing.Point(665, 526);
            this.BotónEliminar.Name = "BotónEliminar";
            this.BotónEliminar.Size = new System.Drawing.Size(161, 45);
            this.BotónEliminar.TabIndex = 4;
            this.BotónEliminar.Text = "Eliminar";
            this.BotónEliminar.UseVisualStyleBackColor = false;
            this.BotónEliminar.Click += new System.EventHandler(this.BotónEliminar_Click);
            // 
            // FechaLimite
            // 
            this.FechaLimite.Location = new System.Drawing.Point(872, 389);
            this.FechaLimite.Name = "FechaLimite";
            this.FechaLimite.Size = new System.Drawing.Size(323, 26);
            this.FechaLimite.TabIndex = 5;
            this.FechaLimite.ValueChanged += new System.EventHandler(this.FechaLimite_ValueChanged);
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.Location = new System.Drawing.Point(872, 318);
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.Size = new System.Drawing.Size(323, 26);
            this.FechaEntrega.TabIndex = 6;
            this.FechaEntrega.ValueChanged += new System.EventHandler(this.FechaEntrega_ValueChanged);
            // 
            // LabelFechaEntrega
            // 
            this.LabelFechaEntrega.AutoSize = true;
            this.LabelFechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaEntrega.ForeColor = System.Drawing.Color.Gold;
            this.LabelFechaEntrega.Location = new System.Drawing.Point(867, 290);
            this.LabelFechaEntrega.Name = "LabelFechaEntrega";
            this.LabelFechaEntrega.Size = new System.Drawing.Size(187, 25);
            this.LabelFechaEntrega.TabIndex = 7;
            this.LabelFechaEntrega.Text = "Fecha de entrega ";
            this.LabelFechaEntrega.Click += new System.EventHandler(this.LabelFechaEntrega_Click);
            // 
            // LabelFechaLimite
            // 
            this.LabelFechaLimite.AutoSize = true;
            this.LabelFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFechaLimite.ForeColor = System.Drawing.Color.Gold;
            this.LabelFechaLimite.Location = new System.Drawing.Point(867, 361);
            this.LabelFechaLimite.Name = "LabelFechaLimite";
            this.LabelFechaLimite.Size = new System.Drawing.Size(243, 25);
            this.LabelFechaLimite.TabIndex = 8;
            this.LabelFechaLimite.Text = "Fecha limite de entrega ";
            this.LabelFechaLimite.Click += new System.EventHandler(this.LabelFechaLimite_Click);
            // 
            // RichTextDescripciónPráctica
            // 
            this.RichTextDescripciónPráctica.Location = new System.Drawing.Point(872, 158);
            this.RichTextDescripciónPráctica.Name = "RichTextDescripciónPráctica";
            this.RichTextDescripciónPráctica.Size = new System.Drawing.Size(323, 113);
            this.RichTextDescripciónPráctica.TabIndex = 9;
            this.RichTextDescripciónPráctica.Text = "";
            this.RichTextDescripciónPráctica.TextChanged += new System.EventHandler(this.RichTextDescripciónPráctica_TextChanged);
            // 
            // LabelDescripción
            // 
            this.LabelDescripción.AutoSize = true;
            this.LabelDescripción.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescripción.ForeColor = System.Drawing.Color.Gold;
            this.LabelDescripción.Location = new System.Drawing.Point(867, 130);
            this.LabelDescripción.Name = "LabelDescripción";
            this.LabelDescripción.Size = new System.Drawing.Size(260, 25);
            this.LabelDescripción.TabIndex = 10;
            this.LabelDescripción.Text = "Descripción de la práctica";
            this.LabelDescripción.Click += new System.EventHandler(this.LabelDescripción_Click);
            // 
            // textBoxTituloPráctica
            // 
            this.textBoxTituloPráctica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloPráctica.Location = new System.Drawing.Point(872, 73);
            this.textBoxTituloPráctica.Name = "textBoxTituloPráctica";
            this.textBoxTituloPráctica.Size = new System.Drawing.Size(323, 30);
            this.textBoxTituloPráctica.TabIndex = 11;
            this.textBoxTituloPráctica.TextChanged += new System.EventHandler(this.textBoxTituloPráctica_TextChanged);
            // 
            // LabelTituloPráctica
            // 
            this.LabelTituloPráctica.AutoSize = true;
            this.LabelTituloPráctica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTituloPráctica.ForeColor = System.Drawing.Color.Gold;
            this.LabelTituloPráctica.Location = new System.Drawing.Point(867, 45);
            this.LabelTituloPráctica.Name = "LabelTituloPráctica";
            this.LabelTituloPráctica.Size = new System.Drawing.Size(203, 25);
            this.LabelTituloPráctica.TabIndex = 12;
            this.LabelTituloPráctica.Text = "Titulo de la Práctica";
            this.LabelTituloPráctica.Click += new System.EventHandler(this.LabelTituloPráctica_Click);
            // 
            // CatalogoPracticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1228, 647);
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
            this.Name = "CatalogoPracticas";
            this.Text = "Catálogo de Prácticas";
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
    }
}