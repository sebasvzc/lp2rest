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
    public partial class frmCrearCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private String _estado;
        private GestPersonasWS.cliente cliente;
        private GestPersonasWS.GestPersonasWSClient daoCliente;

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmCrearCliente()
        {
            InitializeComponent();
            daoCliente = new GestPersonasWS.GestPersonasWSClient();
            cliente = new GestPersonasWS.cliente();
            _estado = "Nuevo";
        }

        public frmCrearCliente(GestPersonasWS.cliente clienteMod)
        {
            InitializeComponent();
            daoCliente = new GestPersonasWS.GestPersonasWSClient();
            cliente = new GestPersonasWS.cliente();
            txtDNI.Text = clienteMod.DNI;
            txtID.Text = clienteMod.idPersona.ToString();
            txtNombres.Text = clienteMod.nombre;
            dtpFechaNacimiento.Value = clienteMod.fechaNacimiento;
            textEmail.Text = clienteMod.email;
            txtTelefono.Text = clienteMod.telefono;
            txtDireccion.Text = clienteMod.direccion;
            txtApellidos.Text = clienteMod.apellidoPaterno;
            _estado = "Modificar";
        }
        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.nombre = txtNombres.Text;
            cliente.DNI = txtDNI.Text;
            cliente.apellidoPaterno = txtApellidos.Text;
            cliente.fechaNacimiento = dtpFechaNacimiento.Value;
            cliente.fechaNacimientoSpecified = true;
            cliente.email = textEmail.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.direccion = txtDireccion.Text;

            int resultado=-1;

            if (_estado == "Modificar")
            {
                cliente.idPersona =Int32.Parse(txtID.Text);
                resultado = daoCliente.ModificarCliente(cliente);
            }
            if (_estado == "Nuevo")
            {
                resultado = daoCliente.InsertarCliente(cliente);
            }
            if (resultado != 0)
            {
                if (resultado == -1)
                {
                    MessageBox.Show("Error en establecer estados", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (_estado == "Modificar")
                    {
                        MessageBox.Show("Se pudo modificar el cliente correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (_estado == "Nuevo")
                    {
                        MessageBox.Show("Se pudo registrar el cliente correctamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                    txtID.Text = resultado.ToString();
                }
            }
            else
            {

                MessageBox.Show("Ha ocurrido un error al momento de registrar el cliente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
