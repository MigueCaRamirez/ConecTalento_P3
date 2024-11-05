using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace GUI
{
    public partial class FormRecoverPassword : Form
    {
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRecuperar = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(71, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECUPERACION DE CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE SU CORREO ELECTRONICO";
            // 
            // TxtRecuperar
            // 
            this.TxtRecuperar.Location = new System.Drawing.Point(74, 198);
            this.TxtRecuperar.Name = "TxtRecuperar";
            this.TxtRecuperar.Size = new System.Drawing.Size(398, 20);
            this.TxtRecuperar.TabIndex = 2;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnviar.Location = new System.Drawing.Point(345, 262);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(105, 38);
            this.BtnEnviar.TabIndex = 3;
            this.BtnEnviar.Text = "ENVIAR";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click_1);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(114, 330);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // FormRecoverPassword
            // 
            this.ClientSize = new System.Drawing.Size(812, 475);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtRecuperar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRecoverPassword";
            this.Load += new System.EventHandler(this.FormRecoverPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public FormRecoverPassword()
        {
            InitializeComponent();
        }

        private Label label1;
        private Label label2;
        private TextBox TxtRecuperar;
        private Button BtnEnviar;
        private Label lblResult;

        private void BtnEnviar_Click_1(object sender, EventArgs e)
        {
            var user = new DRecuperarPassword();
            var result = user.recoverPassword(TxtRecuperar.Text);
            lblResult.Text = result;
        }

        private void FormRecoverPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
