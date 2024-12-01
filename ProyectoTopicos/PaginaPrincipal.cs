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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void BIENVENIDO_Click(object sender, EventArgs e)
        {

        }

        private void labelSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void CimarronImagen_Click(object sender, EventArgs e)
        {

        }

        private void CimaImagen2_Click(object sender, EventArgs e)
        {

        }

        private void BotonCatalogoFacultades_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogoFacultades View = new CatalogoFacultades();

            View.Show();
        }

        private void BotónCatálogoMaterias_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogoMaterias View = new CatalogoMaterias();

            View.Show();
        }

        private void BotonCatálogoPrácticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            CatalogoPracticas View = new CatalogoPracticas();

            View.Show();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra toda la aplicación, terminando todos los procesos.
            Application.Exit();
        }
    }
}
