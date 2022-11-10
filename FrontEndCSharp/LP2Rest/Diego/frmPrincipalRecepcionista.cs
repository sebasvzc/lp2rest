using LP2Rest.Gonzalo;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmPrincipalRecepcionista : Form
    {
        private static Form formularioActivo = null;
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private GestPersonasWS.asistencia _asistencia;
        private GestPersonasWS.GestPersonasWSClient _daoAsistencia;
        public frmPrincipalRecepcionista()
        {
            InitializeComponent();
            btnMarcarSalida.Hide();
            _asistencia = new GestPersonasWS.asistencia();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();


        }
        
        public void abrirFormulario(Form formularioMostrar)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();

        }

        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionClientes formGestionClientes = new frmGestionClientes();
            formGestionClientes.ShowDialog();
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmGestionReservas frmGestionReservas = new frmGestionReservas();
            frmGestionReservas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            pbAsistencia_Click(sender, e);
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


                //Se asume (momentaneamente) que el admin tiene idCuentaUsuario = 2 
                _asistencia.idCuentaUsuario = 2;

                MessageBox.Show("Se registró la asistencia");
                btnMarcarAsistencia.Hide();
                btnMarcarSalida.Show();

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


                resultadoInsercion = _daoAsistencia.insertarAsistencia(_asistencia);
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void sdbtnReclamos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListarReclamosA());
        }

        private void sdbtnReservas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmGestionReservas());
        }
    }
}
