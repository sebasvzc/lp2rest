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
    }
}
