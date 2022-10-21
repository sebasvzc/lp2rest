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
    public partial class frmValidarIdentidad : Form
    {
        public frmValidarIdentidad()
        {
            InitializeComponent();
        }

        private void lblInstrucciones_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;

        }
    }
}
