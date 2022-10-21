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
    public partial class frmBusquedaInsumos : Form
    {
        public frmBusquedaInsumos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblEditarInsumo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblVolver_Click(object sender, EventArgs e)
        {
            pictureBox1_Click( sender,  e);
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            frmGestionInsumo formGestionInsumo = new frmGestionInsumo();
            if(formGestionInsumo.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoInsumo formNuevoInsumo = new frmNuevoInsumo();
            if (formNuevoInsumo.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsbSolicitud_Click(object sender, EventArgs e)
        {
            frmNuevaSolicitudCompraInsumo   formNuevaSolicitud = new frmNuevaSolicitudCompraInsumo();
            if (formNuevaSolicitud.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
