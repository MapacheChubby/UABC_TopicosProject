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

namespace ProyectoTopicos
{
    public partial class CatalogoPracticas : Form
    {

        UniversidadService ps = new UniversidadService();
        public CatalogoPracticas()
        {
            InitializeComponent();
            CargarMaterias();
         
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


        private void CargarMaterias()
        {
            try
            {
                DataTable materias = ps.ObtenerMaterias();

                // Agregar fila para "Seleccionar materia"
                DataRow nuevaFila = materias.NewRow();
                nuevaFila["ID_Materia"] = 0; // Un valor no existente en la base de datos
                nuevaFila["Nombre"] = "Seleccionar materia";
                materias.Rows.InsertAt(nuevaFila, 0); // Agregar al inicio del DataTable

                // Asignar el DataTable al ComboBox
                CbMateria.DataSource = materias;
                CbMateria.DisplayMember = "Nombre";
                CbMateria.ValueMember = "ID_Materia";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar materias: " + ex.Message);
            }
        }


        private void BotónAgregar_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    // Capturar datos de los componentes
                    string titulo = textBoxTituloPráctica.Text.Trim();
                    string descripcion = RichTextDescripciónPráctica.Text.Trim();
                    DateTime fechaAsignacion = FechaEntrega.Value;
                    DateTime fechaLimite = FechaLimite.Value;
                    int idMateria = (int)CbMateria.SelectedValue; // Obtener el ID_Materia seleccionado

                    // Validar que los campos no estén vacíos
                    if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descripcion))
                    {
                        MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que se haya seleccionado una materia válida
                    if (idMateria == 0)
                    {
                        MessageBox.Show("Por favor, seleccione una materia válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que la fecha límite sea posterior a la fecha de asignación
                    if (fechaLimite <= fechaAsignacion)
                    {
                        MessageBox.Show("La fecha límite debe ser posterior a la fecha de asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Llamar al servicio para insertar los datos
                    ps.InsertarPractica(0, idMateria, titulo, descripcion, fechaAsignacion, fechaLimite);

                    MessageBox.Show("Práctica insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar los campos
                    textBoxTituloPráctica.Clear();
                    RichTextDescripciónPráctica.Clear();
                    FechaEntrega.Value = DateTime.Now;
                    FechaLimite.Value = DateTime.Now;
                    CbMateria.SelectedIndex = 0; // Volver al texto predeterminado "Seleccionar materia"
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar la práctica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                recarga();
            }


        }

        private void BotónEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los datos de los campos
                int idPractica =int.Parse(textBoxID.Text);  // O ajustar según tu diseño
                int idMateria = Convert.ToInt32(CbMateria.SelectedValue);  // Selección de materia desde ComboBox
                string titulo = textBoxTituloPráctica.Text.Trim();
                string descripcion = RichTextDescripciónPráctica.Text.Trim();
                DateTime fechaAsignacion = FechaEntrega.Value;
                DateTime fechaLimite = FechaLimite.Value;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descripcion))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que la fecha límite sea posterior a la fecha de asignación
                if (fechaLimite <= fechaAsignacion)
                {
                    MessageBox.Show("La fecha límite debe ser posterior a la fecha de asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al servicio para modificar la práctica
                ps.ModificarPractica(idPractica, idMateria, titulo, descripcion, fechaAsignacion, fechaLimite);

                // Actualizar la interfaz o lista de prácticas después de la modificación
                recarga();  // Método que recarga las prácticas

                MessageBox.Show("Práctica modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la práctica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotónEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar el ID de la práctica seleccionada (aquí asumimos que el ComboBox tiene las prácticas cargadas)
                int idPractica = int.Parse(textBoxID.Text);   // O ajusta según tu diseño

                // Validar que se haya seleccionado una práctica
                if (idPractica == 0)
                {
                    MessageBox.Show("Por favor, seleccione una práctica para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al servicio para eliminar la práctica
                ps.EliminarPractica(idPractica);

                // Actualizar la interfaz o lista de prácticas después de la eliminación
                recarga();  // Método que recarga las prácticas

                MessageBox.Show("Práctica eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la práctica: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaginaPrincipal View = new PaginaPrincipal();

            View.Show();
        }

        private void FechaEntrega_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelFechaEntrega_Click(object sender, EventArgs e)
        {

        }

        private void LabelFechaLimite_Click(object sender, EventArgs e)
        {

        }

        private void RichTextDescripciónPráctica_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelDescripción_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTituloPráctica_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelTituloPráctica_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCatalogoPracticas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatalogoPracticas_Load(object sender, EventArgs e)
        {
            recarga();
            SetPlaceholder(textBoxTituloPráctica,"Titulo");
           
        }

        void recarga()
        {
            // Limpiar el DataSource anterior (si es necesario)
            dataGridCatalogoPracticas.DataSource = null;
            dataGridCatalogoPracticas.Rows.Clear();

            // Asignar el nuevo DataSource
            dataGridCatalogoPracticas.DataSource = ps.MostrarPracticas();

            // Forzar la actualización visual del DataGrid
            dataGridCatalogoPracticas.Refresh();
        }

        private void CbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
