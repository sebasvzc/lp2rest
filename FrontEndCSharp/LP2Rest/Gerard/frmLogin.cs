using LP2Rest.GestPersonasWS;
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
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        public frmLogin()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
        }

        private void lbOlvideContrasena_Click(object sender, EventArgs e)
        {
            frmRecuperacionContraseña recuperacionContraseña = new frmRecuperacionContraseña();
            recuperacionContraseña.ShowDialog();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            GestPersonasWS.cuentaUsuario cuentaUsuario = new cuentaUsuario();
            cuentaUsuario.usuario = txtUsuario.Text;
            cuentaUsuario.contrasenia = txtContrasena.Text;
            cuentaUsuario = daoGestPersonas.verificarCuentaUsuario(cuentaUsuario);
            if (cuentaUsuario.tipoEmpleado == 'A')
            {
                frmPrincipalA formPrincipalA = new frmPrincipalA(cuentaUsuario);
                this.Hide();
                if(formPrincipalA.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (cuentaUsuario.tipoEmpleado == 'M')
            {
                frmPrincipalMesero formMesero = new frmPrincipalMesero(cuentaUsuario);
                this.Hide();
                if (formMesero.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (cuentaUsuario.tipoEmpleado == 'C')
            {
                frmPrincipalCajero formCajero = new frmPrincipalCajero(cuentaUsuario);
                this.Hide();
                if (formCajero.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (cuentaUsuario.tipoEmpleado == 'F')
            {
                frmInicioChef formChef = new frmInicioChef(cuentaUsuario);
                this.Hide();
                if (formChef.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else if (cuentaUsuario.tipoEmpleado == 'R')
            {
                frmPrincipalRecepcionista formRecepcionista = new frmPrincipalRecepcionista(cuentaUsuario);
                this.Hide();
                if (formRecepcionista.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (txtContrasena.Text == "Contraseña")
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

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btIngresar_Click(null, null);
            }
        }
    }
}
