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

        private int idMesero;
        private BindingList<VentasWS.lineaOrdenVenta> lineasItems;
        private documentoPago docPagoActual;
        private VentasWS.cajero cajeroActual;

        //Estados


        public int IdMesero { get => idMesero; set => idMesero = value; }

        public BindingList<lineaOrdenVenta> LineasItems { get => lineasItems; set => lineasItems = value; }
        public cajero CajeroActual { get => cajeroActual; set => cajeroActual = value; }
        public ordenVenta OrdenVentaActual { get => ordenVentaActual; set => ordenVentaActual = value; }

        //Conexiones
        VentasWS.VentasWSClient daoVentas;
        GestPersonasWS.GestPersonasWSClient daoPersonas;


                   

        public frmDocumentoPago(String tipo, VentasWS.cajero auxCajero, VentasWS.ordenVenta auxOrdenVenta)
        {
            daoVentas = new VentasWS.VentasWSClient();
            daoPersonas = new GestPersonasWS.GestPersonasWSClient();

            OrdenVentaActual = auxOrdenVenta;
            OrdenVentaActual.lineasOrdenVenta = daoVentas.listarLineasOrdenVentaPorId(OrdenVentaActual.idOrdenVenta);
            docPagoActual = daoVentas.ObtenerDocumentoDePago(OrdenVentaActual.documentoPago.idDocumentoPago);
            

            List<string> listaMetodos = new List<string>()
                    {
                        "Tarjeta Credito",
                        "Tarjeta Debito",
                        "Efectivo",
                        "Cheque"
                    };
            InitializeComponent();

            dgvDetalleOrdenVenta.AutoGenerateColumns = false;
            cboMetodoPago.DataSource = listaMetodos;

            txtIdDocPago.Text = docPagoActual.idDocumentoPago.ToString();
            txtEstado.Text = OrdenVentaActual.estado;
            txtSerie.Text = docPagoActual.serie;
            txtRuc.Text = docPagoActual.ruc;
            txtDirFiscal.Text = docPagoActual.direccionFiscal;
            txtNumero.Text = docPagoActual.numero.ToString();

            txtDNICliente.Text = OrdenVentaActual.cliente.DNI;
            txtNombreCliente.Text = OrdenVentaActual.cliente.nombre + " " + OrdenVentaActual.cliente.apellidoPaterno;



            dgvDetalleOrdenVenta.DataSource = OrdenVentaActual.lineasOrdenVenta;

            dtpFechaEmision.Value = docPagoActual.fechaEmision;
            dtpFechaEmision.Enabled = false;
            dtpFechaPago.Value = docPagoActual.fechaPago;
            dtpFechaPago.Enabled = false;
            txtTotal.Text = String.Format("{0:0.00}", OrdenVentaActual.total);
            txtMontoPagado.Text = String.Format("{0:0.00}", docPagoActual.montoRecibido);

            if (tipo == "cajero")
            {
                if (OrdenVentaActual.cajero != null)
                {
                    CajeroActual = OrdenVentaActual.cajero;
                    txtIdCajero.Text = CajeroActual.idPersona.ToString();
                                       
                    txtNombreCajero.Text = CajeroActual.nombre + " " + cajeroActual.apellidoPaterno;
                }
                else
                {
                    CajeroActual = null;
                    CajeroActual = auxCajero;
                    txtIdCajero.Text = "Por asignar.";
                    txtNombreCajero.Text = " -";
                    //CajeroActual = auxCajero;
                    //OrdenVentaActual.cajero = CajeroActual;
                    //txtIdCajero.Text = OrdenVentaActual.cajero.idPersona.ToString();
                    //txtNombreCajero.Text = OrdenVentaActual.cajero.nombre + " " + OrdenVentaActual.cajero.apellidoPaterno;
                }                

                if (OrdenVentaActual.estado == "Listo")
                {
                    btnGuardarPago.Enabled = false;
                    btnModificar.Enabled = true;
                    btnMontoTotal.Enabled = false;
                    cboMetodoPago.Enabled = false;
                    txtMontoPagado.Enabled = false;

                }
                else
                {
                    btnGuardarPago.Enabled = false;
                    btnModificar.Enabled = false;
                    btnMontoTotal.Enabled = false;
                    cboMetodoPago.Enabled = false;
                    txtMontoPagado.Enabled = false;
                }

            }
            else
            {
                if(ordenVentaActual.cajero != null)
                {
                    txtIdCajero.Text = OrdenVentaActual.cajero.idPersona.ToString();
                    if (OrdenVentaActual.cajero.nombre == null)
                    {
                        GestPersonasWS.empleado aux = daoPersonas.ObtenerEmpleadoPorId(OrdenVentaActual.cajero.idPersona);
                        OrdenVentaActual.cajero.nombre = aux.nombre;
                        OrdenVentaActual.cajero.apellidoPaterno = aux.apellidoPaterno;
                    }
                    txtNombreCajero.Text = OrdenVentaActual.cajero.nombre + " " + OrdenVentaActual.cajero.apellidoPaterno;
                }
                else
                {
                    CajeroActual = null;
                    txtIdCajero.Text = "Por asignar.";
                    txtNombreCajero.Text = " -";
                }

                switch (docPagoActual.metodoPago)
                {
                    case "Tarjeta Credito":
                        cboMetodoPago.SelectedIndex = 0;
                        break;
                    case "Tarjeta Debito":
                        cboMetodoPago.SelectedIndex = 1;
                        break;
                    case "Efectivo":
                        cboMetodoPago.SelectedIndex = 2;
                        break;
                    case "Cheque":
                        cboMetodoPago.SelectedIndex = 3;
                        break;
                }

                btnGuardarPago.Enabled = false;
                btnModificar.Enabled = false;
                btnMontoTotal.Enabled = false;
                cboMetodoPago.Enabled = false;
                txtMontoPagado.Enabled = false;

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

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            btnGuardarPago.Enabled = true;
            btnModificar.Enabled = false;
            btnMontoTotal.Enabled = true;
            cboMetodoPago.Enabled = true;
            txtMontoPagado.Enabled = true;
        }

        private void btnMontoTotal_Click(object sender, EventArgs e)
        {
            docPagoActual.montoRecibido = OrdenVentaActual.total;
            txtMontoPagado.Text = String.Format("{0:0.00}", docPagoActual.montoRecibido);
        }

        private void actualizarInfo1()
        {
            txtEstado.Text = OrdenVentaActual.estado;

            txtIdCajero.Text = OrdenVentaActual.cajero.idPersona.ToString();
            txtNombreCajero.Text = OrdenVentaActual.cajero.nombre + " " + OrdenVentaActual.cajero.apellidoPaterno;

            dtpFechaPago.Value = docPagoActual.fechaPago;

            //"Tarjeta Credito",
            //"Tarjeta Debito",
            //"Efectivo",
            //"Cheque"

            switch (docPagoActual.metodoPago)
            {
                case "Tarjeta Credito":
                    cboMetodoPago.SelectedIndex = 0;
                    break;
                case "Tarjeta Debito":
                    cboMetodoPago.SelectedIndex = 1;
                    break;
                case "Efectivo":
                    cboMetodoPago.SelectedIndex = 2;
                    break;
                case "Cheque":
                    cboMetodoPago.SelectedIndex = 3;
                    break;
            }
            //cboMetodoPago.SelectedValue = docPagoActual.metodoPago;
        }

        private void btnGuardarPago_Click(object sender, EventArgs e)
        {
            OrdenVentaActual.estado = "Pagada";
            OrdenVentaActual.pagado = true;

            docPagoActual.metodoPago = cboMetodoPago.SelectedValue.ToString();
            docPagoActual.tipoPago = cboMetodoPago.SelectedValue.ToString();
            docPagoActual.fechaPagoSpecified = true;
            docPagoActual.fechaPago = DateTime.Now;
            docPagoActual.total = OrdenVentaActual.total;

            if(OrdenVentaActual.cajero == null)
            {
                OrdenVentaActual.cajero = CajeroActual;
            }



            int resultadoDoc = daoVentas.ModificarDocumentoDePago(docPagoActual);
            if (resultadoDoc <= 0)
            {
                MessageBox.Show("Error al modificar Documento de Pago.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int resultadoOrdVen = daoVentas.ModificarOrdenVenta(OrdenVentaActual);
                if(resultadoOrdVen <= 0)
                {
                    MessageBox.Show("Error al modificar Orden de Venta.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Pago registrado exitoso.", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualizarInfo1();

                    dtpFechaEmision.Enabled = false;
                    dtpFechaPago.Enabled = false;
                    cboMetodoPago.Enabled = false;
                    txtMontoPagado.Enabled = false;
                    btnMontoTotal.Enabled = false;

                    btnGuardarPago.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }

            


        }

        
    }
}
