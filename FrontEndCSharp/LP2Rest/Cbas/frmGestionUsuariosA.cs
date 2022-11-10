using LP2Rest.GestPersonasWS;
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
    public partial class frmGestionUsuariosA : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public frmGestionUsuariosA()
        {
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            GestPersonasWS.empleado empleado;
            int resultado = 0;
            char tipoEmpleado;
            if (cboArea.SelectedItem.ToString() == "Administrador")
            {
                empleado = new GestPersonasWS.administrador();
                empleado.DNI = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApellidoPaterno.Text;
                empleado.email = txtEmail.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.sueldo = Double.Parse(txtSueldo.Text);
                empleado.fechaContratacion = dtpFechaContratacion.Value;
                empleado.fechaContratacionSpecified = true;
                empleado.fechaNacimiento = dtpFechaContratacion.Value;
                empleado.fechaNacimientoSpecified = true;
                empleado.numeroHorasMensuales = 0;
                empleado.activo = true;
                resultado = daoGestPersonas.InsertarAdministrador((administrador)empleado);
                tipoEmpleado = 'A';

            }
            else if (cboArea.SelectedItem.ToString() == "Cajero")
            {
                empleado = new GestPersonasWS.cajero();
                empleado.DNI = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApellidoPaterno.Text;
                empleado.email = txtEmail.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.sueldo = Double.Parse(txtSueldo.Text);
                empleado.fechaContratacion = dtpFechaContratacion.Value;
                empleado.fechaContratacionSpecified = true;
                empleado.fechaNacimiento = dtpFechaContratacion.Value;
                empleado.fechaNacimientoSpecified = true;
                empleado.numeroHorasMensuales = 0;
                empleado.activo = true;
                resultado = daoGestPersonas.InsertarCajero((cajero)empleado);
                tipoEmpleado = 'C';
            }
            else if (cboArea.SelectedItem.ToString() == "Mesero")
            {
                empleado = new GestPersonasWS.mesero();
                empleado.DNI = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApellidoPaterno.Text;
                empleado.email = txtEmail.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.sueldo = Double.Parse(txtSueldo.Text);
                empleado.fechaContratacion = dtpFechaContratacion.Value;
                empleado.fechaContratacionSpecified = true;
                empleado.fechaNacimiento = dtpFechaContratacion.Value;
                empleado.fechaNacimientoSpecified = true;
                empleado.numeroHorasMensuales = 0;
                empleado.activo = true;
                resultado = daoGestPersonas.InsertarMesero((mesero)empleado);
                tipoEmpleado = 'M';
            }
            else if (cboArea.SelectedItem.ToString() == "Chef")
            {
                empleado = new GestPersonasWS.chef();
                empleado.DNI = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApellidoPaterno.Text;
                empleado.email = txtEmail.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.sueldo = Double.Parse(txtSueldo.Text);
                empleado.fechaContratacion = dtpFechaContratacion.Value;
                empleado.fechaContratacionSpecified = true;
                empleado.fechaNacimiento = dtpFechaContratacion.Value;
                empleado.fechaNacimientoSpecified = true;
                empleado.numeroHorasMensuales = 0;
                empleado.activo = true;
                resultado = daoGestPersonas.InsertarChef((chef)empleado);
                tipoEmpleado = 'F';
            }
            else
            {
                empleado = new GestPersonasWS.recepcionista();
                empleado.DNI = txtDNI.Text;
                empleado.nombre = txtNombre.Text;
                empleado.apellidoPaterno = txtApellidoPaterno.Text;
                empleado.email = txtEmail.Text;
                empleado.direccion = txtDireccion.Text;
                empleado.telefono = txtTelefono.Text;
                empleado.sueldo = Double.Parse(txtSueldo.Text);
                empleado.fechaContratacion = dtpFechaContratacion.Value;
                empleado.fechaContratacionSpecified = true;
                empleado.fechaNacimiento = dtpFechaContratacion.Value;
                empleado.fechaNacimientoSpecified = true;
                empleado.numeroHorasMensuales = 0;
                empleado.activo = true;
                resultado = daoGestPersonas.InsertarRecepcionista((recepcionista)empleado);
                tipoEmpleado = 'R';
            }

            GestPersonasWS.cuentaUsuario cuentaUsuario = new GestPersonasWS.cuentaUsuario();
            cuentaUsuario.usuario = empleado.nombre.Substring(0, 1).ToLower() +
                    empleado.apellidoPaterno.ToLower();
            cuentaUsuario.contrasenia = "123456";
            cuentaUsuario.activo = true;
            cuentaUsuario.idUsuario = resultado;
            cuentaUsuario.empleado = empleado;
            cuentaUsuario.tipoEmpleado = tipoEmpleado;
            daoGestPersonas.InsertarCuentaUsuario(cuentaUsuario);
            empleado.cuentaUsuario = cuentaUsuario;

            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado el empleado con exito");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }

        }
    }
}
