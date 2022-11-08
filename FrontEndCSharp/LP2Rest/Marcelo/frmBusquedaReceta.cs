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
    public partial class frmBusquedaReceta : Form
    {
        public frmBusquedaReceta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblIten_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {

        }

        private void tsbVer_Click(object sender, EventArgs e)
        {
            frmGestionReceta formReceta  = new  frmGestionReceta();
            if (formReceta.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmNuevaReceta formNuevaReceta = new frmNuevaReceta();
            if (formNuevaReceta.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            pbVolver_Click(sender, e);
        }
    }
}
