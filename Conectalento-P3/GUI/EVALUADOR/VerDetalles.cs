using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.EVALUADOR
{
    public partial class VerDetalles : Form
    {
        public VerDetalles()
        {
            InitializeComponent();
        }

        private void btnVerCV_Click(object sender, EventArgs e)
        {
            string rutaPDF = @"C:\ruta\del\archivo.pdf"; // Especifica la ruta de tu archivo PDF aquí
            Process.Start(rutaPDF);
        }
    }
}
