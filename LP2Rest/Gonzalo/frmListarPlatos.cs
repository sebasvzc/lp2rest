using LP2Rest.Gonzalo;
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
    public partial class frmListarPlatos : Form
    {
        public frmListarPlatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionarPlatos formGestionarPlatos = new frmGestionarPlatos();
            formGestionarPlatos.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmGestionarCombos formGestionarCombos = new frmGestionarCombos();
            formGestionarCombos.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmValidarEliminado formValidarEliminado = new frmValidarEliminado();
            formValidarEliminado.ShowDialog();
        }
    }
}
