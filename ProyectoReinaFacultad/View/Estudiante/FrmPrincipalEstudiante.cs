using Controller;
using Model.Modelo;
using System;
using System.Windows.Forms;
using View.Album;
using Vista;

namespace View
{
    public partial class FrmPrincipalEstudiante : Form
    {
        private CtrCandidata ctrCandidata = new CtrCandidata();
        private Usuario usuarioActual;

        public FrmPrincipalEstudiante(Usuario usuarioActual)
        {
            InitializeComponent();
            this.usuarioActual = usuarioActual;
            this.FormClosed += FrmPrincipalEstudiante_FormClosed; // Agregar el evento FormClosed
        }

        private void FrmPrincipalEstudiante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cerrar la aplicación al cerrar el formulario principal
        }

        private void fotogeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmVotacion panelVotacionFotogenia = new FrmVotacion(usuarioActual, "Votacion Miss Fotogenia");
            panelVotacionFotogenia.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelVotacionFotogenia);
        }

        private void FrmPrincipalEstudiante_Load(object sender, EventArgs e)
        {
            FrmCandidatas frmCandidatas = new FrmCandidatas(usuarioActual);
            frmCandidatas.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmCandidatas);
        }

        private void reinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmVotacion panelVotacionFotogenia = new FrmVotacion(usuarioActual, "Votacion Reina");
            panelVotacionFotogenia.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelVotacionFotogenia);
        }

        private void candidatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmCandidatas frmCandidatas = new FrmCandidatas(usuarioActual);
            frmCandidatas.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmCandidatas);
        }

        private void comentariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmConsultarComentarios frmCandidatas = new FrmConsultarComentarios();
            frmCandidatas.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(frmCandidatas);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login
            Login loginForm = new Login();
            loginForm.Show();

            // Ocultar el formulario principal del estudiante
            this.Hide();
        }
    }
}
