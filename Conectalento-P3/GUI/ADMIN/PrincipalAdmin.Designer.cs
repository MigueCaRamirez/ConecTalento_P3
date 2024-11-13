namespace GUI
{
    partial class PrincipalAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.NuevoPuesto = new System.Windows.Forms.Button();
            this.GestionarCandidato = new System.Windows.Forms.Button();
            this.HistorialEvaluacion = new System.Windows.Forms.Button();
            this.VerEstadistica = new System.Windows.Forms.Button();
            this.EnviarMensaje = new System.Windows.Forms.Button();
            this.VerMas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.VerMas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 692);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(252, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 100);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(407, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "PUESTOS DISPONIBLES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "PANEL DE ADMINISTRADOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.CerrarSesion);
            this.panel1.Controls.Add(this.NuevoPuesto);
            this.panel1.Controls.Add(this.GestionarCandidato);
            this.panel1.Controls.Add(this.HistorialEvaluacion);
            this.panel1.Controls.Add(this.VerEstadistica);
            this.panel1.Controls.Add(this.EnviarMensaje);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 692);
            this.panel1.TabIndex = 12;
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Location = new System.Drawing.Point(39, 610);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(133, 58);
            this.CerrarSesion.TabIndex = 5;
            this.CerrarSesion.Text = "Cerrar Sesion";
            this.CerrarSesion.UseVisualStyleBackColor = true;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // NuevoPuesto
            // 
            this.NuevoPuesto.Location = new System.Drawing.Point(39, 179);
            this.NuevoPuesto.Name = "NuevoPuesto";
            this.NuevoPuesto.Size = new System.Drawing.Size(158, 55);
            this.NuevoPuesto.TabIndex = 0;
            this.NuevoPuesto.Text = "Crear Nuevo Puesto";
            this.NuevoPuesto.UseVisualStyleBackColor = true;
            this.NuevoPuesto.Click += new System.EventHandler(this.NuevoPuesto_Click);
            // 
            // GestionarCandidato
            // 
            this.GestionarCandidato.Location = new System.Drawing.Point(39, 257);
            this.GestionarCandidato.Name = "GestionarCandidato";
            this.GestionarCandidato.Size = new System.Drawing.Size(158, 55);
            this.GestionarCandidato.TabIndex = 1;
            this.GestionarCandidato.Text = "Gestionar Candidatos";
            this.GestionarCandidato.UseVisualStyleBackColor = true;
            this.GestionarCandidato.Click += new System.EventHandler(this.GestionarCandidato_Click);
            // 
            // HistorialEvaluacion
            // 
            this.HistorialEvaluacion.Location = new System.Drawing.Point(39, 338);
            this.HistorialEvaluacion.Name = "HistorialEvaluacion";
            this.HistorialEvaluacion.Size = new System.Drawing.Size(158, 55);
            this.HistorialEvaluacion.TabIndex = 3;
            this.HistorialEvaluacion.Text = "Historial de Evaluaciones";
            this.HistorialEvaluacion.UseVisualStyleBackColor = true;
            // 
            // VerEstadistica
            // 
            this.VerEstadistica.Location = new System.Drawing.Point(39, 421);
            this.VerEstadistica.Name = "VerEstadistica";
            this.VerEstadistica.Size = new System.Drawing.Size(158, 55);
            this.VerEstadistica.TabIndex = 2;
            this.VerEstadistica.Text = "Ver Estadísticas";
            this.VerEstadistica.UseVisualStyleBackColor = true;
            // 
            // EnviarMensaje
            // 
            this.EnviarMensaje.Location = new System.Drawing.Point(39, 507);
            this.EnviarMensaje.Name = "EnviarMensaje";
            this.EnviarMensaje.Size = new System.Drawing.Size(158, 55);
            this.EnviarMensaje.TabIndex = 4;
            this.EnviarMensaje.Text = "Enviar Mensaje a Candidatos";
            this.EnviarMensaje.UseVisualStyleBackColor = true;
            // 
            // VerMas
            // 
            this.VerMas.Location = new System.Drawing.Point(1108, 586);
            this.VerMas.Name = "VerMas";
            this.VerMas.Size = new System.Drawing.Size(86, 58);
            this.VerMas.TabIndex = 11;
            this.VerMas.Text = "Ver Más";
            this.VerMas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1061, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CANDIDATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "PUESTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 309);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESTADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 692);
            this.Controls.Add(this.groupBox1);
            this.Name = "PrincipalAdmin";
            this.Text = "AdminOptions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VerMas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button EnviarMensaje;
        private System.Windows.Forms.Button HistorialEvaluacion;
        private System.Windows.Forms.Button VerEstadistica;
        private System.Windows.Forms.Button GestionarCandidato;
        private System.Windows.Forms.Button NuevoPuesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}