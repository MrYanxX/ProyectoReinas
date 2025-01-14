using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using View.Album;

namespace Vista
{
    public partial class FrmPrincipalAdministrador : Form
    {

        public FrmPrincipalAdministrador()
        {
            InitializeComponent();

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmRegistroCandidata panelInicio = new FrmRegistroCandidata();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmRegistroEstudiante panelInicio = new FrmRegistroEstudiante();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void consultarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmConsultarEstudiante panelInicio = new FrmConsultarEstudiante();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void registrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmRegistroAdministrador panelInicio = new FrmRegistroAdministrador();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmConsultarAdministrador panelInicio = new FrmConsultarAdministrador();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmConsultarCandidata panelInicio = new FrmConsultarCandidata();
            panelInicio.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelInicio);
        }

        private void álbumDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmGaleria panelGaleria = new FrmGaleria();
            panelGaleria.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelGaleria);
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            FrmResultados panelResultados = new FrmResultados();
            panelResultados.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(panelResultados);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de login
            Login loginForm = new Login();
            loginForm.FormClosed += (s, args) =>
            {
                // Cerrar la aplicación si no hay formularios principales visibles
                if (Application.OpenForms.OfType<Form>().Count() == 1)
                {
                    Application.Exit();
                }
            };
            loginForm.Show();

            // Cerrar el formulario principal del Administrador
            this.Close();
        }
    }
}