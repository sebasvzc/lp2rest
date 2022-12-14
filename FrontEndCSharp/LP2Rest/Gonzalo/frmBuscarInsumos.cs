using LP2Rest.AlmacenWS;
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

namespace LP2Rest
{
    public partial class frmBuscarInsumos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private AlmacenWS.AlmacenWSClient daoAlmacen;
        private AlmacenWS.insumo insumoSeleccionado;

        public insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        public frmBuscarInsumos()
        {
            InitializeComponent();
            daoAlmacen = new AlmacenWS.AlmacenWSClient();
            dgvInsumos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AlmacenWS.insumo[] insumos = daoAlmacen.BuscarInsumosPorNombre(txtNombre.Text);
            if (insumos != null)
            {
                dgvInsumos.DataSource = insumos.ToList();
            }
            else
            {
                dgvInsumos.DataSource = null;
                MessageBox.Show("No se ha encontrado un insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccionarInsumo_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow != null)
            {
                insumoSeleccionado = (AlmacenWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AlmacenWS.insumo insumo = (AlmacenWS.insumo)
               dgvInsumos.Rows[e.RowIndex].DataBoundItem;

            dgvInsumos.Rows[e.RowIndex].Cells[0].Value = insumo.SKU;
            dgvInsumos.Rows[e.RowIndex].Cells[1].Value = insumo.nombre;
            dgvInsumos.Rows[e.RowIndex].Cells[2].Value = insumo.precioCompra.ToString("N2");
            dgvInsumos.Rows[e.RowIndex].Cells[3].Value = insumo.unidadMedida;
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