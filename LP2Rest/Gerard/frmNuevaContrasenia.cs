using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Gerard
{
    public partial class frmNuevaContrasenia : Form
    {
        public frmNuevaContrasenia()
        {
            InitializeComponent();
        }

        private void btnMostrarOcultar1_Click(object sender, EventArgs e)
        {
            if (txtNuevaContra.UseSystemPasswordChar == true)
            {
                txtNuevaContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtNuevaContra.UseSystemPasswordChar = true;
            }
        }

        private void btnMostrarOcultar2_Click(object sender, EventArgs e)
        {
            if (txtConfirmarContra.UseSystemPasswordChar == true)
            {
                txtConfirmarContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmarContra.UseSystemPasswordChar = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si se logro cambiar la contraseña con exito
            if (txtNuevaContra.Text == txtConfirmarContra.Text)
            {
                MessageBox.Show("Contraseña cambiada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
