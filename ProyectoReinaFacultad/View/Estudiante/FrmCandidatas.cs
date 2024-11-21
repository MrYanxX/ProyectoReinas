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
    public partial class FrmCandidatas : UserControl
    {
        CtrCandidata ctrCandidata = new CtrCandidata();
        CtrAlbum ctrAlbum = new CtrAlbum();
        Usuario usuarioActual;

        public FrmCandidatas(Usuario usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
            CargarListaCandidatas();
        }

        private void CargarListaCandidatas()
        {
            try
            {
                string estado = "Activo"; // Suponiendo que deseas cargar solo las candidatas activas
                List<Candidata> candidatas = ctrCandidata.ConsultarCandidatas(null, estado);
                List<Candidata> candidatasAlbum = new List<Candidata>();

                foreach (Candidata candidata in candidatas)
                {
                    if (ctrAlbum.ConsultarAlbum(candidata.Id) == true)
                    {
                        candidatasAlbum.Add(candidata);

                    }
                }

                dgvCandidatas.DataSource = candidatasAlbum;
                this.dgvCandidatas.Columns["Nombre"].Width = 150;
                this.dgvCandidatas.Columns["Apellido"].Width = 150;
                this.dgvCandidatas.Columns["Foto"].Width = 150;

                // Ocultar todas las columnas excepto Nombre, Apellido y Foto
                foreach (DataGridViewColumn column in dgvCandidatas.Columns)
                {
                    if (column.Name != "Nombre" && column.Name != "Apellido" && column.Name != "Foto")
                    {
                        column.Visible = false;
                    }
                }

                // Ajustar las posiciones de las columnas visibles
                dgvCandidatas.Columns["Foto"].DisplayIndex = 0;
                dgvCandidatas.Columns["Nombre"].DisplayIndex = 1;
                dgvCandidatas.Columns["Apellido"].DisplayIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de candidatas: " + ex.Message);
            }
        }

        private void dgvCandidatas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic es en una celda del encabezado (e.RowIndex == -1) o en una celda de datos
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verifica si la columna clickeada es la columna del botón
                if (dgvCandidatas.Columns[e.ColumnIndex].Name == "btnVerAlbum")
                {
                    // Acción cuando se hace clic en el botón
                    MessageBox.Show($"Botón 'Ver Álbum' clickeado en la fila {e.RowIndex}");
                    FrmConsultarCandidata c = new FrmConsultarCandidata();
                    c.Show();
                }
            }
        }

        private void dgvCandidatas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCandidatas.ClearSelection();
        }

        private void btnPortafolio_Click(object sender, EventArgs e)
        {
            List<Foto> album = null;
            Candidata candidata = null;
            if (dgvCandidatas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvCandidatas.SelectedRows[0];

                // Comprobar si la celda "Id" tiene un valor
                if (filaSeleccionada.Cells["Id"].Value != null)
                {
                    int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                    candidata = ctrCandidata.ConsultarCandidatasPorId(id);
                    album = ctrAlbum.consultarFotos(id);
                }
            }

            Controls.Clear();
            FrmPortafolio panelInicio = new FrmPortafolio(candidata, album, usuarioActual);
            panelInicio.Dock = DockStyle.Fill;
            Controls.Add(panelInicio);
        }

    }
}