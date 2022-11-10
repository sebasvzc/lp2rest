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
    public partial class frmListarUsuariosA : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        public frmListarUsuariosA()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            GestPersonasWS.empleado[] lista = daoGestPersonas.listarTodasAdministradores();

        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.empleado empleado = (GestPersonasWS.empleado)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = empleado.DNI;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = empleado.nombre + " " + empleado.apellidoPaterno;
            dgvEmpleados.Rows[e.RowIndex].Cells[3].Value = empleado.telefono;
            dgvEmpleados.Rows[e.RowIndex].Cells[4].Value = empleado.email;


        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionUsuariosA formGestionUsuariosA = new frmGestionUsuariosA();
            if (formGestionUsuariosA.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
