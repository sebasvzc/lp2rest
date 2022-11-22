using System;
using System.Collections;
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
    public partial class frmModificarPlato : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private AlmacenWS.insumo[] insumos;
        private MenuWS.MenuWSClient daoMenu;
        private AlmacenWS.AlmacenWSClient daoAlmacen;
        private MenuWS.itemVenta itemVenta; 
        private MenuWS.itemVenta[] lineasCombo;
        private double total = 0;
        private int tipoItemVenta;
        public frmModificarPlato()
        {
            InitializeComponent();
        }

        public frmModificarPlato(MenuWS.itemVenta platoModificar)
        {
            InitializeComponent();
            tipoItemVenta = platoModificar.tipoItem.idTipoItem;
            cbDisponible.Items.Add("Disponible");
            cbDisponible.Items.Add("Agotado");
            
            if(platoModificar.disponible == 1)
                cbDisponible.SelectedItem = cbDisponible.Items[0];
            else
                cbDisponible.SelectedItem = cbDisponible.Items[1];
            daoMenu = new MenuWS.MenuWSClient();
            daoAlmacen = new AlmacenWS.AlmacenWSClient();
            dgvInsumos.AutoGenerateColumns = false;

            txtIdPlato.Text = platoModificar.idItemVenta.ToString();
            txtNombrePlato.Text = platoModificar.nombre;
            txtStock.Text = platoModificar.stock.ToString();
            txtPrecioVenta.Text = platoModificar.precio.ToString("N2");
            txtDescuento.Text = platoModificar.descuento.ToString("N2");

            if (tipoItemVenta == 3) //Combo
            {
                txtReceta.Visible = false;
                lblReceta.Visible = false;
                dgvInsumos.Columns[0].HeaderText = "ID";
                try{
                    lineasCombo = daoMenu.listarLineasComboXIdCombo(platoModificar.idItemVenta).ToArray();
                    dgvInsumos.DataSource = lineasCombo.ToList();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                foreach (MenuWS.itemVenta iv in lineasCombo)
                {
                    total += iv.stock * iv.precio;
                }
                txtTotal.Text = total.ToString("N2");
            }
            else //Plato normal
            {
                dgvInsumos.Columns[0].HeaderText = "SKU";
                try 
                {
                    insumos = daoAlmacen.listarInsumosPorIdItemVenta(platoModificar.idItemVenta).ToArray();
                    dgvInsumos.DataSource = insumos.ToList();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                txtReceta.Text = platoModificar.recetaDePreparacion;
                foreach (AlmacenWS.insumo insumo in insumos)
                {
                    total += insumo.stock * insumo.precioCompra;
                }
                txtTotal.Text = total.ToString("N2");
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if(tipoItemVenta != 3)
                {
                    AlmacenWS.insumo insumo = (AlmacenWS.insumo)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
                    dgvInsumos.Rows[e.RowIndex].Cells[0].Value = insumo.SKU;
                    dgvInsumos.Rows[e.RowIndex].Cells[1].Value = insumo.nombre;
                    dgvInsumos.Rows[e.RowIndex].Cells[2].Value = insumo.stock.ToString();
                    dgvInsumos.Rows[e.RowIndex].Cells[3].Value = insumo.precioCompra.ToString("N2");
                    dgvInsumos.Rows[e.RowIndex].Cells[4].Value = (insumo.precioCompra * insumo.stock).ToString("N2");
                }
                else
                {
                    MenuWS.itemVenta lineaCombo = (MenuWS.itemVenta)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
                    dgvInsumos.Rows[e.RowIndex].Cells[0].Value = lineaCombo.idItemVenta;
                    dgvInsumos.Rows[e.RowIndex].Cells[1].Value = lineaCombo.nombre;
                    dgvInsumos.Rows[e.RowIndex].Cells[2].Value = lineaCombo.stock.ToString();
                    dgvInsumos.Rows[e.RowIndex].Cells[3].Value = lineaCombo.precio.ToString("N2");
                    dgvInsumos.Rows[e.RowIndex].Cells[4].Value = (lineaCombo.precio * lineaCombo.stock).ToString("N2");
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if(txtGanancia.Text == "")
            {
                MessageBox.Show("No se ha ingresado la nueva ganancia", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDescuento.Text == "")
            {
                MessageBox.Show("No se ha ingresado el nuevo descuento", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            itemVenta = new MenuWS.itemVenta();
            itemVenta.idItemVenta = Int32.Parse(txtIdPlato.Text);
            itemVenta.nombre = txtNombrePlato.Text;
            itemVenta.stock = Int32.Parse(txtStock.Text);
            itemVenta.descuento = Double.Parse(txtDescuento.Text);
            itemVenta.precio = Double.Parse(txtTotal.Text) + (Double.Parse(txtGanancia.Text) - itemVenta.descuento) * Double.Parse(txtTotal.Text) / 100;
            if (tipoItemVenta != 3)
                itemVenta.recetaDePreparacion = txtReceta.Text;
            if (cbDisponible.SelectedItem.ToString() == "Disponible")
                itemVenta.disponible = 1;
            else
                itemVenta.disponible = 0;
            if (itemVenta.precio <= 0)
                MessageBox.Show("ERROR: El precio del producto se está modificando como negativo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int resultado = daoMenu.ModificarItemVenta(itemVenta);
                if (resultado != 0)
                {
                    txtPrecioVenta.Text = itemVenta.precio.ToString("N2");
                    MessageBox.Show("Se ha modificado exitosamente el producto", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de modificar el producto", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
