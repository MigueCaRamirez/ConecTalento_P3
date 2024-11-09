using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Drawing.Text;
using static System.Windows.Forms.LinkLabel;
using BLL;


namespace GUI
{
    public partial class login : Form
    {
        private bool moved = false;

        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TxtCc.UseSystemPasswordChar = true;
            panelSuperior.Size = new Size(panelInferior.Width / 2, panelInferior.Height);
            panelSuperior.Location = new Point(0, 0); 
            panelInferior.Controls.Add(panelSuperior);

            label1.Location = new Point(105, 120); 
            panelSuperior.Controls.Add(label1);

            labelE.Visible = false;
            labelEu.Visible = false;
            TxtEu.Visible = false;
            labelEc.Visible = false;
            TxtEc.Visible = false;
            BtnE.Visible = false;

            
            InicializarBotonesEvaluador();
        }

        private void InicializarBotonesEvaluador()
        {
            panelSuperior.Controls.Clear(); 

           
            BtnEvaluador.Location = new Point(110, 180); 
            BtnAdmin.Location = new Point(110, 250); 

            panelSuperior.Controls.Add(BtnEvaluador);
            panelSuperior.Controls.Add(BtnAdmin);
            panelSuperior.Controls.Add(label1);

            
            BtnCandidato.Visible = false;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ellipseControl2_Click(object sender, EventArgs e)
        {

        }

        private void MoverPanelYConfigurarBotones(int nuevaPosicionX, bool mostrarCandidato)
        {
            panelSuperior.Location = new Point(nuevaPosicionX, 0);

        }

        private void InicializarBotonesCandidato()
        {
            panelSuperior.Controls.Clear();

            BtnCandidato.Location = new Point(110, 120); 
            BtnAdmin.Location = new Point(110, 180); 

            panelSuperior.Controls.Add(BtnCandidato);
            panelSuperior.Controls.Add(BtnAdmin);

            
            BtnEvaluador.Visible = true;
           
        }


        private void panelInferior_Click(object sender, EventArgs e)
        {

        }

   

        private void BtnEvaluador_Click_1(object sender, EventArgs e)
        {
                label2.Visible = false;
                labelCu.Visible = false;
                TxtCu.Visible = false;
                labelCc.Visible = false;
                TxtCc.Visible = false;
                BtnC.Visible = false;
               LinkC.Visible = false;
                lblErrorC.Visible = false;




            MoverPanelDerecha();
            labelE.Visible = true;
            labelEu.Visible = true;
            TxtEu.Visible = true;
            labelEc.Visible = true;
            TxtEc.Visible = true;
            BtnE.Visible = true;

           
            BtnEvaluador.Visible = false;
            BtnCandidato.Visible = true;
            
            BtnCandidato.Location = new Point(617, 265); 

            
            BtnCandidato.BringToFront();

            
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show(this);
            this.Hide();
        }


        private void BtnCandidato_Click(object sender, EventArgs e)
        {
            BtnCandidato.Visible = false;
            BtnEvaluador.Visible = true;

            labelE.Visible = false;
            labelEu.Visible = false;
            TxtEu.Visible = false;
            labelEc.Visible = false;
            TxtEc.Visible = false;
            BtnE.Visible = false;

            

            

            MoverPanelIzquierda();
            label2.Visible = true;
            labelCu.Visible = true;
            TxtCu.Visible = true;
            labelCc.Visible = true;
            TxtCc.Visible = true;
            BtnC.Visible = true;
            LinkC.Visible = true;

            
            
            


            BtnEvaluador.Location = new Point(110, 180); 

            BtnEvaluador.BringToFront();
        }

        private void MoverPanelIzquierda()
        {
            
            int velocidad = 5;

            
            int posicionInicial = panelSuperior.Location.X;

            
            int posicionFinal = 0;

            for (int i = posicionInicial; i >= posicionFinal; i -= velocidad)
            {
                panelSuperior.Location = new Point(i, panelSuperior.Location.Y);
                label1.Location = new Point(105, 120);
                Application.DoEvents(); 
            }
        }

        private void MoverPanelDerecha()
        {
            
            int velocidad = 5;

            int posicionInicial = panelSuperior.Location.X;

            
            int posicionFinal = panelInferior.Width / 2;

            for (int i = posicionInicial; i <= posicionFinal; i += velocidad)
            {
                panelSuperior.Location = new Point(i, panelSuperior.Location.Y);
                label1.Location = new Point(105, 120);
                Application.DoEvents(); 
            }
        }



        private void BtnC_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(TxtCu.Text) || TxtCu.Text == "UserName")
            {
                msgError("Por favor ingrese el usuario");
                return; 
            }

           
            if (string.IsNullOrEmpty(TxtCc.Text) || TxtCc.Text == "Password")
            {
                msgError("Por favor ingrese la contraseña");
                return; 
            }


            NRecuperarPassword user = new NRecuperarPassword();
            var validLogin = user.LoginUser(TxtCu.Text, TxtCc.Text);
            if (validLogin)
            {
              PrincipalCandidato principalC = new PrincipalCandidato();
              principalC.Show(this);
                this.Hide(); 
            }
            else
            {
                msgError("Error, usuario o contraseña incorrectas \n reintentar");
                TxtCc.Clear(); 
                TxtCu.Focus(); 
            }
        }

        private void msgError(string msg)
        {
            lblErrorC.Text = "      "+ msg;
            lblErrorC.Visible = true;
        }

        private void LinkC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recoverPassword = new  FormRecoverPassword();
            recoverPassword.ShowDialog();
        }
    }
    
}