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
    public partial class frmGestionReceta : Form
    {
        public frmGestionReceta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            pbVolver_Click( sender, e);
        }

        private void tsbAgregarInsumo_Click(object sender, EventArgs e)
        {
            frmAgregarInsumoReceta formNuevoInsumoReceta = new frmAgregarInsumoReceta();
            if (formNuevoInsumoReceta.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
