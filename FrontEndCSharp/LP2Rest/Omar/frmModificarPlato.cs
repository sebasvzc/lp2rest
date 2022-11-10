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
    public partial class frmModificarPlato : Form
    {
        private AlmacenWS.insumo insumo;
        private MenuWS.receta receta;
        private BindingList<AlmacenWS.insumo> insumos;
        private BindingList<MenuWS.receta> recetas;
        private MenuWS.MenuWSClient daoMenu;
        private AlmacenWS.AlmacenWSClient daoAlmacen;
        private MenuWS.itemVenta itemVenta;
        private double total = 0;
        public frmModificarPlato()
        {
            InitializeComponent();
        }

        public frmModificarPlato(MenuWS.itemVenta platoModificar)
        {
            InitializeComponent();
            daoMenu = new MenuWS.MenuWSClient();
            daoAlmacen = new AlmacenWS.AlmacenWSClient();
            dgvInsumos.AutoGenerateColumns = false;
            AlmacenWS.insumo[] insumos = daoAlmacen.listarInsumosPorIdItemVenta(platoModificar.idItemVenta);
            dgvInsumos.DataSource = insumos.ToList();
            txtIdPlato.Text = platoModificar.idItemVenta.ToString();
            txtNombrePlato.Text = platoModificar.nombre;
            txtStock.Text = platoModificar.stock.ToString();
            txtPrecioVenta.Text = platoModificar.precio.ToString("N2");
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
