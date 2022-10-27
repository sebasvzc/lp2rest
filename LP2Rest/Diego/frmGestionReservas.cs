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
    public partial class frmGestionReservas : Form
    {
        public frmGestionReservas()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCrearReservas frmCrearReservas = new frmCrearReservas();
            frmCrearReservas.ShowDialog();
        }

    

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCrearReservas frmCrearReservas = new frmCrearReservas();
            frmCrearReservas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
