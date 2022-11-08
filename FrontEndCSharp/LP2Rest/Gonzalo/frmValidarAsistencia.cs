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
    public partial class frmValidarAsistencia : Form
    {
        private string estado;

        public frmValidarAsistencia()
        {
            InitializeComponent();
        }

        public string Estado { get => estado; set => estado = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Estado = "Aceptado";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            estado = "Cancelado";
        }
    }
}
