using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoPuesto_Click(object sender, EventArgs e)
        {
            NuevoPuesto nuevoPuesto = new NuevoPuesto();
            nuevoPuesto.Show(this);
            this.Hide();

        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show(this);
            this.Hide();

        }

        private void GestionarCandidato_Click(object sender, EventArgs e)
        {
            GestionarCandidatos gestionarCandidatos = new GestionarCandidatos();
            gestionarCandidatos.Show(this);
            this.Hide();

        }
    }
}
