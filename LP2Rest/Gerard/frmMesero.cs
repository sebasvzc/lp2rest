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
    public partial class frmMesero : Form
    {
        public frmMesero()
        {
            InitializeComponent();
        }
        
        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            frmMesas formMesas = new frmMesas();
            formMesas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmListaOrdenVenta formListaOrdenVenta = new frmListaOrdenVenta();
            formListaOrdenVenta.ShowDialog();
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            btnAsistencia_Click( sender,  e);
        }

        private void imgPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            formListarPlatos.ShowDialog();
        }
    }
}
