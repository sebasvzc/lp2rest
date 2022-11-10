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
    public partial class frmGestionarPlatos : Form
    {
        private AlmacenWS.insumo insumo;
        private MenuWS.receta receta;
        private BindingList<AlmacenWS.insumo> insumos;
        private BindingList<MenuWS.receta> recetas;
        private MenuWS.MenuWSClient daoMenu;
        private MenuWS.itemVenta itemVenta;
        private double total = 0;
        public frmGestionarPlatos()
        {
            InitializeComponent();
            itemVenta = new MenuWS.itemVenta();
            daoMenu = new MenuWS.MenuWSClient();
            insumos = new BindingList<AlmacenWS.insumo>();
            recetas = new BindingList<MenuWS.receta>();
            dgvInsumos.AutoGenerateColumns = false;
            dgvInsumos.DataSource = insumos;

            cbCategoria.DataSource = daoMenu.listarTodasTiposDeItem();
            cbCategoria.DisplayMember = "descripcion";
            cbCategoria.ValueMember = "idTipoItem";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombreInsumo.Text != "" && txtCantidad.Text != "")
            {
                insumo.stock = Int32.Parse(txtCantidad.Text); //Uso stock como cantidad
                insumos.Add(insumo);

                foreach (AlmacenWS.insumo insumo in insumos)
                {
                    total += insumo.stock * insumo.precioCompra;
                }
                txtTotal.Text = total.ToString("N2");
            }
            else
                MessageBox.Show("No se ha buscado un insumo o no se ha ingresado una cantidad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvInsumos.CurrentRow != null)
            {
                insumo = (AlmacenWS.insumo)dgvInsumos.CurrentRow.DataBoundItem;
                insumos.Remove(insumo);
                total -= insumo.stock * insumo.precioCompra;
                txtTotal.Text = total.ToString("N2");
            }
            else
                MessageBox.Show("No se ha seleccionado un insumo", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                AlmacenWS.insumo insumo = (AlmacenWS.insumo)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
                dgvInsumos.Rows[e.RowIndex].Cells[0].Value = insumo.SKU;
                dgvInsumos.Rows[e.RowIndex].Cells[1].Value = insumo.nombre;
                dgvInsumos.Rows[e.RowIndex].Cells[2].Value = insumo.stock.ToString();
                dgvInsumos.Rows[e.RowIndex].Cells[3].Value = insumo.precioCompra.ToString("N2");
                dgvInsumos.Rows[e.RowIndex].Cells[4].Value = (insumo.precioCompra * insumo.stock).ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            itemVenta.nombre = txtNombrePlato.Text;
            itemVenta.precio = Double.Parse(txtGanancia.Text) + Double.Parse(txtTotal.Text);
            itemVenta.stock = Int32.Parse(txtStock.Text);
            itemVenta.tipoItem = (MenuWS.tipoItem)cbCategoria.SelectedItem;
            itemVenta.disponible = 1; //Para que no se pueda pedir el plato cuando recien se ha creado

            foreach (AlmacenWS.insumo ins in insumos)
            {
                receta = new MenuWS.receta();
                receta.insumo = new MenuWS.insumo();
                receta.insumo.idInsumo = ins.idInsumo;
                receta.cantidad = ins.stock;
                recetas.Add(receta);
            }
            itemVenta.recetas = recetas.ToArray();

            int resultado = daoMenu.InsertarItemVenta(itemVenta);
            if (resultado != 0)
            {
                MessageBox.Show("Se ha guardado exitosamente el plato", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdPlato.Text = itemVenta.idItemVenta.ToString();
                txtPrecioVenta.Text = itemVenta.precio.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al momento de guardar el plato", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarInsumos formBuscarInsumos = new frmBuscarInsumos();
            if (formBuscarInsumos.ShowDialog() == DialogResult.OK)
            {
                insumo = formBuscarInsumos.InsumoSeleccionado;
                txtNombreInsumo.Text = insumo.nombre;
            }
        }
    }
}