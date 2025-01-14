using Controller;
using Model.Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace View
{
    public partial class FrmRegistroEstudiante : UserControl
    {
        private CtrEstudiante ctrEstudiante = new CtrEstudiante();

        public FrmRegistroEstudiante()
        {
            InitializeComponent();
            btnRegistrar.Enabled = false; // Deshabilitar el botón al inicio

            // Suscribir los eventos TextChanged para validar los campos
            txtMatricula.TextChanged += new EventHandler(OnInputChanged);
            txtNombre.TextChanged += new EventHandler(OnInputChanged);
            txtApellido.TextChanged += new EventHandler(OnInputChanged);
            txtCedula.TextChanged += new EventHandler(OnInputChanged);
            txtContraseña.TextChanged += new EventHandler(OnInputChanged);
            // Suscribir el evento KeyPress para validar que solo se ingresen números en matrícula y cédula
            txtMatricula.KeyPress += new KeyPressEventHandler(Numero_KeyPress);
            txtCedula.KeyPress += new KeyPressEventHandler(Numero_KeyPress);
            // Suscribir el evento KeyPress para validar que solo se ingresen letras en nombre y apellido
            txtNombre.KeyPress += new KeyPressEventHandler(Letras_KeyPress);
            txtApellido.KeyPress += new KeyPressEventHandler(Letras_KeyPress);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiante
            {
                Matricula = txtMatricula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Cedula = txtCedula.Text,
                Contraseña = txtContraseña.Text
            };

            bool registroExitoso = ctrEstudiante.RegistrarEstudiante(estudiante);

            if (registroExitoso)
            {
                MessageBox.Show("Estudiante registrado con éxito.");
            }
            else
            {
                MessageBox.Show("Error al registrar el estudiante.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }

        //Validaciones
        private void OnInputChanged(object sender, EventArgs e)
        {
            VerificarCamposLlenos();
        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y el carácter de control (como el retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Letras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y el carácter de control (como el retroceso y el espacio)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void VerificarCamposLlenos()
        {
            // Validar que todos los campos tengan texto válido
            bool camposLlenos = !string.IsNullOrWhiteSpace(txtMatricula.Text) &&
                                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                                !string.IsNullOrWhiteSpace(txtCedula.Text) &&
                                !string.IsNullOrWhiteSpace(txtContraseña.Text);

            // Validar matrícula (solo números)
            bool matriculaValida = txtMatricula.Text.All(char.IsDigit);

            // Validar cédula (exactamente 10 dígitos numéricos)
            bool cedulaValida = txtCedula.Text.Length == 10 && txtCedula.Text.All(char.IsDigit);

            // Validar nombre y apellido (solo caracteres alfabéticos y espacios)
            bool nombreValido = txtNombre.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            bool apellidoValido = txtApellido.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));

            // Habilitar o deshabilitar el botón basado en todas las validaciones
            btnRegistrar.Enabled = camposLlenos && matriculaValida && cedulaValida && nombreValido && apellidoValido;
        }
    }
}
