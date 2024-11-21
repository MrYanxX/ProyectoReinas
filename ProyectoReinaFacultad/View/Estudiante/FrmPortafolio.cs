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
    public partial class FrmPortafolio : UserControl
    {
        private Usuario usuarioActual;
        private Candidata candidata;
        private List<Foto> album;
        private CtrComentario ctrComentario = new CtrComentario();

        public FrmPortafolio(Candidata candidata, List<Foto> album, Usuario usuarioActual)
        {
            InitializeComponent();
            this.candidata = candidata;
            this.album = album;
            this.usuarioActual = usuarioActual;
            CargarDatos();
        }

        public void CargarDatos()
        {
            pbFotoCandidata.Image = ConvertirByteAImagen(candidata.Foto);
            txtNombre.Text = candidata.Nombre;
            txtApellido.Text = candidata.Apellido;
            txtEdad.Text = candidata.Edad;
            txtCarrera.Text = candidata.Carrera;

            pbFoto1.Image = ConvertirByteAImagen(album[0].FotoData);
            txtTitulo1.Text = album[0].Titulo;
            txtDescripcion1.Text = album[0].Descripcion;

            pbFoto2.Image = ConvertirByteAImagen(album[1].FotoData);
            txtTitulo2.Text = album[1].Titulo;
            txtDescripcion2.Text = album[1].Descripcion;

            pbFoto3.Image = ConvertirByteAImagen(album[2].FotoData);
            txtTitulo3.Text = album[2].Titulo;
            txtDescripcion3.Text = album[2].Descripcion;

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

        private void btnRegistrarComentario_Click(object sender, EventArgs e)
        {
            // Validar que al menos un comentario haya sido ingresado
            if (string.IsNullOrWhiteSpace(txtComentario1.Text) &&
                string.IsNullOrWhiteSpace(txtComentario2.Text) &&
                string.IsNullOrWhiteSpace(txtComentario3.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un comentario antes de registrar.");
                return;
            }

            try
            {
                Comentario comentario1 = new Comentario(album[0].Id, usuarioActual.Id, txtComentario1.Text);
                Comentario comentario2 = new Comentario(album[1].Id, usuarioActual.Id, txtComentario2.Text);
                Comentario comentario3 = new Comentario(album[2].Id, usuarioActual.Id, txtComentario3.Text);

                ctrComentario.RegistrarComentario(comentario1);
                ctrComentario.RegistrarComentario(comentario2);
                ctrComentario.RegistrarComentario(comentario3);

                MessageBox.Show("Los comentarios fueron registrados correctamente");

                // Limpiar los campos de comentario
                txtComentario1.Text = string.Empty;
                txtComentario2.Text = string.Empty;
                txtComentario3.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el comentario. Error: " + ex.Message);
            }
        }


    }
}