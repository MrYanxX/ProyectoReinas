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
    public partial class FrmResultados : UserControl
    {
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private CtrAlbum ctrAlbum = new CtrAlbum();
        List<Resultado> resultados = new List<Resultado>();
        public FrmResultados()
        {
            InitializeComponent();
            cargarListaCandidatas();
        }

        private void cargarListaCandidatas()
        {
            try
            {
                List<Candidata> candidatas = ctrCandidata.ConsultarCandidatas(null, "Activo");

                Resultado reinaConMasVotos = null;
                Resultado fotogeniaConMasVotos = null;

                foreach (Candidata candidata in candidatas)
                {
                    if (ctrAlbum.ConsultarAlbum(candidata.Id) == true)
                    {
                        List<int> votos = ctrCandidata.obtenerVotos(candidata.Id);
                        Resultado resultado = new Resultado
                        {
                            Id = candidata.Id,
                            Cedula = candidata.Cedula,
                            Nombre = candidata.Nombre,
                            Apellido = candidata.Apellido,
                            Edad = candidata.Edad,
                            Correo = candidata.Correo,
                            Celular = candidata.Celular,
                            Carrera = candidata.Carrera,
                            Nivel = candidata.Nivel,
                            Pasatiempos = candidata.Pasatiempos,
                            Habilidades = candidata.Habilidades,
                            Intereses = candidata.Intereses,
                            Aspiraciones = candidata.Aspiraciones,
                            Foto = candidata.Foto,
                            Estado = candidata.Estado,
                            VotosFotogenia = votos[0],
                            VotosReina = votos[1]
                        };

                        // Agregar el resultado a la lista
                        resultados.Add(resultado);

                        // Determinar la candidata con más votos en cada categoría
                        if (reinaConMasVotos == null || resultado.VotosReina > reinaConMasVotos.VotosReina)
                        {
                            reinaConMasVotos = resultado;
                        }

                        if (fotogeniaConMasVotos == null || resultado.VotosFotogenia > fotogeniaConMasVotos.VotosFotogenia)
                        {
                            fotogeniaConMasVotos = resultado;
                        }
                    }
                }

                // Asignar los datos al DataGridView
                dtgvCandidatas.DataSource = resultados;
                dtgvCandidatas.Columns["Foto"].DisplayIndex = 0;

                ocultarInformacionCandidatas();

                // Precargar la información de la Reina
                if (reinaConMasVotos != null)
                {
                    pbFotoReina.Image = ConvertirByteAImagen(reinaConMasVotos.Foto);
                    txtNombreReina.Text = $"{reinaConMasVotos.Nombre}";
                    txtApellidoReina.Text = $"{reinaConMasVotos.Apellido}";
                    lblVotosReina.Text = $"{reinaConMasVotos.VotosReina}";
                }

                // Precargar la información de Miss Fotogenia
                if (fotogeniaConMasVotos != null)
                {
                    pbFotoFotogenia.Image = ConvertirByteAImagen(fotogeniaConMasVotos.Foto);
                    txtNombreFotogenia.Text = $"{fotogeniaConMasVotos.Nombre}";
                    txtApellidoFotogenia.Text = $"{fotogeniaConMasVotos.Apellido}";
                    lblVotosFotogenia.Text = $"{fotogeniaConMasVotos.VotosFotogenia}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de candidatas: " + ex.Message);
            }
        }


        private void ocultarInformacionCandidatas()
        {
            // Ocultar las columnas no deseadas
            foreach (DataGridViewColumn column in dtgvCandidatas.Columns)
            {
                // Usar || para ocultar columnas cuyo nombre coincide con cualquiera de los nombres especificados
                if (
                    column.Name != "Cedula" &&
                    column.Name != "Nombre" &&
                    column.Name != "Apellido" &&
                    column.Name != "Foto" &&
                    column.Name != "VotosFotogenia" &&
                    column.Name != "VotosReina"
                    )
                {
                    column.Visible = false;
                }

            }
        }

        private void dtgvCandidatas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtgvCandidatas.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaBuscada = txtCedula.Text.Trim(); // Suponiendo que txtCedula es el nombre del TextBox

            if (string.IsNullOrEmpty(cedulaBuscada))
            {
                // Si el texto del TextBox está vacío, mostrar todos los resultados
                dtgvCandidatas.DataSource = resultados;
            }
            else
            {
                // Filtrar los resultados según la cédula
                List<Resultado> resultadosFiltrados = resultados
                    .Where(r => r.Cedula.Equals(cedulaBuscada, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                dtgvCandidatas.DataSource = resultadosFiltrados;
            }

            dtgvCandidatas.ClearSelection(); // Opcional: Limpiar la selección de celdas
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
    }
}