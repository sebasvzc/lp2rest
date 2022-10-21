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
    public partial class frmNuevaReceta : Form
    {
        public frmNuevaReceta()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void tsbAgregarInsumo_Click(object sender, EventArgs e)
        {
            frmAgregarInsumoReceta formNuevoInsumoReceta = new frmAgregarInsumoReceta();
            if(formNuevoInsumoReceta.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
