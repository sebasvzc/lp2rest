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
using System.Windows.Forms.VisualStyles;

namespace LP2Rest
{
    public partial class frmGestionUsuariosA : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        private string _rutaFoto;
        private string _rutaArchivoPDF;
        private byte[] _archivoPDF;
        private byte[] _foto;
        private GestPersonasWS.empleado _empleadoSeleccionado;
        private int _accion = 0;

        public empleado EmpleadoSeleccionado { get => _empleadoSeleccionado; set => _empleadoSeleccionado = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public frmGestionUsuariosA()
        {
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            InitializeComponent();

        }
        public frmGestionUsuariosA(GestPersonasWS.empleado emp)
        {
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            InitializeComponent();
            _empleadoSeleccionado = emp;
            _accion = 1;
            if (_empleadoSeleccionado != null)
            {

                txtNombre.Text = _empleadoSeleccionado.nombre;
                txtApellidoPaterno.Text = _empleadoSeleccionado.apellidoPaterno;
                txtDNI.Text = _empleadoSeleccionado.DNI;
                txtDireccion.Text = _empleadoSeleccionado.direccion;
                txtTelefono.Text = _empleadoSeleccionado.telefono;
                txtEmail.Text = _empleadoSeleccionado.email;
                if (_empleadoSeleccionado is administrador)
                {
                    cboArea.SelectedIndex = 0;
                }
                else if (_empleadoSeleccionado is mesero)
                {
                    cboArea.SelectedIndex = 1;
                }
                else if (_empleadoSeleccionado is chef)
                {
                    cboArea.SelectedIndex = 4;

                }
                else if (_empleadoSeleccionado is recepcionista)
                {
                    cboArea.SelectedIndex = 3;
                }
                else
                {
                    cboArea.SelectedIndex = 2;

                }

                txtSueldo.Text = _empleadoSeleccionado.sueldo.ToString();
                txtID.Text = _empleadoSeleccionado.idPersona.ToString();
                if (_empleadoSeleccionado.foto != null)
                {
                    MemoryStream ms = new MemoryStream(_empleadoSeleccionado.foto);
                    pbFoto.Image = new Bitmap(ms);
                }
            }
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
                EmpleadoSeleccionado = new GestPersonasWS.administrador();
                EmpleadoSeleccionado.DNI = txtDNI.Text;
                EmpleadoSeleccionado.nombre = txtNombre.Text;
                EmpleadoSeleccionado.apellidoPaterno = txtApellidoPaterno.Text;
                EmpleadoSeleccionado.email = txtEmail.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.telefono = txtTelefono.Text;
                EmpleadoSeleccionado.sueldo = Double.Parse(txtSueldo.Text);
                EmpleadoSeleccionado.fechaContratacion = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaContratacionSpecified = true;
                EmpleadoSeleccionado.fechaNacimiento = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaNacimientoSpecified = true;
                EmpleadoSeleccionado.numeroHorasMensuales = 0;
                EmpleadoSeleccionado.activo = true;
                EmpleadoSeleccionado.foto = _foto;
                EmpleadoSeleccionado.archivoCv = _archivoPDF;
                if (_accion == 0)
                    resultado = daoGestPersonas.InsertarAdministrador((administrador)EmpleadoSeleccionado);
                else
                {
                    EmpleadoSeleccionado.idPersona = Int32.Parse(txtID.Text);
                    resultado = daoGestPersonas.ModificarAdministrador((administrador)EmpleadoSeleccionado);
                }
                tipoEmpleado = 'A';

            }
            else if (cboArea.SelectedItem.ToString() == "Cajero")
            {
                EmpleadoSeleccionado = new GestPersonasWS.cajero();
                EmpleadoSeleccionado.DNI = txtDNI.Text;
                EmpleadoSeleccionado.nombre = txtNombre.Text;
                EmpleadoSeleccionado.apellidoPaterno = txtApellidoPaterno.Text;
                EmpleadoSeleccionado.email = txtEmail.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.telefono = txtTelefono.Text;
                EmpleadoSeleccionado.sueldo = Double.Parse(txtSueldo.Text);
                EmpleadoSeleccionado.fechaContratacion = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaContratacionSpecified = true;
                EmpleadoSeleccionado.fechaNacimiento = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaNacimientoSpecified = true;
                EmpleadoSeleccionado.numeroHorasMensuales = 0;
                EmpleadoSeleccionado.activo = true;
                EmpleadoSeleccionado.foto = _foto;
                EmpleadoSeleccionado.archivoCv = _archivoPDF;
                if (_accion == 0)
                    resultado = daoGestPersonas.InsertarCajero((cajero)EmpleadoSeleccionado);
                else
                {
                    EmpleadoSeleccionado.idPersona = Int32.Parse(txtID.Text);
                    resultado = daoGestPersonas.ModificarCajero((cajero)EmpleadoSeleccionado);
                }
                tipoEmpleado = 'C';
            }
            else if (cboArea.SelectedItem.ToString() == "Mesero")
            {
                EmpleadoSeleccionado = new GestPersonasWS.mesero();
                EmpleadoSeleccionado.DNI = txtDNI.Text;
                EmpleadoSeleccionado.nombre = txtNombre.Text;
                EmpleadoSeleccionado.apellidoPaterno = txtApellidoPaterno.Text;
                EmpleadoSeleccionado.email = txtEmail.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.telefono = txtTelefono.Text;
                EmpleadoSeleccionado.sueldo = Double.Parse(txtSueldo.Text);
                EmpleadoSeleccionado.fechaContratacion = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaContratacionSpecified = true;
                EmpleadoSeleccionado.fechaNacimiento = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaNacimientoSpecified = true;
                EmpleadoSeleccionado.numeroHorasMensuales = 0;
                EmpleadoSeleccionado.activo = true;
                EmpleadoSeleccionado.foto = _foto;
                EmpleadoSeleccionado.archivoCv = _archivoPDF;
                if (_accion == 0)
                    resultado = daoGestPersonas.InsertarMesero((mesero)EmpleadoSeleccionado);
                else
                {
                    EmpleadoSeleccionado.idPersona = Int32.Parse(txtID.Text);
                    resultado = daoGestPersonas.ModificarMesero((mesero)EmpleadoSeleccionado);
                }
                tipoEmpleado = 'M';
            }
            else if (cboArea.SelectedItem.ToString() == "Chef")
            {
                EmpleadoSeleccionado = new GestPersonasWS.chef();
                EmpleadoSeleccionado.DNI = txtDNI.Text;
                EmpleadoSeleccionado.nombre = txtNombre.Text;
                EmpleadoSeleccionado.apellidoPaterno = txtApellidoPaterno.Text;
                EmpleadoSeleccionado.email = txtEmail.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.telefono = txtTelefono.Text;
                EmpleadoSeleccionado.sueldo = Double.Parse(txtSueldo.Text);
                EmpleadoSeleccionado.fechaContratacion = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaContratacionSpecified = true;
                EmpleadoSeleccionado.fechaNacimiento = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaNacimientoSpecified = true;
                EmpleadoSeleccionado.numeroHorasMensuales = 0;
                EmpleadoSeleccionado.activo = true;
                EmpleadoSeleccionado.foto = _foto;
                EmpleadoSeleccionado.archivoCv = _archivoPDF;

                if (_accion == 0)
                    resultado = daoGestPersonas.InsertarChef((chef)EmpleadoSeleccionado);
                else
                {
                    resultado = daoGestPersonas.ModificarChef((chef)EmpleadoSeleccionado);
                    EmpleadoSeleccionado.idPersona = Int32.Parse(txtID.Text);
                }
                tipoEmpleado = 'F';
            }
            else
            {
                EmpleadoSeleccionado = new GestPersonasWS.recepcionista();
                EmpleadoSeleccionado.DNI = txtDNI.Text;
                EmpleadoSeleccionado.nombre = txtNombre.Text;
                EmpleadoSeleccionado.apellidoPaterno = txtApellidoPaterno.Text;
                EmpleadoSeleccionado.email = txtEmail.Text;
                EmpleadoSeleccionado.direccion = txtDireccion.Text;
                EmpleadoSeleccionado.telefono = txtTelefono.Text;
                EmpleadoSeleccionado.sueldo = Double.Parse(txtSueldo.Text);
                EmpleadoSeleccionado.fechaContratacion = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaContratacionSpecified = true;
                EmpleadoSeleccionado.fechaNacimiento = dtpFechaContratacion.Value;
                EmpleadoSeleccionado.fechaNacimientoSpecified = true;
                EmpleadoSeleccionado.numeroHorasMensuales = 0;
                EmpleadoSeleccionado.activo = true;
                EmpleadoSeleccionado.foto = _foto;
                EmpleadoSeleccionado.archivoCv = _archivoPDF;

                if (_accion == 0)
                    resultado = daoGestPersonas.InsertarRecepcionista((recepcionista)EmpleadoSeleccionado);
                else
                {
                    resultado = daoGestPersonas.ModificarRecepcionista((recepcionista)EmpleadoSeleccionado);
                    EmpleadoSeleccionado.idPersona = Int32.Parse(txtID.Text);
                }

                tipoEmpleado = 'R';
            }
            if (_accion == 0)
            {

                GestPersonasWS.cuentaUsuario cuentaUsuario = new GestPersonasWS.cuentaUsuario();
                cuentaUsuario.usuario = EmpleadoSeleccionado.nombre.Substring(0, 1).ToLower() +
                        EmpleadoSeleccionado.apellidoPaterno.ToLower();
                cuentaUsuario.contrasenia = "123456";
                cuentaUsuario.activo = true;
                cuentaUsuario.idUsuario = resultado;
                cuentaUsuario.empleado = EmpleadoSeleccionado;
                cuentaUsuario.tipoEmpleado = tipoEmpleado;
                daoGestPersonas.InsertarCuentaUsuario(cuentaUsuario);
                EmpleadoSeleccionado.cuentaUsuario = cuentaUsuario;

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
            else
            {
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado el empleado con exito");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al modificar");
                }
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
                    File.WriteAllBytes(archivoGenerar, EmpleadoSeleccionado.archivoCv);
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
