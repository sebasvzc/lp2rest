using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmListarReportesA : Form
    {
        private static Form formularioActivo = null;
        public frmListarReportesA()
        {
            InitializeComponent();
        }

        private void btnCrearReporteAsistencias_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmAsistencias());
        }

        private void btnCrearReporteVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmReporteOrdenesVenta());
        }

        private void btnCrearReportePlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmReportePlatos());
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            label1.Hide();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }
    }
}
