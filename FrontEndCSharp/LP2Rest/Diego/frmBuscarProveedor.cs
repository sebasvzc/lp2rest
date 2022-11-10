using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Diego
{
    public partial class frmBuscarProveedor : Form
    {
        private GestPersonasWS.GestPersonasWSClient _daoMetodos;
        private GestPersonasWS.proveedor _proveedorSeleccionada;

        public GestPersonasWS.proveedor ProveedorSeleccionada { get => _proveedorSeleccionada; set => _proveedorSeleccionada = value; }
        public frmBuscarProveedor()
        {
            InitializeComponent();
            dgvProveedores.AutoGenerateColumns = false;
            _daoMetodos = new GestPersonasWS.GestPersonasWSClient();
        }

        private void txtNombreProveeedor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GestPersonasWS.proveedor[] proveedores = _daoMetodos.listarProveedoresPorNombre(txtNombreProveeedor.Text);
            if (proveedores != null)
                dgvProveedores.DataSource = proveedores.ToList();
            else
                dgvProveedores.DataSource = null;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                _proveedorSeleccionada = (GestPersonasWS.proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgvProveedores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.proveedor proveedor = (GestPersonasWS.proveedor)dgvProveedores.Rows[e.RowIndex].DataBoundItem;

            dgvProveedores.Rows[e.RowIndex].Cells[0].Value = proveedor.RUC;
            dgvProveedores.Rows[e.RowIndex].Cells[1].Value = proveedor.nombreComercial;
            dgvProveedores.Rows[e.RowIndex].Cells[2].Value = proveedor.razonSocial;
        }
    }
}
