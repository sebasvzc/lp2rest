using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Gonzalo
{
    public partial class frmGestionarCombos : Form
    {
        public frmGestionarCombos()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarPlato_Click(object sender, EventArgs e)
        {
            frmBuscarSoloPlatos formBuscarSoloPlatos = new frmBuscarSoloPlatos();
            formBuscarSoloPlatos.ShowDialog();
        }
    }
}
