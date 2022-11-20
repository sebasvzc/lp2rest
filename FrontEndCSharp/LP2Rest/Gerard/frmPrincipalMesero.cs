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
using cuentaUsuario = LP2Rest.GestPersonasWS.cuentaUsuario;
using mesero = LP2Rest.GestPersonasWS.mesero;

namespace LP2Rest
{
    public partial class frmPrincipalMesero : Form
    {
        private static Form formularioActivo = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        //Utiles
        private mesero meseroSeleccionado;
        private GestPersonasWS.asistencia _asistencia;
        private int cuentaUsuario;
        private GestPersonasWS.GestPersonasWSClient _daoAsistencia;
        private int cuentaUser = 0;

        int hh, mm, ss;
        private int idAsistencia = 0;
        public mesero MeseroSeleccionado { get => meseroSeleccionado; set => meseroSeleccionado = value; }

        public frmPrincipalMesero(cuentaUsuario auxCuentaUsuario)
        {
            meseroSeleccionado = new mesero();
            meseroSeleccionado.idPersona = auxCuentaUsuario.empleado.idPersona;
            meseroSeleccionado.nombre = auxCuentaUsuario.empleado.nombre;
            meseroSeleccionado.apellidoPaterno = auxCuentaUsuario.empleado.apellidoPaterno;
            InitializeComponent();
            _asistencia = new GestPersonasWS.asistencia();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
            lblID.Text = "Mesero #"+ meseroSeleccionado.idPersona.ToString();
            label1.Text = "Bienvenido " + meseroSeleccionado.nombre + " " + meseroSeleccionado.apellidoPaterno;
            cuentaUsuario = meseroSeleccionado.idPersona;
            cuentaUser = auxCuentaUsuario.idUsuario;
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if(formularioActivo != null)
                formularioActivo.Close();
            label1.Hide();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();

        }
        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            frmMesas formMesas = new frmMesas(meseroSeleccionado.idPersona);
            formMesas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
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
                _asistencia.idCuentaUsuario = cuentaUser;

                MessageBox.Show("Se registró la asistencia");
                btnMarcarAsistencia.Hide();
                //btnRegistrarSalida.Show();

            }
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmListarOrdenesVentaA formListaOrdenVenta = new frmListarOrdenesVentaA();
            formListaOrdenVenta.ShowDialog();
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            btnAsistencia_Click( sender,  e);
        }

        private void imgPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            formListarPlatos.ShowDialog();
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListaOrdenVentaMesero(meseroSeleccionado.idPersona));
        }

        private void sdbtnPlatos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarPlatos());
        }

        private void sdbtnMesas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmMesas(meseroSeleccionado.idPersona));
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void btnMarcarAsistencia_Click(object sender, EventArgs e)
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
                _asistencia.idCuentaUsuario = cuentaUser;

                int resultadoInsercion = 0;

                resultadoInsercion = _daoAsistencia.insertarAsistencia(_asistencia);

                if (resultadoInsercion != 0)
                {
                    MessageBox.Show("Se registró exitosamente la asistencia");
                    btnMarcarAsistencia.Hide();
                    btnMarcarSalida.Show();
                    timer1.Start();
                    idAsistencia = resultadoInsercion;


                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la asistencia", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
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

                timer1.Stop();


                resultadoInsercion = _daoAsistencia.modificarAsistenciaSalida(idAsistencia,
                    _asistencia.fechaSalida, _asistencia.horaSalida);
                if (resultadoInsercion != 0)
                {
                    MessageBox.Show("Se registró exitosamente la salida");
                    btnMarcarSalida.Hide();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la salida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        private void sdbtnReclamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReclamosA());
        }

        private void sdbtnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmBusquedaCliente());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lbltimer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

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
