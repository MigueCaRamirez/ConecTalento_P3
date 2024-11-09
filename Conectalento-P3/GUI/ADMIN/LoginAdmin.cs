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
    public partial class LoginAdmin : Form
    {

        public LoginAdmin()
        {
           
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TxtContraseña.UseSystemPasswordChar = true;
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            login login = new login();
            login.Show(this);
            this.Hide();

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

            login login = new login();
            login.Show(this);
            this.Hide();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUsuario.Text) )
            {
                msgError("Por favor ingrese el usuario");
                return;
            }


            if (string.IsNullOrEmpty(TxtContraseña.Text))
            {
                msgError("Por favor ingrese la contraseña");
                return;
            }
            else
            {
                if(TxtUsuario.Text == "admin"&&TxtContraseña.Text == "admin")
                {
                    PrincipalAdmin principalAdmin = new PrincipalAdmin();
                    principalAdmin.Show(this);
                    this.Hide();


                }
                else
                {
                    msgError("Error, usuario o contraseña incorrectas \n reintentar");
                    TxtContraseña.Clear();
                    TxtUsuario.Focus();
                }
            }
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
    }
}
