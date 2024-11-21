using Controller;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmConsultarCandidata : UserControl
    {
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private byte[] imagenTemporal = null;

        public FrmConsultarCandidata()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : null;

            List<Candidata> candidatas = ctrCandidata.ConsultarCandidatas(
                string.IsNullOrEmpty(cedula) ? null : cedula,
                string.IsNullOrEmpty(estado) ? null : estado
            );

            // Mostrar los resultados en el DataGridView
            dgvCandidatas.DataSource = candidatas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvCandidatas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];

                // Crear una instancia de Candidata con los datos actualizados
                Candidata candidataActualizada = new Candidata
                {
                    Id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value),
                    Cedula = filaSeleccionada.Cells["Cedula"].Value.ToString(),
                    Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(),
                    Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString(),
                    Edad = filaSeleccionada.Cells["Edad"].Value.ToString(),
                    Correo = filaSeleccionada.Cells["Correo"].Value.ToString(),
                    Celular = filaSeleccionada.Cells["Celular"].Value.ToString(),
                    Carrera = filaSeleccionada.Cells["Carrera"].Value.ToString(),
                    Nivel = filaSeleccionada.Cells["Nivel"].Value.ToString(),
                    Pasatiempos = filaSeleccionada.Cells["Pasatiempos"].Value.ToString(),
                    Habilidades = filaSeleccionada.Cells["Habilidades"].Value.ToString(),
                    Intereses = filaSeleccionada.Cells["Intereses"].Value.ToString(),
                    Aspiraciones = filaSeleccionada.Cells["Aspiraciones"].Value.ToString(),
                    Foto = imagenTemporal ?? filaSeleccionada.Cells["Foto"].Value as byte[],  // Usa la imagen temporal si existe, de lo contrario usa la imagen actual
                    Estado = filaSeleccionada.Cells["Estado"].Value.ToString()
                };

                // Enviar los datos actualizados al controlador
                bool actualizacionExitosa = ctrCandidata.ActualizarCandidata(candidataActualizada);

                if (actualizacionExitosa)
                {
                    MessageBox.Show("Candidata actualizada con éxito.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar la candidata.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para actualizar.");
            }
        }

        private byte[] ConvertirImagenABytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            return new Bitmap(imagenOriginal, new Size(ancho, alto));
        }

        private void dgvCandidatas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se hizo clic en la columna de la foto
            if (e.ColumnIndex == dgvCandidatas.Columns["Foto"].Index && e.RowIndex >= 0)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;
                        Image newImage = RedimensionarImagen(Image.FromFile(imagePath), 100, 100);
                        byte[] newImageBytes = ConvertirImagenABytes(newImage);

                        // Mostrar la nueva imagen en el DataGridView
                        dgvCandidatas.Rows[e.RowIndex].Cells["Foto"].Value = newImage;

                        // Guardar los bytes de la nueva imagen en la variable temporal
                        imagenTemporal = newImageBytes;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvCandidatas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];

                // Obtener el Id de la candidata a "eliminar"
                int candidataId = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                // Llamar al método del controlador para cambiar el estado de la candidata
                bool eliminacionExitosa = ctrCandidata.EliminarCandidata(candidataId);

                if (eliminacionExitosa)
                {
                    MessageBox.Show("Candidata marcada como inactiva con éxito.");

                    // Refrescar el DataGridView después de la eliminación lógica
                    string cedula = txtCedula.Text.Trim();
                    string estado = cmbEstado.SelectedItem.ToString();

                    List<Candidata> candidatas = ctrCandidata.ConsultarCandidatas(cedula, estado);
                    dgvCandidatas.DataSource = candidatas;
                }
                else
                {
                    MessageBox.Show("Error al marcar la candidata como inactiva.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }


    }
}
