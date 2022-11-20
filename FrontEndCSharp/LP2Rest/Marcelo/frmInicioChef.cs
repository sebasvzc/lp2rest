using LP2Rest.GestPersonasWS;
using LP2Rest.Gonzalo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmInicioChef : Form
    {
        private static Form formularioActivo = null;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private GestPersonasWS.asistencia _asistencia;
        private GestPersonasWS.GestPersonasWSClient _daoAsistencia;
        private GestPersonasWS.cuentaUsuario _cuenta;
        private int id_cuenta;

        int hh, mm, ss;
        private int idAsistencia = 0;
        public frmInicioChef()
        {
            InitializeComponent();
            _asistencia = new GestPersonasWS.asistencia();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
        }

        public frmInicioChef(GestPersonasWS.cuentaUsuario cuenta)
        {
            InitializeComponent();
            _asistencia = new GestPersonasWS.asistencia();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
            _cuenta = cuenta;
            lblID.Text = "Chef: " + cuenta.usuario;
            id_cuenta = cuenta.idUsuario;
        }

        private void pbPlatos_Click(object sender, EventArgs e)
        {
            label2.Text = "Platos";
            abrirFormulario(new frmListarPlatos(_cuenta));
        }

        private void pbInsumos_Click(object sender, EventArgs e)
        {
            label2.Text = "Insumos";
            abrirFormulario(new frmListarInsumosA());
        }

        private void pbSolicitudCompras_Click(object sender, EventArgs e)
        {
            label2.Text = "Compras";
            abrirFormulario(new frmSolicitudesCompras());
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
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
                _asistencia.idCuentaUsuario = id_cuenta;

                int resultadoInsercion = 0;

                resultadoInsercion = _daoAsistencia.insertarAsistencia(_asistencia);

                if (resultadoInsercion != 0)
                {
                    MessageBox.Show("Se registró exitosamente la asistencia");
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

        private void lblSalida_Click(object sender, EventArgs e)
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
                    btnRegistrarSalida.Hide();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la salida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }

        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            label3.Hide();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
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
