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
        private AlmacenWS.AlmacenWSClient daoGestAlmacen;
        //private AlmacenWS.tipoProducto[] dataSourceTipoProd;
        private MenuWS.MenuWSClient daoGestMenu;
        private AlmacenWS.insumo insumoSeleccionado;
        public AlmacenWS.insumo InsumoSeleccionado { get => insumoSeleccionado; set => insumoSeleccionado = value; }

        private void inicializacion()
        {
            InitializeComponent();
            daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
            daoGestMenu = new MenuWS.MenuWSClient();
            dgvInsumos.AutoGenerateColumns = false;

            var dataSourceTipoProd = daoGestAlmacen.ListarTipoProducto().ToList();
            dataSourceTipoProd.Insert(0, new AlmacenWS.tipoProducto { nombre = "", idTipoProducto = -1 });


            cboTipoProducto.DataSource = dataSourceTipoProd;
            cboTipoProducto.DisplayMember = "nombre";
            cboTipoProducto.ValueMember = "idTipoProducto";

            var dataSourcePlato = daoGestMenu.listarTodasItemVentas().ToList();
            dataSourcePlato.Insert(0, new MenuWS.itemVenta { nombre = "", idItemVenta = -1 });

            cboPlato.DataSource = dataSourcePlato;
            cboPlato.DisplayMember = "nombre";
            cboPlato.ValueMember = "idItemVenta";
            //cboTipoProducto.Items.Insert(0, "Selecciona un Tipo de Producto");
        }

        public frmListarInsumosA()
        {
            inicializacion();
        }

        public frmListarInsumosA(bool mostrarSeleccionar)
        {
            inicializacion();
            if (!mostrarSeleccionar)
            {
                btnSeleccionar.Hide();
                btnCancelar.Hide();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoInsumo frm = new frmNuevoInsumo();
            frm.ShowDialog();
        }
        public frmListarInsumosA(String estado)
        {

            InitializeComponent();
            daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
            daoGestMenu = new MenuWS.MenuWSClient();
            dgvInsumos.AutoGenerateColumns = false;

            var dataSourceTipoProd = daoGestAlmacen.ListarTipoProducto().ToList();
            dataSourceTipoProd.Insert(0, new AlmacenWS.tipoProducto { nombre = "", idTipoProducto = -1 });


            cboTipoProducto.DataSource = dataSourceTipoProd;
            cboTipoProducto.DisplayMember = "nombre";
            cboTipoProducto.ValueMember = "idTipoProducto";

            var dataSourcePlato = daoGestMenu.listarTodasItemVentas().ToList();
            dataSourcePlato.Insert(0, new MenuWS.itemVenta { nombre = "", idItemVenta = -1 });

            cboPlato.DataSource = dataSourcePlato;
            cboPlato.DisplayMember = "nombre";
            cboPlato.ValueMember = "idItemVenta";
            btnSeleccionar.Visible = true;

            //cboTipoProducto.Items.Insert(0, "Selecciona un Tipo de Producto");

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //double costMin, costMax;
            int idTipoProdSelec, idPlatoSelec;
            double precioMin, precioMax, stockMin, stockMax;
            if (txtPrecioMin.Text == "") precioMin = -1;
            else precioMin = Double.Parse(txtPrecioMin.Text);

            if (txtPrecioMax.Text == "") precioMax = -1;
            else precioMax = Double.Parse(txtPrecioMax.Text);

            if (txtStockMin.Text == "") stockMin = -1;
            else stockMin = Double.Parse(txtStockMin.Text);

            if (txtStockMax.Text == "") stockMax = -1;
            else stockMax = Double.Parse(txtStockMax.Text);

            if (((AlmacenWS.tipoProducto)cboTipoProducto.SelectedItem).idTipoProducto == -1) idTipoProdSelec = -1;
            else idTipoProdSelec = ((AlmacenWS.tipoProducto)cboTipoProducto.SelectedItem).idTipoProducto;

            if (((MenuWS.itemVenta)cboPlato.SelectedItem).idItemVenta == -1) idPlatoSelec = -1;
            else idPlatoSelec = ((MenuWS.itemVenta)cboPlato.SelectedItem).idItemVenta;

            AlmacenWS.insumo[] insumos = daoGestAlmacen.FiltrarInsumos(txtNombre.Text, txtSKU.Text,
                idPlatoSelec, precioMin,
                precioMax, stockMin, stockMax,
                idTipoProdSelec);
            if (insumos != null)
                dgvInsumos.DataSource = insumos.ToList();
            else
            {
                dgvInsumos.DataSource = null;
                MessageBox.Show("No se ha encontrado un insumo con el filtro seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AlmacenWS.insumo insumo = (AlmacenWS.insumo)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
            dgvInsumos.Rows[e.RowIndex].Cells[0].Value = insumo.SKU;
            dgvInsumos.Rows[e.RowIndex].Cells[1].Value = insumo.nombre;
            dgvInsumos.Rows[e.RowIndex].Cells[2].Value = insumo.precioCompra.ToString("N2");
            dgvInsumos.Rows[e.RowIndex].Cells[3].Value = insumo.stock.ToString("N2");
            dgvInsumos.Rows[e.RowIndex].Cells[4].Value = insumo.tipoProducto.nombre;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow != null)
            {
                insumoSeleccionado = (AlmacenWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;
                // MessageBox.Show("Se va modificar el " + insumoSeleccionado.i, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmNuevoInsumo frm = new frmNuevoInsumo(insumoSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow != null)
            {
                insumoSeleccionado = (AlmacenWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;

                if (MessageBox.Show("¿Esta seguro que desea eliminar este insumo?",
                    "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    ) == DialogResult.Yes)
                {
                    int resultado = daoGestAlmacen.EliminarInsumo(insumoSeleccionado.idInsumo);
                    if (resultado == 1)
                        MessageBox.Show("Se ha eliminado exitosamente el evento", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Ha ocurrido un error al momento de eliminar el evento", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow != null)
            {
                insumoSeleccionado = (AlmacenWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}