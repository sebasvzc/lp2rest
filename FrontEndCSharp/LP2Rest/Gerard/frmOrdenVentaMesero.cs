using LP2Rest.Gonzalo;
using LP2Rest.VentasWS;
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
    public partial class frmOrdenVentaMesero : Form
    {
        //Utiles
        private mesa mesaSeleccionada;
        private ordenVenta ordenVentaSeleccionada;
        private GestPersonasWS.cliente clienteSeleccionado;
        private MenuWS.itemVenta itemSeleccionado;
        private int idMesero;
        private double total;
        private lineaOrdenVenta[] lineasItems;

        //Estados
        private bool libre;
        private bool cerrada;

        public bool Libre { get => libre; set => libre = value; }
        public mesa MesaSeleccionada { get => mesaSeleccionada; set => mesaSeleccionada = value; }
        public ordenVenta OrdenVentaSeleccionada { get => ordenVentaSeleccionada; set => ordenVentaSeleccionada = value; }
        public int IdMesero { get => idMesero; set => idMesero = value; }
        public bool Cerrada { get => cerrada; set => cerrada = value; }

        //Conexiones
        VentasWS.VentasWSClient daoVentas;

        public frmOrdenVentaMesero(ordenVenta auxOrdenVenta, int auxIdMesero)
        {
            daoVentas = new VentasWSClient();

            lineasItems = daoVentas.ListarBusquedaLineasOrdenVenta( auxOrdenVenta.idOrdenVenta );            

            InitializeComponent();


            if (lineasItems == null)
            {
                MessageBox.Show("Orden de Venta vacia", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnBuscarCliente.Enabled = false;

            dgvDetalleOrdenVenta.AutoGenerateColumns = false;

            dgvDetalleOrdenVenta.DataSource = lineasItems;

            txtIDOrdenVenta.Text = auxOrdenVenta.idOrdenVenta.ToString();
            txtIdMesa.Text = auxOrdenVenta.mesa.idMesa.ToString();

            txtDNICliente.Text = auxOrdenVenta.cliente.DNI;
            txtNombreCliente.Text = auxOrdenVenta.cliente.nombre + " " + auxOrdenVenta.cliente.apellidoPaterno;


            txtTotal.Text = String.Format("{0:0.00}", auxOrdenVenta.total);

        }

        private void frmOrdenVenta_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            

        }

        private void frmOrdenVenta_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void frmOrdenVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            
        }

        private void btnQuitarPlato_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            
            
        }

        private void dgvDetalleOrdenVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                lineaOrdenVenta auxLinea = (lineaOrdenVenta)dgvDetalleOrdenVenta.Rows[e.RowIndex].DataBoundItem;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[0].Value = auxLinea.itemVenta.nombre;
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[1].Value = auxLinea.cantidadVendida.ToString();
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[2].Value = String.Format("{0:0.00}", auxLinea.itemVenta.precio);
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[3].Value = String.Format("{0:0.00}", auxLinea.descuento.ToString())  + "%";
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[4].Value = String.Format("{0:0.00}", auxLinea.montoDescontado.ToString());
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[5].Value = String.Format("{0:0.00}", auxLinea.subtotal);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetalleOrdenVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
