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
            CatalogoFacultades catalogoFacultades = new CatalogoFacultades();

            catalogoFacultades.Show();

            this.Hide();
        }

        private void BotónCatálogoMaterias_Click(object sender, EventArgs e)
        {
            CatalogoMaterias catalogoMaterias = new CatalogoMaterias();

            catalogoMaterias.Show();

            this.Hide();
        }

        private void BotonCatálogoPrácticas_Click(object sender, EventArgs e)
        {
            CatalogoPracticas catalogoPracticas = new CatalogoPracticas();

            catalogoPracticas.Show();

            this.Hide();
        }
    }
}
