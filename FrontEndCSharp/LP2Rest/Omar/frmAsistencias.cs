using LP2Rest.Gonzalo;
using LP2Rest.Omar;
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
    public partial class frmAsistencias : Form
    {
        private byte[] arregloPDF;
        private ReporteWS.ReporteWSClient _daoReporte = new ReporteWS.ReporteWSClient();
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
        private GestPersonasWS.empleado _empleado;

        public frmAsistencias()
        {
            InitializeComponent();
            _empleado = new GestPersonasWS.empleado();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fecha_ini = new DateTime();
            DateTime fecha_fin = new DateTime();

            fecha_ini = dtpFechaInicio.Value;
            fecha_fin = dtpFechaFin.Value;
            
            arregloPDF = _daoReporte.generarReporteAsistencia(_empleado.idPersona, fecha_ini.ToString("yyyy-MM-dd"), fecha_fin.ToString("yyyy-MM-dd"));
            File.WriteAllBytes("temporal.pdf", arregloPDF);
            visorPDF.LoadFile("temporal.pdf");
            visorPDF.setShowToolbar(true);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscarEmpleado formBuscarEmpleado = new frmBuscarEmpleado();
            if (formBuscarEmpleado.ShowDialog() == DialogResult.OK)
            {
                _empleado.idPersona = formBuscarEmpleado.EmpleadoSeleccionado.idPersona;
                _empleado.nombre = formBuscarEmpleado.EmpleadoSeleccionado.nombre;
                _empleado.apellidoPaterno = formBuscarEmpleado.EmpleadoSeleccionado.apellidoPaterno;
                txtNombre.Text = _empleado.nombre + " " + _empleado.apellidoPaterno;
            }
        }

    }
}
