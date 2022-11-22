using LP2Rest.GestPersonasWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Omar
{
    public partial class frmBuscarEmpleado : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
    }
}
