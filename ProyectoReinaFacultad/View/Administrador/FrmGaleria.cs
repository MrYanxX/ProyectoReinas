using Controller;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Album
{
    public partial class FrmGaleria : UserControl
    {
        List<Foto> fotosEnPantalla = new List<Foto>();
        private byte[] foto;

        CtrAlbum ctrAlbum = new CtrAlbum();
        CtrCandidata ctrCandidata = new CtrCandidata();

        public FrmGaleria()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string estado = cmbEstado.SelectedItem.ToString();

            if(estado == "Inactivo")
            {
                btnActualizar.Visible = false;
                btnRegistrar.Visible = false;
                imagenUno.Enabled = false;
                tituloUno.Enabled = false;
                descripcionUno.Enabled = false;
                imagenDos.Enabled = false;
                tituloDos.Enabled = false;
                descripcionDos.Enabled = false;
                imagenTres.Enabled = false;
                tituloTres.Enabled = false;
                descripcionTres.Enabled = false;
                vaciarCampos();

            }
            else
            {
                btnActualizar.Visible = false;
                btnRegistrar.Visible = false;
                imagenUno.Enabled = true;
                tituloUno.Enabled = true;
                descripcionUno.Enabled = true;
                imagenDos.Enabled = true;
                tituloDos.Enabled = true;
                descripcionDos.Enabled = true;
                imagenTres.Enabled = true;
                tituloTres.Enabled = true;
                descripcionTres.Enabled = true;
                vaciarCampos();
            }

            List<Candidata> candidatas = ctrCandidata.ConsultarCandidatas(
                string.IsNullOrEmpty(cedula) ? null : cedula,
                string.IsNullOrEmpty(estado) ? null : estado
            );

            dgvCandidatas.DataSource = candidatas;
            dgvCandidatas.Columns["Foto"].Visible = false;
        }

        private void dgvCandidatas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCandidatas.ClearSelection();
        }

        private void btnConsultarAlbum_Click(object sender, EventArgs e)
        {
            int idCandidata;
            if (dgvCandidatas.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];
                idCandidata = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                bool albumRegistrado = ctrAlbum.ConsultarAlbum(idCandidata);
                if (albumRegistrado)
                {
                    fotosEnPantalla = ctrAlbum.consultarFotos(idCandidata);

                    imagenUno.Image = ConvertirByteAImagen(fotosEnPantalla[0].FotoData);
                    tituloUno.Text = fotosEnPantalla[0].Titulo;
                    descripcionUno.Text = fotosEnPantalla[0].Descripcion;

                    imagenDos.Image = ConvertirByteAImagen(fotosEnPantalla[1].FotoData);
                    tituloDos.Text = fotosEnPantalla[1].Titulo;
                    descripcionDos.Text = fotosEnPantalla[1].Descripcion;

                    imagenTres.Image = ConvertirByteAImagen(fotosEnPantalla[2].FotoData);
                    tituloTres.Text = fotosEnPantalla[2].Titulo;
                    descripcionTres.Text = fotosEnPantalla[2].Descripcion;

                    if(cmbEstado.Text == "Inactivo")
                    {
                        btnActualizar.Visible = false;
                        btnRegistrar.Visible = false;
                    }
                    else
                    {
                        btnActualizar.Visible = true;
                        btnRegistrar.Visible = false;
                    }
                    
                }
                else
                {
                    vaciarCampos();

                    if(cmbEstado.Text == "Inactivo")
                    {
                        btnRegistrar.Visible = false;
                        btnActualizar.Visible = false;
                    }
                    else
                    {
                        btnRegistrar.Visible = true;
                        btnActualizar.Visible = false;
                    }

                    MessageBox.Show("No hay álbum registrado.");
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idCandidata = 0;
            List<Foto> fotos = new List<Foto>();
            Foto foto1 = new Foto
            {
                Titulo = tituloUno.Text,
                Descripcion = descripcionUno.Text,
                FotoData = ConvertirImagenAByteArray(imagenUno.Image)
            };

            Foto foto2 = new Foto
            {
                Titulo = tituloDos.Text,
                Descripcion = descripcionDos.Text,
                FotoData = ConvertirImagenAByteArray(imagenDos.Image)
            };

            Foto foto3 = new Foto
            {
                Titulo = tituloTres.Text,
                Descripcion = descripcionTres.Text,
                FotoData = ConvertirImagenAByteArray(imagenTres.Image)
            };

            fotos.Add(foto1);
            fotos.Add(foto2);
            fotos.Add(foto3);

            if (dgvCandidatas.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];
                idCandidata = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                bool albumRegistrado = ctrAlbum.ConsultarAlbum(idCandidata);
                if (albumRegistrado)
                {
                    MessageBox.Show("Esta candidata ya tiene un albúm registrado, consulta su album para actualizar");

                    vaciarCampos();
                    btnRegistrar.Visible = false;
                    btnActualizar.Visible = false;
                }
                else
                {
                    bool registroExitoso = ctrAlbum.RegistrarFotos(fotos, idCandidata);

                    if (registroExitoso)
                    {
                        MessageBox.Show("Fotos registradas con éxito.");
                        vaciarCampos();
                        btnRegistrar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar fotos.");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para registrar.");
            }
        }

        private void imagenUno_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    imagenUno.Image = Image.FromFile(imagePath);
                    foto = File.ReadAllBytes(imagePath);
                }
            }
        }

        private void imagenDos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    imagenDos.Image = Image.FromFile(imagePath);
                    foto = File.ReadAllBytes(imagePath);
                }
            }
        }

        private void imagenTres_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    imagenTres.Image = Image.FromFile(imagePath);
                    foto = File.ReadAllBytes(imagePath);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Image imgUno = imagenUno.Image;
            Image imgDos = imagenDos.Image;
            Image imgTres = imagenTres.Image;

            fotosEnPantalla[0].FotoData = ConvertirImagenAByteArray(imgUno);
            fotosEnPantalla[0].Titulo = tituloUno.Text;
            fotosEnPantalla[0].Descripcion = descripcionUno.Text;

            fotosEnPantalla[1].FotoData = ConvertirImagenAByteArray(imgDos);
            fotosEnPantalla[1].Titulo = tituloDos.Text;
            fotosEnPantalla[1].Descripcion = descripcionDos.Text;

            fotosEnPantalla[2].FotoData = ConvertirImagenAByteArray(imgTres);
            fotosEnPantalla[2].Titulo = tituloTres.Text;
            fotosEnPantalla[2].Descripcion = descripcionTres.Text;

            bool exitoso = ctrAlbum.actualizarAlbum(fotosEnPantalla);
            if (exitoso) 
            {
                vaciarCampos();
                btnRegistrar.Visible = false;
                btnRegistrar.Visible = false;

                MessageBox.Show("Álbum actualizado con exito.");
            }
            else
            {
                vaciarCampos();
                btnRegistrar.Visible = false;
                btnRegistrar.Visible = false;

                MessageBox.Show("No se ha podido actualizar el álbum.Consulte e intente de nuevo.");
            }
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

        private byte[] ConvertirImagenAByteArray(Image imagenOriginal)
        {
            if (imagenOriginal == null)
                throw new ArgumentNullException(nameof(imagenOriginal), "La imagen original no puede ser nula.");

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Guarda la imagen en el MemoryStream
                    imagenOriginal.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    // Convierte el MemoryStream a un array de bytes
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones generales
                Console.WriteLine("ERROR: " + ex.Message);
                throw; // Lanza la excepción para que el llamador pueda manejarla si es necesario
            }
        }
        private void vaciarCampos()
        {
            imagenUno.Image = null;
            tituloUno.Text = "";
            descripcionUno.Text = "";
            imagenDos.Image = null;
            tituloDos.Text = "";
            descripcionDos.Text = "";
            imagenTres.Image = null;
            tituloTres.Text = "";
            descripcionTres.Text = "";
        }


    }
}