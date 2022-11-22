using LP2Rest.Gonzalo;
using LP2Rest.VentasWS;
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
    public partial class frmDocumentoPago : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Utiles
        private ordenVenta ordenVentaActual;
        private GestPersonasWS.cliente clienteActual;
        private GestPersonasWS.mesero MeseroActual;
        private MenuWS.itemVenta itemSeleccionado;
        private int idMesero;
        private double total;
        private BindingList<VentasWS.lineaOrdenVenta> lineasItems;
        private VentasWS.lineaOrdenVenta[] lineaItems;
        private documentoPago docPagoActual;

        //Estados


        public int IdMesero { get => idMesero; set => idMesero = value; }

        public BindingList<lineaOrdenVenta> LineasItems { get => lineasItems; set => lineasItems = value; }

        //Conexiones
        VentasWS.VentasWSClient daoVentas;


                   

        public frmDocumentoPago(String tipo, VentasWS.ordenVenta ordenVenta)
        {
            daoVentas = new VentasWS.VentasWSClient();
            ordenVentaActual = ordenVenta;

            if (tipo == "cajero")
            {
                //docPagoActual = daoVentas.ObtenerDocumentoDePago();
            }
            else
            {

            }

            
            

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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
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
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[3].Value = String.Format("{0:0.00}", auxLinea.descuento) + "%";
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[4].Value = String.Format("{0:0.00}", auxLinea.montoDescontado );
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

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gbLineasVenta_Enter(object sender, EventArgs e)
        {

        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
