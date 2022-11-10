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
    public partial class frmRecuperacionContraseña : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        public frmRecuperacionContraseña()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private void txtDNI_Validating_1(object sender, CancelEventArgs e)
        {

        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelDerecho_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int busquedaExitosa = daoGestPersonas.enviarCorreoRecuperacion(txtCorreo.Text);
            frmValidarIdentidad validarIdentidad = new frmValidarIdentidad(busquedaExitosa);
            this.Hide();
            if ((busquedaExitosa != 0) && (validarIdentidad.ShowDialog() == DialogResult.OK))
            {
                this.DialogResult = DialogResult.OK;
            }
            else if (busquedaExitosa == 0)
            {
                MessageBox.Show(" No se ha encontrado el correo ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Show();
        }
    }
}
