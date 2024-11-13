using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.EVALUADOR
{
    public partial class PanelMenuEvaluadores : Form
    {
        public PanelMenuEvaluadores()
        {
            InitializeComponent();

            PrincipalEvaluador principalEvaluador = new PrincipalEvaluador();
            AbrirFormularioEnPanel(principalEvaluador);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirFormularioEnPanel(Form PanelMenu)
        {

            PanelContenedor.Controls.Clear();

            PanelMenu.TopLevel = false;
            PanelMenu.FormBorderStyle = FormBorderStyle.None;
            PanelMenu.Dock = DockStyle.Fill;


            PanelContenedor.Controls.Add(PanelMenu);
            PanelMenu.Show();
        }
        private void btnPrincipalEvaluador_Click(object sender, EventArgs e)
        {
            PrincipalEvaluador principalEvaluador = new PrincipalEvaluador();
            AbrirFormularioEnPanel(principalEvaluador);
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            VerDetalles verDetalles = new VerDetalles();
            AbrirFormularioEnPanel(verDetalles);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            AbrirFormularioEnPanel(historial);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            login Login = new login();
            Login.Show(this);
            this.Hide();
        }
    }
}
