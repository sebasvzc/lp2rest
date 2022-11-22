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

namespace LP2Rest.Gonzalo
{
    public partial class frmGenerarBoletaVenta : Form
    {
        private byte[] arregloPDF;
        private ReporteWS.ReporteWSClient _daoReporte = new ReporteWS.ReporteWSClient();
        public frmGenerarBoletaVenta(int id_ordenVenta)
        {
            InitializeComponent();

           

            arregloPDF = _daoReporte.generarBoletaVenta(id_ordenVenta);
            File.WriteAllBytes("boletaVenta.pdf", arregloPDF);
            VisorPDFBoleta.LoadFile("boletaVenta.pdf");
            VisorPDFBoleta.setShowToolbar(true);


        }
    }
}
