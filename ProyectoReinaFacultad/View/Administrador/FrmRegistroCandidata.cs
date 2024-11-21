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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmRegistroCandidata : UserControl
    {
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private byte[] fotoCandidata;
        public FrmRegistroCandidata()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Redimensiona la imagen a 100x100 píxeles
            byte[] imagenRedimensionada = RedimensionarImagen(pbFotoPerfil.Image, 100, 100);

            var candidata = new Candidata
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = txtEdad.Text,
                Correo = txtCorreo.Text,
                Celular = txtCelular.Text,
                Carrera = txtCarrera.Text,
                Nivel = cmbNivel.SelectedItem.ToString(),
                Pasatiempos = txtPasatiempos.Text,
                Habilidades = txtHabilidades.Text,
                Intereses = txtIntereses.Text,
                Aspiraciones = txtAspiraciones.Text,
                Foto = imagenRedimensionada
            };

            bool registroExitoso = ctrCandidata.RegistrarCandidata(candidata);

            if (registroExitoso)
            {
                MessageBox.Show("Candidata registrada con éxito.");
            }
            else
            {
                MessageBox.Show("Error al registrar la candidata.");
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pbFotoPerfil.Image = Image.FromFile(imagePath);
                    fotoCandidata = File.ReadAllBytes(imagePath);
                }
            }
        }

        private byte[] RedimensionarImagen(Image imagenOriginal, int ancho, int alto)
        {
            using (Bitmap imagenRedimensionada = new Bitmap(imagenOriginal, new Size(ancho, alto)))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagenRedimensionada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }
    }
}
