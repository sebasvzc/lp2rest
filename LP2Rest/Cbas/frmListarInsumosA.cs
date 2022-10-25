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
    public partial class frmListarInsumosA : Form
    {
        public frmListarInsumosA()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionInsumosA frm = new frmGestionInsumosA();
            frm.ShowDialog();
        } 
    }
}
