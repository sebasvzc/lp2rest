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
        public frmListarReportesA()
        {
            InitializeComponent();
        }

        private void btnCrearReporteAsistencias_Click(object sender, EventArgs e)
        {
            frmAsistencias formAsistencias = new frmAsistencias();
            if (formAsistencias.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnCrearReporteVentas_Click(object sender, EventArgs e)
        {
            frmReporteOrdenesVenta formReporteVentas = new frmReporteOrdenesVenta();
            if (formReporteVentas.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnCrearReportePlatos_Click(object sender, EventArgs e)
        {
            frmReportePlatos formReportePlatos = new frmReportePlatos();
            if (formReportePlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
