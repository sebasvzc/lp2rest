using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmLogin()
        {
            InitializeComponent();
        } 

        private void lbOlvideContrasena_Click(object sender, EventArgs e)
        {
            frmRecuperacionContraseña recuperacionContraseña = new frmRecuperacionContraseña();
            recuperacionContraseña.ShowDialog();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Mesero")
            {
                frmMesero formMesero = new frmMesero();
                formMesero.ShowDialog();
            }
            else if (txtUsuario.Text == "Administrador")
            {
                frmPrincipalA formPrincipalA = new frmPrincipalA();
                formPrincipalA.ShowDialog();
            }
            else if(txtUsuario.Text == "Cajero")
            {
                frmCajero formCajero = new frmCajero();
                formCajero.ShowDialog();
            }
            else if (txtUsuario.Text == "Chef")
            {
                frmInicioChef formChef = new frmInicioChef();
                formChef.ShowDialog();
            }
            else if (txtUsuario.Text == "Recepcionista")
            {
                frmRecepcionista formRecepcionista = new frmRecepcionista();
                formRecepcionista.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            /*
            else
            {
                frmErrorLogin formErrorLogin = new frmErrorLogin();
                formErrorLogin.ShowDialog();
            }
            */
        }



        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.FromArgb(80, 80, 100);
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.FromArgb(80, 80, 80);
                txtContrasena.UseSystemPasswordChar = false;
            }
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
    }
}
