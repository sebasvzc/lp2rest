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
    public partial class frmRecuperacionContraseña : Form
    {
        public frmRecuperacionContraseña()
        {
            InitializeComponent();
        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmValidarIdentidad validarIdentidad = new frmValidarIdentidad();
            if (validarIdentidad.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Cancel;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtDNI_Validating_1(object sender, CancelEventArgs e)
        {
            if (txtDNI.Text.Trim() == "")
                epDNI.SetError(txtDNI, "Debe ingresar un DNI");
            else if (txtDNI.Text.Trim().Length != 8)
                epDNI.SetError(txtDNI, "El DNI debe tener 8 dígitos");
            else
                epDNI.SetError(txtDNI, "");
        }
    }
}
