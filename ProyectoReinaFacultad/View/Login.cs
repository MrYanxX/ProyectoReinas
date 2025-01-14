using Controller;
using Model.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using View;

namespace Vista
{
    public partial class Login : Form
    {
        private CtrUsuario sesion = new CtrUsuario();
        Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
            btnIngresar.Enabled = false; // Deshabilitar el botón al inicio

            txtUsuario.TextChanged += new EventHandler(txtUsuario_TextChanged);
            txtContraseña.TextChanged += new EventHandler(txtContraseña_TextChanged);

            // Configurar PasswordChar para ocultar el texto de la contraseña
            txtContraseña.PasswordChar = '●';

            // Suscribir el evento KeyPress para validar que solo se ingresen números
            txtUsuario.KeyPress += new KeyPressEventHandler(txtUsuario_KeyPress);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cedula = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            usuario = sesion.IniciarSesion(cedula, contraseña);

            if (usuario != null)
            {
                Form frmPrincipal = null;

                if (usuario.RolId == 1) // Administrador
                {
                    frmPrincipal = new FrmPrincipalAdministrador();
                }
                else if (usuario.RolId == 2) // Estudiante
                {
                    frmPrincipal = new FrmPrincipalEstudiante(usuario);
                }

                if (frmPrincipal != null)
                {
                    frmPrincipal.FormClosed += (s, args) =>
                    {
                        if (!this.Visible)
                        {
                            // Cerrar la aplicación si no hay formularios principales visibles
                            if (Application.OpenForms.OfType<Form>().Count() == 1)
                            {
                                Application.Exit();
                            }
                        }
                    };
                    frmPrincipal.Show();
                    this.Hide(); // Ocultar la ventana de login
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            }
        }

        // Validaciones
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposLlenos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposLlenos();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y el carácter de control (como el retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VerificarCamposLlenos()
        {
            // Verificar si ambos campos tienen texto
            bool camposLlenos = !string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtContraseña.Text);
            btnIngresar.Enabled = camposLlenos; // Habilitar o deshabilitar el botón
        }
    }
}
