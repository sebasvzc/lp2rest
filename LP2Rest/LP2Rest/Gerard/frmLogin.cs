using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest
{
    public partial class frmLogin : Form
    {
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
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.FromArgb(100, 100, 100);
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if(txtContrasena.Text == "CONTRASEÑA")
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
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.FromArgb(100, 100, 100);
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
    }
}
