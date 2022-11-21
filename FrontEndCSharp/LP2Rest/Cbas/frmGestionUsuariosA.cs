using LP2Rest.GestPersonasWS;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string _rutaFoto;
        private string _rutaArchivoPDF;
        private byte[] _archivoPDF;
        private byte[] _foto;
        private GestPersonasWS.empleado _empleado;
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
            int resultado = 0;
            char tipoEmpleado;
            if (cboArea.SelectedItem.ToString() == "Administrador")
            {
                _empleado = new GestPersonasWS.administrador();
                _empleado.DNI = txtDNI.Text;
                _empleado.nombre = txtNombre.Text;
                _empleado.apellidoPaterno = txtApellidoPaterno.Text;
                _empleado.email = txtEmail.Text;
                _empleado.direccion = txtDireccion.Text;
                _empleado.telefono = txtTelefono.Text;
                _empleado.sueldo = Double.Parse(txtSueldo.Text);
                _empleado.fechaContratacion = dtpFechaContratacion.Value;
                _empleado.fechaContratacionSpecified = true;
                _empleado.fechaNacimiento = dtpFechaContratacion.Value;
                _empleado.fechaNacimientoSpecified = true;
                _empleado.numeroHorasMensuales = 0;
                _empleado.activo = true;
                _empleado.foto = _foto;
                _empleado.archivoCv = _archivoPDF;
                resultado = daoGestPersonas.InsertarAdministrador((administrador)_empleado);
                tipoEmpleado = 'A';

            }
            else if (cboArea.SelectedItem.ToString() == "Cajero")
            {
                _empleado = new GestPersonasWS.cajero();
                _empleado.DNI = txtDNI.Text;
                _empleado.nombre = txtNombre.Text;
                _empleado.apellidoPaterno = txtApellidoPaterno.Text;
                _empleado.email = txtEmail.Text;
                _empleado.direccion = txtDireccion.Text;
                _empleado.telefono = txtTelefono.Text;
                _empleado.sueldo = Double.Parse(txtSueldo.Text);
                _empleado.fechaContratacion = dtpFechaContratacion.Value;
                _empleado.fechaContratacionSpecified = true;
                _empleado.fechaNacimiento = dtpFechaContratacion.Value;
                _empleado.fechaNacimientoSpecified = true;
                _empleado.numeroHorasMensuales = 0;
                _empleado.activo = true;
                _empleado.foto = _foto;
                _empleado.archivoCv = _archivoPDF;
                resultado = daoGestPersonas.InsertarCajero((cajero)_empleado);
                tipoEmpleado = 'C';
            }
            else if (cboArea.SelectedItem.ToString() == "Mesero")
            {
                _empleado = new GestPersonasWS.mesero();
                _empleado.DNI = txtDNI.Text;
                _empleado.nombre = txtNombre.Text;
                _empleado.apellidoPaterno = txtApellidoPaterno.Text;
                _empleado.email = txtEmail.Text;
                _empleado.direccion = txtDireccion.Text;
                _empleado.telefono = txtTelefono.Text;
                _empleado.sueldo = Double.Parse(txtSueldo.Text);
                _empleado.fechaContratacion = dtpFechaContratacion.Value;
                _empleado.fechaContratacionSpecified = true;
                _empleado.fechaNacimiento = dtpFechaContratacion.Value;
                _empleado.fechaNacimientoSpecified = true;
                _empleado.numeroHorasMensuales = 0;
                _empleado.activo = true;
                _empleado.foto = _foto;
                _empleado.archivoCv = _archivoPDF;
                resultado = daoGestPersonas.InsertarMesero((mesero)_empleado);
                tipoEmpleado = 'M';
            }
            else if (cboArea.SelectedItem.ToString() == "Chef")
            {
                _empleado = new GestPersonasWS.chef();
                _empleado.DNI = txtDNI.Text;
                _empleado.nombre = txtNombre.Text;
                _empleado.apellidoPaterno = txtApellidoPaterno.Text;
                _empleado.email = txtEmail.Text;
                _empleado.direccion = txtDireccion.Text;
                _empleado.telefono = txtTelefono.Text;
                _empleado.sueldo = Double.Parse(txtSueldo.Text);
                _empleado.fechaContratacion = dtpFechaContratacion.Value;
                _empleado.fechaContratacionSpecified = true;
                _empleado.fechaNacimiento = dtpFechaContratacion.Value;
                _empleado.fechaNacimientoSpecified = true;
                _empleado.numeroHorasMensuales = 0;
                _empleado.activo = true;
                _empleado.foto = _foto;
                _empleado.archivoCv = _archivoPDF;
                resultado = daoGestPersonas.InsertarChef((chef)_empleado);
                tipoEmpleado = 'F';
            }
            else
            {
                _empleado = new GestPersonasWS.recepcionista();
                _empleado.DNI = txtDNI.Text;
                _empleado.nombre = txtNombre.Text;
                _empleado.apellidoPaterno = txtApellidoPaterno.Text;
                _empleado.email = txtEmail.Text;
                _empleado.direccion = txtDireccion.Text;
                _empleado.telefono = txtTelefono.Text;
                _empleado.sueldo = Double.Parse(txtSueldo.Text);
                _empleado.fechaContratacion = dtpFechaContratacion.Value;
                _empleado.fechaContratacionSpecified = true;
                _empleado.fechaNacimiento = dtpFechaContratacion.Value;
                _empleado.fechaNacimientoSpecified = true;
                _empleado.numeroHorasMensuales = 0;
                _empleado.activo = true;
                _empleado.foto = _foto;
                _empleado.archivoCv = _archivoPDF;
                resultado = daoGestPersonas.InsertarRecepcionista((recepcionista)_empleado);
                tipoEmpleado = 'R';
            }

            GestPersonasWS.cuentaUsuario cuentaUsuario = new GestPersonasWS.cuentaUsuario();
            cuentaUsuario.usuario = _empleado.nombre.Substring(0, 1).ToLower() +
                    _empleado.apellidoPaterno.ToLower();
            cuentaUsuario.contrasenia = "123456";
            cuentaUsuario.activo = true;
            cuentaUsuario.idUsuario = resultado;
            cuentaUsuario.empleado = _empleado;
            cuentaUsuario.tipoEmpleado = tipoEmpleado;
            daoGestPersonas.InsertarCuentaUsuario(cuentaUsuario);
            _empleado.cuentaUsuario = cuentaUsuario;

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

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _foto = br.ReadBytes((int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnAdjuntarCV_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdArchivo = new OpenFileDialog();
            try
            {
                if (ofdArchivo.ShowDialog() == DialogResult.OK)
                {
                    _rutaArchivoPDF = ofdArchivo.FileName;
                    //txtRutaArchivo.Text = _rutaArchivoPDF;
                    FileStream fs = new FileStream(_rutaArchivoPDF, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    //Asignamos el archivo al objeto
                    _archivoPDF = br.ReadBytes((int)fs.Length);

                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al seleccionar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDescargarCV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdArchivo = new SaveFileDialog();
            if (sfdArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdArchivo.FileName;
                    //Convertimos el arreglo de Bytes a archivo
                    File.WriteAllBytes(archivoGenerar, _empleado.archivoCv);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
