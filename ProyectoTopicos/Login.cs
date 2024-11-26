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
    public partial class Login : Form
    {
        private System.Windows.Forms.TextBox txt_Contraseña;
        public Login()
        {
            InitializeComponent();
            txt_Contraseña = new System.Windows.Forms.TextBox();
            txt_Contraseña.UseSystemPasswordChar = true;
        }

        private void ImagenCimarron1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void LabelContraseña_Click(object sender, EventArgs e)
        {

        }

        private void ImagenCimarron2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDeContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarContraseña.Checked)
            {
                textBoxDeContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxDeContraseña.UseSystemPasswordChar = true;
            }
        }

        private void buttonInicioDeCesion_Click(object sender, EventArgs e)
        {
            string validUsername = "uabc";
            string validPassword = "uabc1952";

            if (TextBoxDeUsuario.Text == validUsername && textBoxDeContraseña.Text == validPassword)
            {
                PaginaPrincipal contenido = new PaginaPrincipal();

                contenido.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, por favor inténtalo de nuevo.");
            }
        }
    }
}
