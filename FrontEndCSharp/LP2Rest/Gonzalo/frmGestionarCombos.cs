using LP2Rest.AlmacenWS;
using LP2Rest.MenuWS;
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

namespace LP2Rest.Gonzalo
{
    public partial class frmGestionarCombos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private MenuWS.itemVenta _itemVenta;
        private BindingList<MenuWS.itemVenta> platos;
        private double costoTotal = 0;
        private MenuWS.MenuWSClient daoMenu;
        private MenuWS.lineaDetalleCombo lineaCombo;
        private BindingList<MenuWS.lineaDetalleCombo> lineasDelCombo;
        public frmGestionarCombos()
        {
            InitializeComponent();
            daoMenu = new MenuWS.MenuWSClient();
            platos = new BindingList<MenuWS.itemVenta>();
            lineasDelCombo = new BindingList<MenuWS.lineaDetalleCombo>();
            dgvPlatos.AutoGenerateColumns = false;
            dgvPlatos.DataSource = platos;
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            if (txtIDPlato.Text != "" && txtNombrePlato.Text != "" && txtCantidad.Text != "")
            {
                _itemVenta.stock = Int32.Parse(txtCantidad.Text); //Uso stock como cantidad
                platos.Add(_itemVenta);

                foreach (MenuWS.itemVenta itv in platos)
                {
                    costoTotal += _itemVenta.stock * _itemVenta.precio;
                }
                txtTotal.Text = costoTotal.ToString("N2");
            }
            else
                MessageBox.Show("No se ha buscado un plato o no se ha ingresado una cantidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            if (dgvPlatos.CurrentRow != null)
            {
                _itemVenta = (MenuWS.itemVenta)dgvPlatos.CurrentRow.DataBoundItem;
                platos.Remove(_itemVenta);
                costoTotal -= _itemVenta.stock * _itemVenta.precio;
                txtTotal.Text = costoTotal.ToString("N2");
            }
            else
                MessageBox.Show("No se ha seleccionado un insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _itemVenta = new MenuWS.itemVenta();
            _itemVenta.nombre = txtNombre.Text;
            _itemVenta.precio = Double.Parse(txtGanancia.Text) + Double.Parse(txtTotal.Text);
            _itemVenta.stock = Int32.Parse(txtStock.Text);
            _itemVenta.tipoItem = new MenuWS.tipoItem();
            _itemVenta.tipoItem.idTipoItem = 3;
            _itemVenta.disponible = 1; //Para que no se pueda pedir el combo cuando recien se ha creado


            foreach (MenuWS.itemVenta plato in platos)
            {
                lineaCombo = new MenuWS.lineaDetalleCombo();
                lineaCombo.fid_producto = plato.idItemVenta;
                lineaCombo.cantidad = plato.stock;
                lineasDelCombo.Add(lineaCombo);
            }
            _itemVenta.lineasCombo = lineasDelCombo.ToArray();

            int resultado = daoMenu.insertarCombo(_itemVenta);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado exitosamente el combo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCombo.Text = _itemVenta.idItemVenta.ToString();
                txtPrecioVenta.Text = _itemVenta.precio.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al momento de guardar el combo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dgvPlatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                MenuWS.itemVenta itemVenta = (MenuWS.itemVenta)
                dgvPlatos.Rows[e.RowIndex].DataBoundItem;

                dgvPlatos.Rows[e.RowIndex].Cells[0].Value = itemVenta.idItemVenta;
                dgvPlatos.Rows[e.RowIndex].Cells[1].Value = itemVenta.nombre;
                dgvPlatos.Rows[e.RowIndex].Cells[2].Value = itemVenta.stock.ToString();
                dgvPlatos.Rows[e.RowIndex].Cells[3].Value = itemVenta.precio.ToString("N2");
                dgvPlatos.Rows[e.RowIndex].Cells[4].Value = (itemVenta.stock * itemVenta.precio).ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarSoloPlatos formBuscarSoloPlatos = new frmBuscarSoloPlatos();
            if (formBuscarSoloPlatos.ShowDialog() == DialogResult.OK)
            {
                _itemVenta = formBuscarSoloPlatos.ItemVentaSeleccionado;
                txtIDPlato.Text = _itemVenta.idItemVenta.ToString();
                txtNombrePlato.Text = _itemVenta.nombre;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}