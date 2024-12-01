using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

using TextBox = System.Windows.Forms.TextBox;

namespace ProyectoTopicos
{
    public partial class CatalogoFacultades : Form
    {

        UniversidadService ps = new UniversidadService();
        public CatalogoFacultades()
        {
            InitializeComponent();
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipal View = new PaginaPrincipal();

            View.Show();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            String Facultad = TextBoxNombreFacultad.Text;
            String Ubicacion = textBoxUbicacion.Text;
           
          
       

            // Llamar al método para insertar el producto
          ps.InsertarFacultad(Facultad, Ubicacion);
            recarga();
        }

        private void TextBoxNombreFacultad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void CatalogoFacultades_Load(object sender, EventArgs e)
        {
            recarga();
            SetPlaceholder(TextBoxNombreFacultad, "Facultad");
            SetPlaceholder(textBoxUbicacion, "Ubicacion");
        }
        // Método para definir el placeholder
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
        private void DataGrid_CatalogoFacultades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void recarga()
        {
            // Limpiar el DataSource anterior (si es necesario)
            DataGrid_CatalogoFacultades.DataSource = null;
            DataGrid_CatalogoFacultades.Rows.Clear();

            // Asignar el nuevo DataSource
            DataGrid_CatalogoFacultades.DataSource = ps.MostrarFacultades();

            // Forzar la actualización visual del DataGrid
            DataGrid_CatalogoFacultades.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int ID;
            if (!int.TryParse(TB_ID.Text, out ID))
            {
                MessageBox.Show("Por favor ingrese un número válido para el stock.");
                return;
            }

            ps.EliminarFacultad(ID);
            recarga();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int ID;
            if (!int.TryParse(TB_ID2.Text, out ID))
            {
                MessageBox.Show("Por favor ingrese un número válido para el stock.");
                return;
            }
            String Facultad = TextBoxNombreFacultad.Text;
            String Ubicacion = textBoxUbicacion.Text;
           

            ps.EditarFacultad(ID,Facultad,Ubicacion);
            recarga();
        }

        private void CatalogoFacultades_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra toda la aplicación, terminando todos los procesos.
            Application.Exit();
        }
    }
}
