using LP2Rest;
using LP2Rest.GestPersonasWS;
using LP2Rest.Gonzalo;
using LP2Rest.VentasWS;
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

        private GestPersonasWS.GestPersonasWSClient _daoGestPersonasWS;
        private GestPersonasWS.asistencia _asistencia;
        private GestPersonasWS.empleado _empleado;
        private bool registroAsistencia=false;
        private bool registroSalida = false;
        private int id_cuentaEscogida;
        int hh, mm, ss;
        private int idAsistencia = 0;
        public frmPrincipalA()
        {
            InitializeComponent();
            btnRegistrarSalida.Hide();
            _daoGestPersonasWS = new GestPersonasWS.GestPersonasWSClient();
            _asistencia = new GestPersonasWS.asistencia();
        }

        public frmPrincipalA(GestPersonasWS.cuentaUsuario cuenta)
        {
            InitializeComponent();
            btnRegistrarSalida.Hide();
            _daoGestPersonasWS = new GestPersonasWS.GestPersonasWSClient();
            _asistencia = new GestPersonasWS.asistencia();
            _empleado = _daoGestPersonasWS.buscarXidCuentaUsuario(cuenta.idUsuario);

            lblID.Text = "Administrador: " + cuenta.usuario;
            id_cuentaEscogida = cuenta.idUsuario;
            label1.Text = "¡Buenos días, " + _empleado.nombre + " " + _empleado.apellidoPaterno + "!\n\n"
                        + "Por favor no olvide registrar su asistencia\n"
                        + "haciendo click botón superior.";
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
            abrirFormulario(new frmListarUsuariosA(false));
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Ventas";
            abrirFormulario(new frmListarOrdenesVentaA(false));
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
            abrirFormulario(new frmListarInsumosA(false));
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
            if(registroSalida == false)
                btnRegistrarSalida_Click(sender, e);
            this.Close();
        }

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
        {
            registroAsistencia = true;
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

               
                _asistencia.fechaSalida = date_str;
                _asistencia.horaSalida = hora_str; // Por defecto se pone como hora de salida la misma hora
                //Claramente la hora de salida se terminará modificando



                //Se asume (momentaneamente) que el admin tiene idCuentaUsuario = 2 
                _asistencia.idCuentaUsuario = id_cuentaEscogida;

                int resultadoInsercion = 0;
                
                resultadoInsercion = _daoGestPersonasWS.insertarAsistencia(_asistencia);
                
                if (resultadoInsercion != 0)
                {
                    btnMarcarAsistencia.Hide();
                    btnRegistrarSalida.Show();
                    timer1.Start();
                    idAsistencia = resultadoInsercion;


                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la asistencia", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (registroSalida == false)
                btnRegistrarSalida_Click(sender, e);
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
            if (registroAsistencia) { 
                string resultado = "";
                registroSalida = true;
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

                    timer1.Stop();


                    resultadoInsercion = _daoGestPersonasWS.modificarAsistenciaSalida(idAsistencia,
                        _asistencia.fechaSalida, _asistencia.horaSalida);
                    if (resultadoInsercion != 0)
                    {
                        btnRegistrarSalida.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al momento de registrar la salida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            ss++;
            if (ss > 60)
            {
                mm++;
                ss = 0;
            }
            if (mm > 60)
            {
                hh++;
                mm = 0;
            }
            string hrs, min, sec;
            if (ss < 10)
                sec = $"0{ss}";
            else
                sec = ss.ToString();
            if (mm < 10)
                min = $"0{mm}";
            else
                min = mm.ToString();
            if (hh < 10)
                hrs = $"0{hh}";
            else
                hrs = hh.ToString();
            lbltimer.Text = $"{hrs}:{min}:{sec}";
        }

        
    }
}
