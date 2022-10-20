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
    public partial class frmInicioChef : Form
    {
        public frmInicioChef()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            pbPlatos_Click(sender, e);
        }

        private void pbPlatos_Click(object sender, EventArgs e)
        {
            frmBusquedaReceta formPlatos = new frmBusquedaReceta();
            if (formPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbInsumos_Click(object sender, EventArgs e)
        {
            frmBusquedaInsumos formInsumos = new frmBusquedaInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void lblInsumos_Click(object sender, EventArgs e)
        {
            pbInsumos_Click(sender, e);
        }

        private void pbSolicitudCompras_Click(object sender, EventArgs e)
        {
            frmSolicitudesCompras formSolCompras = new frmSolicitudesCompras();
            if (formSolCompras.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
