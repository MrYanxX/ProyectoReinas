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
    public partial class FrmConsultarComentarios : UserControl
    {
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private CtrAlbum ctrAlbum = new CtrAlbum();

        public FrmConsultarComentarios()
        {
            InitializeComponent();
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








    }
}
