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
    }
}
