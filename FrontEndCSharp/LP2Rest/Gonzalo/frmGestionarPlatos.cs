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
    public partial class frmGestionarPlatos : Form
    {
        public frmGestionarPlatos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblDNINombre_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmBuscarInsumos formBuscarInsumos = new frmBuscarInsumos();
            formBuscarInsumos.ShowDialog();
        }
    }
}
