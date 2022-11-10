using LP2Rest.Gerard;
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
    public partial class frmValidarIdentidad : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private int _idCuentaUsuario;
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        public frmValidarIdentidad(int idCuentaUsuario)
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            _idCuentaUsuario = idCuentaUsuario;
        }
        public frmValidarIdentidad()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
        }
        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int verificacionExitosa = daoGestPersonas.validarCodigoCuentaUsuario(_idCuentaUsuario, txtCodVerif.Text);
            this.Hide();
            if (verificacionExitosa != 0 && new frmNuevaContrasenia(_idCuentaUsuario).ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (verificacionExitosa == 0)
            {
                MessageBox.Show("El código de verificación es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Show();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
    }
}
