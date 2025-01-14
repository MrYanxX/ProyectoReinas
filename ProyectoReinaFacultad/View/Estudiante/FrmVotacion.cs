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
    public partial class FrmVotacion : UserControl
    {
        private Usuario usuarioActual;
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private CtrVotacion ctrVotacion = new CtrVotacion();
        private CtrAlbum ctrAlbum = new CtrAlbum();
        public FrmVotacion(Usuario usuarioActual, string titulo)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            label1.Text = titulo;
            cargarListaCandidatas();
        }

        private void cargarListaCandidatas()
        {
            try
            {
                // Obtener la lista de candidatas desde el controlador
                List<Candidata> candidatas = ctrCandidata.consultarCandidatasPorNombre(null);
                List<Candidata> candidatasAlbum = new List<Candidata>();

                foreach (Candidata candidata in candidatas)
                {
                    if (ctrAlbum.ConsultarAlbum(candidata.Id) == true)
                    {
                        candidatasAlbum.Add(candidata);

                    }
                }
                dgvCandidatas.DataSource = candidatasAlbum;

                ocultarInformacionCandidatas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de candidatas: " + ex.Message);
            }
        }

        private void ocultarInformacionCandidatas()
        {
            // Ocultar las columnas no deseadas
            foreach (DataGridViewColumn column in dgvCandidatas.Columns)
            {
                // Usar || para ocultar columnas cuyo nombre coincide con cualquiera de los nombres especificados
                if (column.Name == "Id" ||
                    column.Name == "Cedula" ||
                    column.Name == "Correo" ||
                    column.Name == "Celular" ||
                    column.Name == "Nivel" ||
                    column.Name == "Foto" ||
                    column.Name == "Estado")
                {
                    column.Visible = false;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreCandidata.Text;

                List<Candidata> candidatas = ctrCandidata.consultarCandidatasPorNombre(nombre);
                dgvCandidatas.DataSource = candidatas;

                ocultarInformacionCandidatas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de candidatas: " + ex.Message);
            }
        }

        private void dgvCandidatas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCandidatas.ClearSelection();
        }


        public Image ConvertirByteAImagen(byte[] imagenBytes)
        {
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            else
            {
                return null;
            }
        }

        private void dgvCandidatas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCandidatas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];

                // Comprobar si la celda "Id" tiene un valor
                if (filaSeleccionada.Cells["Id"].Value != null)
                {
                    int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    Candidata candidata = ctrCandidata.ConsultarCandidatasPorId(id);

                    // Comprobar si la candidata encontrada no es nula
                    if (candidata != null)
                    {
                        imgCandidata.Image = candidata.Foto != null ? ConvertirByteAImagen(candidata.Foto) : null;
                        txtNombre.Text = candidata.Nombre;
                        txtApellido.Text = candidata.Apellido;
                        txtEdad.Text = candidata.Edad;
                        txtCarrera.Text = candidata.Carrera;
                    }
                }
            }
        }

        private void btnCandidata_Click(object sender, EventArgs e)
        {
            string tipoVoto = null;
            if (label1.Text == "Votacion Miss Fotogenia")
            {
                tipoVoto = "Fotogenia";
            }
            else
            {
                tipoVoto = "Reina";
            }

            bool verificarVotacion = ctrVotacion.VerificarVotacion(usuarioActual.Id, tipoVoto);
            if (verificarVotacion)
            {
                MessageBox.Show("Ya ha registrado una votación. No se pueden registrar más.");
            }
            else
            {
                string resultadoPregunta = ShowQuestion();
                if (resultadoPregunta == "Si")
                {
                    if (dgvCandidatas.SelectedRows.Count > 0)
                    {
                        DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];

                        // Comprobar si la celda "Id" tiene un valor
                        if (filaSeleccionada.Cells["Id"].Value != null)
                        {
                            int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);

                            var votacionFotegenia = new Votacion
                            {
                                CandidataId = id,
                                EstudianteId = usuarioActual.Id,
                                TipoVoto = tipoVoto
                            };

                            bool registrado = ctrVotacion.RegistrarVotacion(votacionFotegenia);

                            if (registrado)
                            {
                                MessageBox.Show("Voto Registrado exitosamente.", "Información", MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }

        }

        private string ShowQuestion()
        {
            // Mostrar MessageBox con una pregunta y botones Yes y No
            DialogResult result = MessageBox.Show(
                "¿Desea votar por esta candidata?", // Mensaje de la pregunta
                "Confirmación", // Título del MessageBox
                MessageBoxButtons.YesNo, // Botones a mostrar
                MessageBoxIcon.Question // Icono del MessageBox
            );

            // Retornar una palabra basada en la elección del usuario
            if (result == DialogResult.Yes)
                return "Si";
            else
                return "No";
        }


    }
}