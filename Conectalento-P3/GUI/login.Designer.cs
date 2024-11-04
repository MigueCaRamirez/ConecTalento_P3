namespace GUI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorC = new System.Windows.Forms.Label();
            this.LinkC = new System.Windows.Forms.LinkLabel();
            this.BtnE = new System.Windows.Forms.Button();
            this.TxtEc = new System.Windows.Forms.TextBox();
            this.labelEc = new System.Windows.Forms.Label();
            this.TxtEu = new System.Windows.Forms.TextBox();
            this.labelEu = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.BtnC = new System.Windows.Forms.Button();
            this.TxtCc = new System.Windows.Forms.TextBox();
            this.labelCc = new System.Windows.Forms.Label();
            this.TxtCu = new System.Windows.Forms.TextBox();
            this.labelCu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCandidato = new System.Windows.Forms.Button();
            this.BtnEvaluador = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new GUI.Controls.EllipseControl();
            this.panelInferior = new GUI.Controls.EllipseControl();
            this.ellipseComponent1 = new GUI.Components.EllipseComponent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblErrorC);
            this.panel1.Controls.Add(this.LinkC);
            this.panel1.Controls.Add(this.BtnE);
            this.panel1.Controls.Add(this.TxtEc);
            this.panel1.Controls.Add(this.labelEc);
            this.panel1.Controls.Add(this.TxtEu);
            this.panel1.Controls.Add(this.labelEu);
            this.panel1.Controls.Add(this.labelE);
            this.panel1.Controls.Add(this.BtnC);
            this.panel1.Controls.Add(this.TxtCc);
            this.panel1.Controls.Add(this.labelCc);
            this.panel1.Controls.Add(this.TxtCu);
            this.panel1.Controls.Add(this.labelCu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnCandidato);
            this.panel1.Controls.Add(this.BtnEvaluador);
            this.panel1.Controls.Add(this.BtnAdmin);
            this.panel1.Controls.Add(this.panelSuperior);
            this.panel1.Controls.Add(this.panelInferior);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 601);
            this.panel1.TabIndex = 0;
            // 
            // lblErrorC
            // 
            this.lblErrorC.AutoSize = true;
            this.lblErrorC.BackColor = System.Drawing.Color.White;
            this.lblErrorC.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorC.Image")));
            this.lblErrorC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorC.Location = new System.Drawing.Point(582, 371);
            this.lblErrorC.Name = "lblErrorC";
            this.lblErrorC.Size = new System.Drawing.Size(76, 13);
            this.lblErrorC.TabIndex = 22;
            this.lblErrorC.Text = "Error Mesagge";
            this.lblErrorC.Visible = false;
            // 
            // LinkC
            // 
            this.LinkC.AutoSize = true;
            this.LinkC.BackColor = System.Drawing.Color.White;
            this.LinkC.Location = new System.Drawing.Point(626, 449);
            this.LinkC.Name = "LinkC";
            this.LinkC.Size = new System.Drawing.Size(107, 13);
            this.LinkC.TabIndex = 21;
            this.LinkC.TabStop = true;
            this.LinkC.Text = "olvide mi contraseña!";
            this.LinkC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkC_LinkClicked);
            // 
            // BtnE
            // 
            this.BtnE.BackColor = System.Drawing.Color.Blue;
            this.BtnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnE.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnE.ForeColor = System.Drawing.Color.White;
            this.BtnE.Location = new System.Drawing.Point(264, 402);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(110, 35);
            this.BtnE.TabIndex = 20;
            this.BtnE.Text = "A EVALUAR!";
            this.BtnE.UseVisualStyleBackColor = false;
            // 
            // TxtEc
            // 
            this.TxtEc.Location = new System.Drawing.Point(226, 338);
            this.TxtEc.Name = "TxtEc";
            this.TxtEc.Size = new System.Drawing.Size(197, 20);
            this.TxtEc.TabIndex = 19;
            // 
            // labelEc
            // 
            this.labelEc.AutoSize = true;
            this.labelEc.BackColor = System.Drawing.Color.White;
            this.labelEc.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEc.Location = new System.Drawing.Point(223, 307);
            this.labelEc.Name = "labelEc";
            this.labelEc.Size = new System.Drawing.Size(76, 13);
            this.labelEc.TabIndex = 18;
            this.labelEc.Text = "CONTRASEÑA";
            // 
            // TxtEu
            // 
            this.TxtEu.Location = new System.Drawing.Point(226, 260);
            this.TxtEu.Name = "TxtEu";
            this.TxtEu.Size = new System.Drawing.Size(197, 20);
            this.TxtEu.TabIndex = 17;
            // 
            // labelEu
            // 
            this.labelEu.AutoSize = true;
            this.labelEu.BackColor = System.Drawing.Color.White;
            this.labelEu.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEu.Location = new System.Drawing.Point(223, 229);
            this.labelEu.Name = "labelEu";
            this.labelEu.Size = new System.Drawing.Size(52, 13);
            this.labelEu.TabIndex = 16;
            this.labelEu.Text = "USUARIO";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.BackColor = System.Drawing.Color.White;
            this.labelE.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.Color.Blue;
            this.labelE.Location = new System.Drawing.Point(221, 153);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(180, 25);
            this.labelE.TabIndex = 15;
            this.labelE.Text = "COMO EVALUADOR!";
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.Blue;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnC.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.ForeColor = System.Drawing.Color.White;
            this.BtnC.Location = new System.Drawing.Point(623, 402);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(110, 35);
            this.BtnC.TabIndex = 14;
            this.BtnC.Text = "A TRABAJAR!";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // TxtCc
            // 
            this.TxtCc.Location = new System.Drawing.Point(585, 338);
            this.TxtCc.Name = "TxtCc";
            this.TxtCc.Size = new System.Drawing.Size(197, 20);
            this.TxtCc.TabIndex = 13;
            // 
            // labelCc
            // 
            this.labelCc.AutoSize = true;
            this.labelCc.BackColor = System.Drawing.Color.White;
            this.labelCc.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCc.Location = new System.Drawing.Point(582, 307);
            this.labelCc.Name = "labelCc";
            this.labelCc.Size = new System.Drawing.Size(76, 13);
            this.labelCc.TabIndex = 12;
            this.labelCc.Text = "CONTRASEÑA";
            // 
            // TxtCu
            // 
            this.TxtCu.Location = new System.Drawing.Point(585, 260);
            this.TxtCu.Name = "TxtCu";
            this.TxtCu.Size = new System.Drawing.Size(197, 20);
            this.TxtCu.TabIndex = 11;
            // 
            // labelCu
            // 
            this.labelCu.AutoSize = true;
            this.labelCu.BackColor = System.Drawing.Color.White;
            this.labelCu.Font = new System.Drawing.Font("HP Simplified Hans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCu.Location = new System.Drawing.Point(582, 229);
            this.labelCu.Name = "labelCu";
            this.labelCu.Size = new System.Drawing.Size(52, 13);
            this.labelCu.TabIndex = 10;
            this.labelCu.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(580, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "COMO CANDIDATO!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "INICIE SESION!";
            // 
            // BtnCandidato
            // 
            this.BtnCandidato.BackColor = System.Drawing.Color.Navy;
            this.BtnCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCandidato.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCandidato.ForeColor = System.Drawing.Color.White;
            this.BtnCandidato.Location = new System.Drawing.Point(281, 219);
            this.BtnCandidato.Name = "BtnCandidato";
            this.BtnCandidato.Size = new System.Drawing.Size(125, 35);
            this.BtnCandidato.TabIndex = 7;
            this.BtnCandidato.Text = "CANDIDATO";
            this.BtnCandidato.UseVisualStyleBackColor = false;
            this.BtnCandidato.Click += new System.EventHandler(this.BtnCandidato_Click);
            // 
            // BtnEvaluador
            // 
            this.BtnEvaluador.BackColor = System.Drawing.Color.Navy;
            this.BtnEvaluador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEvaluador.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEvaluador.ForeColor = System.Drawing.Color.White;
            this.BtnEvaluador.Location = new System.Drawing.Point(281, 267);
            this.BtnEvaluador.Name = "BtnEvaluador";
            this.BtnEvaluador.Size = new System.Drawing.Size(125, 37);
            this.BtnEvaluador.TabIndex = 6;
            this.BtnEvaluador.Text = "EVALUADOR";
            this.BtnEvaluador.UseVisualStyleBackColor = false;
            this.BtnEvaluador.Click += new System.EventHandler(this.BtnEvaluador_Click_1);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Navy;
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdmin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Location = new System.Drawing.Point(281, 323);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(125, 35);
            this.BtnAdmin.TabIndex = 5;
            this.BtnAdmin.Text = "ADMINISTRADOR";
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 601);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Blue;
            this.panelSuperior.CornerRadius = 50;
            this.panelSuperior.Font = new System.Drawing.Font("Cambria Math", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSuperior.Location = new System.Drawing.Point(177, 84);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(333, 426);
            this.panelSuperior.TabIndex = 2;
            this.panelSuperior.Text = "ellipseControl2";
            this.panelSuperior.Click += new System.EventHandler(this.ellipseControl2_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.White;
            this.panelInferior.CornerRadius = 50;
            this.panelInferior.Location = new System.Drawing.Point(177, 84);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(666, 426);
            this.panelInferior.TabIndex = 1;
            this.panelInferior.Text = "ellipseControl1";
            this.panelInferior.Click += new System.EventHandler(this.panelInferior_Click);
            // 
            // ellipseComponent1
            // 
            this.ellipseComponent1.CornerRadius = 50;
            this.ellipseComponent1.TargetControl = null;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Components.EllipseComponent ellipseComponent1;
        private Controls.EllipseControl panelInferior;
        private Controls.EllipseControl panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnEvaluador;
        private System.Windows.Forms.Button BtnCandidato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCu;
        private System.Windows.Forms.TextBox TxtCc;
        private System.Windows.Forms.Label labelCc;
        private System.Windows.Forms.TextBox TxtCu;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnE;
        private System.Windows.Forms.TextBox TxtEc;
        private System.Windows.Forms.Label labelEc;
        private System.Windows.Forms.TextBox TxtEu;
        private System.Windows.Forms.Label labelEu;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.LinkLabel LinkC;
        private System.Windows.Forms.Label lblErrorC;
    }
}