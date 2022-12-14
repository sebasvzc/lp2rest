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
    public partial class frmOrdenVentaCajero : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Utiles
        private mesa mesaSeleccionada;
        private ordenVenta ordenVentaSeleccionada;
        private GestPersonasWS.cliente clienteSeleccionado;
        private MenuWS.itemVenta itemSeleccionado;
        private int idMesero;
        private double total;
        private BindingList<VentasWS.lineaOrdenVenta> lineasItems;
        private VentasWS.cajero cajeroActual;

        //Estados
        private bool libre;
        private bool cerrada;

        public bool Libre { get => libre; set => libre = value; }
        public mesa MesaSeleccionada { get => mesaSeleccionada; set => mesaSeleccionada = value; }
        public ordenVenta OrdenVentaSeleccionada { get => ordenVentaSeleccionada; set => ordenVentaSeleccionada = value; }
        public int IdMesero { get => idMesero; set => idMesero = value; }
        public bool Cerrada { get => cerrada; set => cerrada = value; }
        public BindingList<lineaOrdenVenta> LineasItems { get => lineasItems; set => lineasItems = value; }

        //Conexiones
        VentasWS.VentasWSClient daoVentas;

        private int idMesaOrdenVenta;

        public frmOrdenVentaCajero(VentasWS.cajero auxCajero, VentasWS.ordenVenta auxOrdenVenta)
        {
            ordenVentaSeleccionada = auxOrdenVenta;
            cajeroActual = auxCajero;

            daoVentas = new VentasWS.VentasWSClient();
            //Libre = true;
            InitializeComponent();

            dgvDetalleOrdenVenta.AutoGenerateColumns = false;
            txtIDOrdenVenta.Text = auxOrdenVenta.idOrdenVenta.ToString();
            textBox3.Text = auxOrdenVenta.mesa.idMesa.ToString();
            txtEstado.Text = auxOrdenVenta.estado;
            txtDNICliente.Text = auxOrdenVenta.cliente.DNI;
            txtNombreCliente.Text = auxOrdenVenta.cliente.nombre;

            dgvDetalleOrdenVenta.DataSource = daoVentas.listarLineasOrdenVentaPorId(auxOrdenVenta.idOrdenVenta);

            btnAgregarPlato.Enabled = false;
            btnQuitarPlato.Enabled = false;
            btnBuscarCliente.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnBuscarProducto.Enabled = false;

            btnNuevo.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;

            txtTotal.Text = String.Format("{0:0.00}", auxOrdenVenta.total);

            btnGenerarBoleta.Visible = false;

            if (ordenVentaSeleccionada.estado == "Sin antender")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = false;
            }
            if (ordenVentaSeleccionada.estado == "En Preparacion")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
            }
            if (ordenVentaSeleccionada.estado == "Listo")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
            }
            if (ordenVentaSeleccionada.estado == "Pagada")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
                btnGenerarBoleta.Visible = true;
                btnGenerarBoleta.Enabled = true;
            }

            


            //btnPreparar.Enabled = true;

        }

        private void frmOrdenVenta_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDocumentoPago formDocPago = new frmDocumentoPago("cajero", cajeroActual, ordenVentaSeleccionada);
            formDocPago.ShowDialog();

            ordenVentaSeleccionada.cajero = formDocPago.OrdenVentaActual.cajero;
            actualizarInfo();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmGestionReclamoBusquedaCliente formBusquedaCliente = new frmGestionReclamoBusquedaCliente();
            if (formBusquedaCliente.ShowDialog() == DialogResult.OK)
            {
                clienteSeleccionado = formBusquedaCliente.clienteSeleccionado;
                txtDNICliente.Text = clienteSeleccionado.DNI;
                txtNombreCliente.Text = clienteSeleccionado.nombre + " " + clienteSeleccionado.apellidoPaterno;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un cliente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            total = 0.0;

            libre = false;
            mesaSeleccionada.disponible = false;


            txtCantidad.Enabled = true;
            txtDescuento.Enabled = true;


            btnBuscarProducto.Enabled = true;


            ordenVentaSeleccionada = new ordenVenta();
            ordenVentaSeleccionada.total = 0.0;
            ordenVentaSeleccionada.pagado = false;
            ordenVentaSeleccionada.fechaSpecified = true;
            ordenVentaSeleccionada.fecha = DateTime.Now;
            ordenVentaSeleccionada.estado = "Sin atender";

            lineasItems = new BindingList<lineaOrdenVenta>();

            ordenVentaSeleccionada.documentoPago = new documentoPago();
            ordenVentaSeleccionada.documentoPago.total = 0.0;
            ordenVentaSeleccionada.documentoPago.igv = 18.0;
            ordenVentaSeleccionada.documentoPago.tipoPago = "Pendiente";
            ordenVentaSeleccionada.documentoPago.fechaEmisionSpecified = true;
            ordenVentaSeleccionada.documentoPago.fechaEmision = DateTime.Now;
            ordenVentaSeleccionada.documentoPago.fechaPagoSpecified = true;
            ordenVentaSeleccionada.documentoPago.fechaPago = DateTime.Now;
            ordenVentaSeleccionada.documentoPago.ruc = "0123456";
            ordenVentaSeleccionada.documentoPago.razonSocial = "LP2 Restaurante";
            ordenVentaSeleccionada.documentoPago.serie = "PruebaSerie";
            ordenVentaSeleccionada.documentoPago.numero = 666;
            ordenVentaSeleccionada.documentoPago.montoRecibido = 0.0;
            ordenVentaSeleccionada.documentoPago.metodoPago = "Pendiente";
            ordenVentaSeleccionada.documentoPago.direccionFiscal = "Casita Fachera 1234";

            ordenVentaSeleccionada.documentoPago.idDocumentoPago = daoVentas.InsertarDocumentoDePago(ordenVentaSeleccionada.documentoPago);
            if (ordenVentaSeleccionada.documentoPago.idDocumentoPago == 0)
            {
                MessageBox.Show("Error al generar Documento de Pago.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //OrdenVentaSeleccionada ya tiene un documento de pago;

            ordenVentaSeleccionada.mesa = mesaSeleccionada;
            //mesaSeleccionada.ordVen = new ordenVenta();

            ordenVentaSeleccionada.mesero = new mesero();
            ordenVentaSeleccionada.mesero.idPersona = IdMesero;


            ordenVentaSeleccionada.cajero = null;

            ordenVentaSeleccionada.cliente = new cliente();
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("No se ha seleccionado un cliente", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordenVentaSeleccionada.cliente.idPersona = clienteSeleccionado.idPersona;
                ordenVentaSeleccionada.cliente.nombre = clienteSeleccionado.nombre;
                ordenVentaSeleccionada.cliente.apellidoPaterno = clienteSeleccionado.apellidoPaterno;
            }

            ordenVentaSeleccionada.idOrdenVenta = daoVentas.InsertarOrdenVenta(ordenVentaSeleccionada);
            mesaSeleccionada.ordVen.idOrdenVenta = ordenVentaSeleccionada.idOrdenVenta;
            mesaSeleccionada.ordVen.mesero = ordenVentaSeleccionada.mesero;


            if (ordenVentaSeleccionada.idOrdenVenta > 0)
            {
                //mesaSeleccionada.ordVen = ordenVentaSeleccionada;
                MessageBox.Show("Orden de Venta Creada", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int resultadoModMesa = daoVentas.ModificarMesaOrdenVenta(mesaSeleccionada);
                if (resultadoModMesa == 0)
                {
                    MessageBox.Show("Error al asignar Orden de Venta a Mesa " + mesaSeleccionada.idMesa.ToString() + ".", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Error de creacion de Orden de Venta", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtIDOrdenVenta.Text = ordenVentaSeleccionada.idOrdenVenta.ToString();
            txtEstado.Text = ordenVentaSeleccionada.estado;

            txtTotal.Text = String.Format("{0:0.00}", total);

            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = true;

            btnAgregarPlato.Enabled = true;
            btnQuitarPlato.Enabled = true;

        }

        private void frmOrdenVenta_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void frmOrdenVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            mesaSeleccionada.disponible = true;


            daoVentas.EliminarOrdenVenta(mesaSeleccionada.ordVen.idOrdenVenta);

            mesaSeleccionada.ordVen = null;

            daoVentas.ModificarMesaOrdenVenta(mesaSeleccionada);

            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;

            Cerrada = true;

            MessageBox.Show("Orden de Venta Eliminada", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ordenVentaSeleccionada = null;
            clienteSeleccionado = null;
            itemSeleccionado = null;

            txtIDOrdenVenta.Text = "";

            clienteSeleccionado = new GestPersonasWS.cliente();
            clienteSeleccionado.idPersona = 78; //Cliente Generico o orden de venta para atenderse sin indicar cliente.

            txtDNICliente.Text = "11111111";
            txtNombreCliente.Text = "Cliente Generico";

            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioUnitario.Text = "";

            txtCantidad.Text = "";
            txtDescuento.Text = "";

            txtTotal.Text = "";

            dgvDetalleOrdenVenta.DataSource = null;

            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarSoloPlatos formBusquedaItem = new frmBuscarSoloPlatos();
            if (formBusquedaItem.ShowDialog() == DialogResult.OK)
            {
                itemSeleccionado = formBusquedaItem.ItemVentaSeleccionado;
                txtCodigoProducto.Text = itemSeleccionado.idItemVenta.ToString();
                txtNombreProducto.Text = itemSeleccionado.nombre;
                txtPrecioUnitario.Text = itemSeleccionado.precio.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mesaSeleccionada.disponible == true)
            {
                MessageBox.Show("Modificacion Fallida. Orden de Venta Vacia.", "Modificacion Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtCantidad.Enabled = true;
                txtDescuento.Enabled = true;

                btnBuscarCliente.Enabled = true;
                btnBuscarProducto.Enabled = true;

                btnAgregarPlato.Enabled = true;
                btnQuitarPlato.Enabled = true;

                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = true;

            }

        }

        private void btnQuitarPlato_Click(object sender, EventArgs e)
        {
            if (dgvDetalleOrdenVenta.SelectedRows.Count == 1)
            {
                int auxId = ((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem).idLineaOrdenVenta;

                total -= ((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem).subtotal;
                ordenVentaSeleccionada.total = total;

                daoVentas.EliminarLineaOrdenVenta(auxId);
                LineasItems.Remove((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem);


                dgvDetalleOrdenVenta.DataSource = LineasItems;

                txtTotal.Text = String.Format("{0:0.00}", total);

                int resultado = daoVentas.ModificarOrdenVenta(ordenVentaSeleccionada);

                if (resultado == 0)
                {
                    MessageBox.Show("Error al agregar item.", "Item vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Borrado Exitoso.", "Borrado de Linea Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




            }
            else
            {
                MessageBox.Show("No se ha seleccionado una Linea de Orden de Venta.", "Error de Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            if (itemSeleccionado != null)
            {


                VentasWS.lineaOrdenVenta auxLnOrdenVenta = new VentasWS.lineaOrdenVenta();


                auxLnOrdenVenta.fechaRegistroSpecified = true;
                auxLnOrdenVenta.fechaRegistro = DateTime.Now;
                auxLnOrdenVenta.activo = true;
                auxLnOrdenVenta.promocion = false;

                auxLnOrdenVenta.ordenVenta = ordenVentaSeleccionada;

                auxLnOrdenVenta.itemVenta = new itemVenta();
                auxLnOrdenVenta.itemVenta.idItemVenta = itemSeleccionado.idItemVenta;
                auxLnOrdenVenta.itemVenta.precio = itemSeleccionado.precio;
                auxLnOrdenVenta.itemVenta.nombre = itemSeleccionado.nombre;

                if (txtDescuento.Text == "")
                {
                    auxLnOrdenVenta.descuento = 0.0;
                }
                else
                {
                    auxLnOrdenVenta.descuento = double.Parse(txtDescuento.Text);
                }

                if (txtCantidad.Text == "")
                {
                    auxLnOrdenVenta.cantidadVendida = 0;
                }
                else
                {
                    auxLnOrdenVenta.cantidadVendida = int.Parse(txtCantidad.Text);
                }

                auxLnOrdenVenta.montoDescontado = (auxLnOrdenVenta.descuento) / 100.0 * (itemSeleccionado.precio * auxLnOrdenVenta.cantidadVendida);

                auxLnOrdenVenta.subtotal = (100.0 - auxLnOrdenVenta.descuento) / 100.0 * (itemSeleccionado.precio * auxLnOrdenVenta.cantidadVendida);

                total += auxLnOrdenVenta.subtotal;
                txtTotal.Text = String.Format("{0:0.00}", total);

                auxLnOrdenVenta.idLineaOrdenVenta = daoVentas.InsertarLineaOrdenVenta(auxLnOrdenVenta);

                lineasItems.Add(auxLnOrdenVenta);


                ordenVentaSeleccionada.total += auxLnOrdenVenta.subtotal;

                int resultado = daoVentas.ModificarOrdenVenta(ordenVentaSeleccionada);

                if (resultado == 0)
                {
                    MessageBox.Show("Error al actualizar Orden de Venta.", "Error Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvDetalleOrdenVenta.DataSource = lineasItems;

                auxLnOrdenVenta = null;
                itemSeleccionado = null;
                txtCodigoProducto.Text = "";
                txtNombreProducto.Text = "";
                txtPrecioUnitario.Text = "";
                txtCantidad.Text = "";
                txtDescuento.Text = "";

            }
            else
            {
                MessageBox.Show("No se ha seleccionado un item", "Item vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[4].Value = String.Format("{0:0.00}", auxLinea.montoDescontado);
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[5].Value = String.Format("{0:0.00}", auxLinea.subtotal);
            }
            catch (Exception ex)
            {

            }

        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            int resultado = daoVentas.ActualizarOrdenVenta(ordenVentaSeleccionada.idOrdenVenta);
            if (resultado != -1)
            {
                MessageBox.Show("El pedido esta ahora en preparacion", "Cambio de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hay problema", "Pedido Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void actualizarInfo()
        {
            if (ordenVentaSeleccionada.estado == "Sin antender")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = false;
            }
            if (ordenVentaSeleccionada.estado == "En Preparacion")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
            }
            if (ordenVentaSeleccionada.estado == "Atendido")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
            }
            if (ordenVentaSeleccionada.estado == "Pagada")
            {
                btnDocPago.Text = "Ver Documento de Pago";
                btnDocPago.Enabled = true;
                btnGenerarBoleta.Visible = true;
                btnGenerarBoleta.Enabled = true;
            }

            txtEstado.Text = ordenVentaSeleccionada.estado;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGenerarBoletaVenta formGenBolVen = new frmGenerarBoletaVenta(ordenVentaSeleccionada.idOrdenVenta);
            formGenBolVen.ShowDialog();
        }
    }
}
