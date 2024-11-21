using Controller;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmConsultarEstudiante : UserControl
    {
        private CtrEstudiante ctrEstudiante = new CtrEstudiante();
        public FrmConsultarEstudiante()
        {
            InitializeComponent();
            btnBuscar.Enabled = false; // Deshabilitar el botón al inicio

            // Suscribir eventos para validar los campos
            txtCedula.TextChanged += new EventHandler(OnInputChanged);
            cmbEstado.SelectedIndexChanged += new EventHandler(OnInputChanged);

            // Suscribir el evento KeyPress para validar que solo se ingresen números en la cédula
            txtCedula.KeyPress += new KeyPressEventHandler(Numero_KeyPress);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : null;

            List<Estudiante> estudiantes;

            // Busca según los valores proporcionados
            estudiantes = ctrEstudiante.ConsultarEstudiantes(
                string.IsNullOrEmpty(cedula) ? null : cedula,
                string.IsNullOrEmpty(estado) ? null : estado
            );

            // Mostrar los resultados en el DataGridView
            dgvEstudiantes.DataSource = estudiantes;
            dgvEstudiantes.Columns["Usuario"].Visible = false;
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEstudiantes.SelectedRows[0];

                // Crear una instancia de Estudiante con los datos actualizados
                Estudiante estudianteActualizado = new Estudiante
                {
                    Id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value),
                    UsuarioId = Convert.ToInt32(filaSeleccionada.Cells["UsuarioId"].Value),
                    Matricula = filaSeleccionada.Cells["Matricula"].Value.ToString(),
                    Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(),
                    Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString(),
                    Cedula = filaSeleccionada.Cells["Cedula"].Value.ToString(),
                    Contraseña = filaSeleccionada.Cells["Contraseña"].Value.ToString(),
                    Estado = filaSeleccionada.Cells["Estado"].Value.ToString()
                };

                // Enviar los datos actualizados al controlador
                bool actualizacionExitosa = ctrEstudiante.ActualizarEstudiante(estudianteActualizado);

                if (actualizacionExitosa)
                {
                    MessageBox.Show("Estudiante actualizado con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el estudiante.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvEstudiantes.SelectedRows[0];

                // Obtener el Id del estudiante a "eliminar"
                int estudianteId = Convert.ToInt32(filaSeleccionada.Cells["UsuarioId"].Value);

                // Llamar al método del controlador para cambiar el estado del estudiante
                bool eliminacionExitosa = ctrEstudiante.EliminarEstudiante(estudianteId);

                if (eliminacionExitosa)
                {
                    MessageBox.Show("Estudiante marcado como inactivo con éxito.");

                    // Refrescar el DataGridView después de la eliminación lógica
                    string cedula = txtCedula.Text.Trim();
                    string estado = cmbEstado.SelectedItem.ToString();

                    List<Estudiante> estudiantes = ctrEstudiante.ConsultarEstudiantes(cedula, estado);
                    dgvEstudiantes.DataSource = estudiantes;
                }
                else
                {
                    MessageBox.Show("Error al marcar el estudiante como inactivo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }


        //Validaciones del consultar
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

        private void VerificarCamposLlenos()
        {
            // Validar que la cédula tenga exactamente 10 dígitos y que se haya elegido un estado
            bool esCedulaValida = txtCedula.Text.Length == 10 && !string.IsNullOrWhiteSpace(txtCedula.Text);
            bool esEstadoSeleccionado = cmbEstado.SelectedItem != null;

            // Habilitar o deshabilitar el botón basado en las validaciones
            btnBuscar.Enabled = esCedulaValida || esEstadoSeleccionado;
        }



    }
}
