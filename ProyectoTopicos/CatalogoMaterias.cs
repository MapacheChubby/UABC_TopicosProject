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
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace ProyectoTopicos
{
    public partial class CatalogoMaterias : Form
    {
        UniversidadService ps = new UniversidadService();


        public CatalogoMaterias()
        {
            InitializeComponent();
        }

        private void CatalogoMaterias_Load(object sender, EventArgs e)
        {

            recarga();
            SetPlaceholder(TextBoxNombreMateria, "Nombre Materia");
            SetPlaceholder(textBoxCodigo, "Codigo Materia");
            SetPlaceholder(textBoxSemestre, "Semestre");
            SetPlaceholder(textBoxID, "ID");
            
            LlenarComboBoxFacultades(comboBoxFacultades);

        }

        public void LlenarComboBoxFacultades(ComboBox comboBox)
        {
            // Crear una instancia del servicio
            UniversidadService facultadService = new UniversidadService();

            // Obtener las facultades desde el servicio
            DataTable facultades = facultadService.ObtenerFacultades();

            // Configurar el ComboBox con los datos obtenidos
            comboBox.DataSource = facultades;
            comboBox.DisplayMember = "Nombre";  // Nombre visible en el ComboBox
            comboBox.ValueMember = "ID_Facultad"; // Valor asociado a cada opción
        }


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
        private void dataGridMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxNombreMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSemestre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelRegistro_Click(object sender, EventArgs e)
        {

        }
        private void BtnEditarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores desde los controles de tu formulario (ejemplo: TextBox, ComboBox)
                int idMateria = int.Parse(textBoxID.Text); // TextBox para ID de materia
                int idFacultad = (int)comboBoxFacultades.SelectedValue; // ComboBox para facultades
                string nombre = TextBoxNombreMateria.Text; // TextBox para nombre de la materia
                string codigo = textBoxCodigo.Text; // TextBox para el código
                int semestre = int.Parse(textBoxSemestre.Text); // TextBox para el semestre

                // Llamar al método de servicio
                ps.EditarMateria(idMateria, idFacultad, nombre, codigo, semestre);

                MessageBox.Show("Materia actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar la materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            recarga();
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            btnGuardarMateria_Click();
            recarga();
        }

        private void BtnEliminarMateria_Click(object sender, EventArgs e)
        {
            try
            {
                int idMateria = int.Parse(textBoxID.Text); // TextBox para ID de materia

                ps.EliminarMateria(idMateria);
                recarga();
                MessageBox.Show("Materia eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            recarga();
        }

        private void btnGuardarMateria_Click()
        {
            try
            {
                int idFacultad = Convert.ToInt32(comboBoxFacultades.SelectedValue); // Obtiene el ID seleccionado
                string nombre = TextBoxNombreMateria.Text;
                string codigo = textBoxCodigo.Text;
                int semestre = Convert.ToInt32(textBoxSemestre.Text);

                ps.InsertarMateria(idFacultad, nombre, codigo, semestre);
                MessageBox.Show("Materia insertada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar materia: {ex.Message}");
            }
        }

        void recarga()
        {
            // Limpiar el DataSource anterior (si es necesario)
            dataGridMaterias.DataSource = null;
            dataGridMaterias.Rows.Clear();

            // Asignar el nuevo DataSource
            dataGridMaterias.DataSource = ps.MostrarMaterias();

            // Forzar la actualización visual del DataGrid
            dataGridMaterias.Refresh();
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipal View = new PaginaPrincipal();

            View.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void BotónAsignar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int idMateria = int.Parse(textBoxID.Text); // TextBox para ID de materia

                ps.EliminarMateria(idMateria);
                recarga();
                MessageBox.Show("Materia eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar la materia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            recarga();
        }
    }
}
