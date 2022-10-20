using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
            /*
            else
            {
                frmErrorLogin formErrorLogin = new frmErrorLogin();
                formErrorLogin.ShowDialog();
            }
            */
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
