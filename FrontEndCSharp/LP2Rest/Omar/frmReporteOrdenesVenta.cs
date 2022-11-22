using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmReporteOrdenesVenta : Form
    {
        private byte[] arregloPDF;
        private ReporteWS.ReporteWSClient _daoReporte = new ReporteWS.ReporteWSClient();
        public frmReporteOrdenesVenta()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fecha_ini = new DateTime();
            DateTime fecha_fin = new DateTime();

            fecha_ini = dtpFechaInicio.Value;
            fecha_fin = dtpFechaFin.Value;

            arregloPDF = _daoReporte.generarReporteOrdenVentas(fecha_ini.ToString("yyyy-MM-dd"), fecha_fin.ToString("yyyy-MM-dd"));
            File.WriteAllBytes("temporal.pdf", arregloPDF);
            VisorPDFVentas.LoadFile("temporal.pdf");
            VisorPDFVentas.setShowToolbar(true);
        }
    }
}
