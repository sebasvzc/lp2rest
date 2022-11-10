using LP2Rest;
using LP2Rest.GestPersonasWS;
using LP2Rest.Gonzalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmPrincipalA : Form
    {
        private static Form formularioActivo = null;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private GestPersonasWS.GestPersonasWSClient _daoAsistencia;
        private GestPersonasWS.asistencia _asistencia;
        public frmPrincipalA()
        {
            InitializeComponent();
            btnRegistrarSalida.Hide();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
            _asistencia = new GestPersonasWS.asistencia();
        }

        public frmPrincipalA(GestPersonasWS.cuentaUsuario cuenta)
        {
            InitializeComponent();
            btnRegistrarSalida.Hide();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
            _asistencia = new GestPersonasWS.asistencia();
            lblID.Text = "Administrador: " + cuenta.usuario;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesCompra());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarEventosA());
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarPlatos());
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarInsumosA());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarOrdenesVentaA());
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReclamosA());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReportesA());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarUsuariosA());
        }

        private void sdbtnUsuarios_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Usuarios";
            abrirFormulario(new frmListarUsuariosA());
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Ventas";
            abrirFormulario(new frmListarOrdenesVentaA());
        }

        private void sdbtnEventos_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Eventos";
            abrirFormulario(new frmListarEventosA());
        }

        private void sdbtnReportes_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Reportes";
            abrirFormulario(new frmListarReportesA());
        }

        private void sdbtnInsumos_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Insumos";
            abrirFormulario(new frmListarInsumosA());
        }

        private void sdbtnCompras_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Compras";
            abrirFormulario(new frmSolicitudesCompras());
        }

        private void sdbtnReclamos_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Reclamos";
            abrirFormulario(new frmListarReclamosA());
        }

        private void sdbtnPlatos_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Platos";
            abrirFormulario(new frmListarPlatos());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            pbAsistencia_Click(sender, e);
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {
            string resultado = "";
            frmValidarAsistencia formValidarAsistencia = new frmValidarAsistencia();
            if (formValidarAsistencia.ShowDialog() == DialogResult.OK)
            {

                resultado = formValidarAsistencia.Estado;
            }
            if (resultado == "Aceptado")
            {
                //Insertar la asistencia
                DateTime ingreso = DateTime.Now;

                string date_str = ingreso.ToString("yyyy/MM/dd");
                string hora_str = ingreso.ToString("HH:mm:ss");
                _asistencia.fechaIngreso = date_str;
                _asistencia.horaIngreso = hora_str;


                //Se asume (momentaneamente) que el admin tiene idCuentaUsuario = 2 
                _asistencia.idCuentaUsuario = 2;

                MessageBox.Show("Se registró la asistencia");
                btnMarcarAsistencia.Hide();
                btnRegistrarSalida.Show();

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
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

        private void lbltitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnRegistrarSalida_Click(object sender, EventArgs e)
        {
            string resultado = "";
            frmValidarAsistencia formValidarAsistencia = new frmValidarAsistencia();
            if (formValidarAsistencia.ShowDialog() == DialogResult.OK)
            {
                resultado = formValidarAsistencia.Estado;
            }
            if (resultado == "Aceptado")
            {
                //Insertar la fecha de registro

                //Se registra el empleado utilizando el DAO de conexión

                int resultadoInsercion = 0;
                // Para registrar la salida
                DateTime salida = DateTime.Now;

                string date_str = salida.ToString("yyyy/MM/dd");
                string hora_str = salida.ToString("HH:mm:ss");
                _asistencia.fechaSalida = date_str;
                _asistencia.horaSalida = hora_str;


                resultadoInsercion = _daoAsistencia.insertarAsistencia(_asistencia);
                if (resultadoInsercion != 0)
                {
                    MessageBox.Show("Se registró exitosamente la salida");
                    btnRegistrarSalida.Hide();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la salida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }
    }
}
