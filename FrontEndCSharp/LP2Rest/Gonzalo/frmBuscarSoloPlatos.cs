using LP2Rest.MenuWS;
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
    public partial class frmBuscarSoloPlatos : Form
    {
        private MenuWS.MenuWSClient daoMenu;
        private MenuWS.itemVenta _itemVentaSeleccionado;
        public frmBuscarSoloPlatos()
        {
            InitializeComponent();
            daoMenu = new MenuWS.MenuWSClient();
            cboCategoria.DataSource = daoMenu.listarTodasTiposDeItem();
            cboCategoria.DisplayMember = "descripcion";
            cboCategoria.ValueMember = "idTipoItem";
            cboDisponible.Items.Add("Disponible");
            cboDisponible.Items.Add("Agotado");
            dgvItemsVenta.AutoGenerateColumns = false;
        }

        public itemVenta ItemVentaSeleccionado { get => _itemVentaSeleccionado; set => _itemVentaSeleccionado = value; }

        private void btnBuscarPlatoCombo_Click(object sender, EventArgs e)
        {
            double precioMin, precioMax;
            int disponibleBinario;

            if (txtPrecioMin.Text == "")
                precioMin = 0;
            else precioMin = Double.Parse(txtPrecioMin.Text);

            if (txtPrecioMax.Text == "")
                precioMax = 999999;
            else precioMax = Double.Parse(txtPrecioMax.Text);

            if (cboDisponible.SelectedItem == null || cboDisponible.SelectedItem.ToString() == "Disponible")
                disponibleBinario = 1;
            else
                disponibleBinario = 0;

            MenuWS.itemVenta[] itemsVenta = daoMenu.filtrarItemsVenta(txtNombre.Text, ((MenuWS.tipoItem)cboCategoria.SelectedItem).idTipoItem,
                         precioMin, precioMax, disponibleBinario);
            if (itemsVenta != null)
                dgvItemsVenta.DataSource = itemsVenta.ToList();
            else
            {
                dgvItemsVenta.DataSource = null;
                MessageBox.Show("No se ha encontrado un itemVenta", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSeleccionarPlato_Click(object sender, EventArgs e)
        {
            if (dgvItemsVenta.CurrentRow != null)
            {
                _itemVentaSeleccionado = (MenuWS.itemVenta)dgvItemsVenta.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void dgvItemsVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MenuWS.itemVenta itemVenta = (MenuWS.itemVenta)
                dgvItemsVenta.Rows[e.RowIndex].DataBoundItem;

            dgvItemsVenta.Rows[e.RowIndex].Cells[0].Value = itemVenta.idItemVenta;
            dgvItemsVenta.Rows[e.RowIndex].Cells[1].Value = itemVenta.nombre;
            dgvItemsVenta.Rows[e.RowIndex].Cells[2].Value = itemVenta.tipoItem.descripcion;
            dgvItemsVenta.Rows[e.RowIndex].Cells[3].Value = itemVenta.precio.ToString("N2");
            dgvItemsVenta.Rows[e.RowIndex].Cells[4].Value = itemVenta.stock.ToString();
        }
    }
}