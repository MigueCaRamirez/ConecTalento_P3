namespace GUI
{
    partial class FormRecoverPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRecuperarContraseña = new System.Windows.Forms.TextBox();
            this.LblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(224, 98);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 0;
            this.BtnEnviar.Text = "ENVIAR";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESA TU CORREO ELECTRONICO ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtRecuperarContraseña
            // 
            this.TxtRecuperarContraseña.Location = new System.Drawing.Point(68, 61);
            this.TxtRecuperarContraseña.Name = "TxtRecuperarContraseña";
            this.TxtRecuperarContraseña.Size = new System.Drawing.Size(299, 20);
            this.TxtRecuperarContraseña.TabIndex = 2;
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(65, 139);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(73, 13);
            this.LblResultado.TabIndex = 3;
            this.LblResultado.Text = "RESULTADO";
            // 
            // FormRecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 294);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.TxtRecuperarContraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnviar);
            this.Name = "FormRecoverPassword";
            this.Text = "FormRecoverPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRecuperarContraseña;
        private System.Windows.Forms.Label LblResultado;
    }
}