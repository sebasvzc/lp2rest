using LP2Rest.Gonzalo;
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
    public partial class frmListarPlatos : Form
    {
        private MenuWS.MenuWSClient daoMenu;
        public frmListarPlatos()
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

        private void btnNuevo_Click(object sender, EventArgs e) //Crea plato
        {
            frmGestionarPlatos formGestionarPlatos = new frmGestionarPlatos();
            formGestionarPlatos.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Crear combo
        {
            frmGestionarCombos formGestionarCombos = new frmGestionarCombos();
            formGestionarCombos.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvItemsVenta.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar este plato?", "Mensaje de Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    int resultado = daoMenu.EliminarItemVenta(((MenuWS.itemVenta)dgvItemsVenta.CurrentRow.DataBoundItem).idItemVenta);
                    if (resultado != 0)
                    {
                        MessageBox.Show("Se ha eliminado exitosamente el plato", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al momento de eliminar el plato", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un plato", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

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

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}