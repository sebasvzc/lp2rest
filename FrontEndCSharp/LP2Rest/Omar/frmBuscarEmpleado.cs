using LP2Rest.GestPersonasWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Omar
{
    public partial class frmBuscarEmpleado : Form
    {
        private GestPersonasWS.empleado empleadoSeleccionado;
        private GestPersonasWS.GestPersonasWSClient _daoPersona;
        public frmBuscarEmpleado()
        {
            InitializeComponent();
            _daoPersona = new GestPersonasWS.GestPersonasWSClient();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        public empleado EmpleadoSeleccionado { get => empleadoSeleccionado; set => empleadoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestPersonasWS.empleado[] empleados = _daoPersona.ListarEmpleadosPorNombre(txtNombreCompleto.Text);
            if (empleados != null)
            {
                dgvEmpleados.DataSource = empleados.ToList();
            }
            else
            {
                dgvEmpleados.DataSource = null;
                MessageBox.Show("No se ha encontrado un empleado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                EmpleadoSeleccionado = (GestPersonasWS.empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un empleado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.empleado empleadoS = (GestPersonasWS.empleado)
               dgvEmpleados.Rows[e.RowIndex].DataBoundItem;

            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = empleadoS.idPersona;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = empleadoS.nombre + " " +empleadoS.apellidoPaterno;
        }
    }
}
