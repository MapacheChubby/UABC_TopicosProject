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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Negocio;
using TextBox = System.Windows.Forms.TextBox;




namespace ProyectoTopicos
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void ImagenCimarron1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            SetPlaceholder(textBox1, "Usuario");
            SetPlaceholder(textBox2, "Contraseña");
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
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void buttonInicioDeCesion_Click(object sender, EventArgs e)
        {
            enviar();
        }
        public void enviar()
        {

            {

                UniversidadService PS = new UniversidadService();


                string username = textBox1.Text;
                string password = textBox2.Text;

                bool isAuthenticated = PS.AutenticarUsuario(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    PaginaPrincipal View = new PaginaPrincipal();

                    View.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cierra toda la aplicación, terminando todos los procesos.
            Application.Exit();
        }
    }
}
