using LP2Rest;
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
    public partial class frmGestionOrdenesVentaA : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        //Conexiones
        private VentasWS.VentasWSClient daoVentas;

        //Utiles
        private ordenVenta ordenVentaActual;
        private BindingList<lineaOrdenVenta> ordenVentaItems;
        private VentasWS.cliente clienteSeleccionado;
        private VentasWS.mesero meseroSeleccionado;
        private VentasWS.cajero cajeroSeleccionado;
        private MenuWS.itemVenta itemSeleccionado;
        private GestPersonasWS.cliente cliente;
        private double total;
        

        public frmGestionOrdenesVentaA()
        {
            InitializeComponent();
        }
        public frmGestionOrdenesVentaA(ordenVenta auxOrdenVenta)
        {
            daoVentas = new VentasWSClient();

            ordenVentaActual = auxOrdenVenta;

            lineaOrdenVenta[] aux = daoVentas.ListarBusquedaLineasOrdenVenta(ordenVentaActual.idOrdenVenta);
            if (aux == null)
            {
                ordenVentaItems = new BindingList<lineaOrdenVenta>();
            }
            else
            {
                ordenVentaItems = new BindingList<lineaOrdenVenta>(aux.ToList());
            }

            InitializeComponent();

            dgvDetalleOrdenVenta.AutoGenerateColumns = false;

            dgvDetalleOrdenVenta.DataSource = ordenVentaItems;            

            txtIDOrdenVenta.Text = ordenVentaActual.idOrdenVenta.ToString();
            txtIdMesa.Text = ordenVentaActual.mesa.idMesa.ToString();
            dtpFechaOrdenVenta.Value = ordenVentaActual.fecha;
            txtTotal.Text = String.Format("{0:0.00}", ordenVentaActual.total );
            txtEstado.Text = ordenVentaActual.estado;

            clienteSeleccionado = ordenVentaActual.cliente;
            txtDNICliente.Text = clienteSeleccionado.DNI.ToString();
            txtNombreCliente.Text = clienteSeleccionado.nombre + " " + clienteSeleccionado.apellidoPaterno;

            meseroSeleccionado = ordenVentaActual.mesero;
            txtIdMesero.Text = meseroSeleccionado.idPersona.ToString();
            txtNombreMesero.Text = meseroSeleccionado.nombre + " " + meseroSeleccionado.apellidoPaterno;

            cajeroSeleccionado = ordenVentaActual.cajero;
            if(cajeroSeleccionado == null)
            {
                txtIdCajero.Text = " -";
                txtNombreCajero.Text = " -";
            }
            else {
                txtIdCajero.Text = cajeroSeleccionado.idPersona.ToString();
                txtNombreCajero.Text = cajeroSeleccionado.nombre + " " + cajeroSeleccionado.apellidoPaterno; ;
            }

            btnBuscarCliente.Enabled = false;
            btnBuscarProducto.Enabled = false;
            btnSeleccionarMesa.Enabled = false;
            btnBuscarMesero.Enabled = false;
            btnBuscarCajero.Enabled = false;

            btnAgregarItem.Enabled = false;
            btnQuitarItem.Enabled = false;

            btnSeleccionarMesa.Enabled = false;

            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;

            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = true;


        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnBuscarCliente.Enabled = true;
            btnBuscarProducto.Enabled = true;
            btnSeleccionarMesa.Enabled = true;
            btnBuscarMesero.Enabled = true;
            btnBuscarCajero.Enabled = true;

            btnAgregarItem.Enabled = true;
            btnQuitarItem.Enabled = true;

            btnSeleccionarMesa.Enabled = false;

            txtCantidad.Enabled = true;
            txtDescuento.Enabled = true;

            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = false;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmGestionClientes formGestionClientes = new frmGestionClientes();
            if (formGestionClientes.ShowDialog() == DialogResult.OK)
            {
                cliente = formGestionClientes.clienteSeleccionado;
                txtDNICliente.Text = cliente.DNI.ToString();
                txtNombreCliente.Text = cliente.nombre + " " + cliente.apellidoPaterno;
                ordenVentaActual.cliente.idPersona = cliente.idPersona;
                ordenVentaActual.cliente.nombre = cliente.nombre;
                ordenVentaActual.cliente.apellidoPaterno = cliente.apellidoPaterno;
                ordenVentaActual.cliente.DNI = cliente.DNI;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            
            frmBuscarSoloPlatos formBuscarItem = new frmBuscarSoloPlatos();
            if (formBuscarItem.ShowDialog() == DialogResult.OK)
            {
                itemSeleccionado = formBuscarItem.ItemVentaSeleccionado;
                txtCodigoProducto.Text = itemSeleccionado.idItemVenta.ToString();
                txtNombreProducto.Text = itemSeleccionado.nombre;
                txtPrecioUnitario.Text = itemSeleccionado.precio.ToString();
            }
        }

        private void gbLineasVenta_Enter(object sender, EventArgs e)
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
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[4].Value = String.Format("{0:0.00}", auxLinea.montoDescontado);
                dgvDetalleOrdenVenta.Rows[e.RowIndex].Cells[5].Value = String.Format("{0:0.00}", auxLinea.subtotal);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnBuscarMesero_Click(object sender, EventArgs e)
        {
            frmGestionEmpleadosBusquedaEmpleado formBuscarMesero = new frmGestionEmpleadosBusquedaEmpleado("Mesero");
            if(formBuscarMesero.ShowDialog() is DialogResult.OK)
            {
                meseroSeleccionado = new VentasWS.mesero();
                meseroSeleccionado.idPersona = formBuscarMesero.EmpleadoSeleccionado.idPersona;
                meseroSeleccionado.nombre = formBuscarMesero.EmpleadoSeleccionado.nombre;
                meseroSeleccionado.apellidoPaterno = formBuscarMesero.EmpleadoSeleccionado.apellidoPaterno;
                ordenVentaActual.mesero = meseroSeleccionado;
                txtIdMesero.Text = meseroSeleccionado.idPersona.ToString();
                txtNombreMesero.Text = meseroSeleccionado.nombre + " " + meseroSeleccionado.apellidoPaterno;
            }
        }

        private void btnBuscarCajero_Click(object sender, EventArgs e)
        {
            frmGestionEmpleadosBusquedaEmpleado formBuscarCajero = new frmGestionEmpleadosBusquedaEmpleado("Cajero");
            if (formBuscarCajero.ShowDialog() is DialogResult.OK)
            {
                cajeroSeleccionado = new VentasWS.cajero();
                cajeroSeleccionado.idPersona = formBuscarCajero.EmpleadoSeleccionado.idPersona;
                cajeroSeleccionado.nombre = formBuscarCajero.EmpleadoSeleccionado.nombre;
                cajeroSeleccionado.apellidoPaterno = formBuscarCajero.EmpleadoSeleccionado.apellidoPaterno;
                ordenVentaActual.cajero = cajeroSeleccionado;
                txtIdCajero.Text = cajeroSeleccionado.idPersona.ToString();
                txtNombreCajero.Text = cajeroSeleccionado.nombre + " " + cajeroSeleccionado.apellidoPaterno; ;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = daoVentas.ModificarOrdenVenta(ordenVentaActual);
            if(resultado != 0)
            {
                MessageBox.Show("Orden de Venta actualizada.", "Exito de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
            else
            {
                MessageBox.Show("Error al actualizar Orden de Venta.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ordenVentaActual.mesa.disponible = true;


            daoVentas.EliminarOrdenVenta(ordenVentaActual.idOrdenVenta);

            ordenVentaActual.mesa.ordVen = null;

            daoVentas.ModificarMesaOrdenVenta(ordenVentaActual.mesa);

            txtCantidad.Enabled = false;
            txtDescuento.Enabled = false;

            MessageBox.Show("Orden de Venta Eliminada", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (itemSeleccionado != null)
            {
                VentasWS.lineaOrdenVenta auxLnOrdenVenta = new VentasWS.lineaOrdenVenta();

                auxLnOrdenVenta.fechaRegistroSpecified = true;
                auxLnOrdenVenta.fechaRegistro = DateTime.Now;
                auxLnOrdenVenta.activo = true;
                auxLnOrdenVenta.promocion = false;

                auxLnOrdenVenta.ordenVenta = ordenVentaActual;

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

                ordenVentaItems.Add(auxLnOrdenVenta);


                ordenVentaActual.total += auxLnOrdenVenta.subtotal;

                int resultado = daoVentas.ModificarOrdenVenta(ordenVentaActual);

                if (resultado == 0)
                {
                    MessageBox.Show("Error al actualizar Orden de Venta.", "Error Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvDetalleOrdenVenta.DataSource = ordenVentaItems;

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

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalleOrdenVenta.SelectedRows.Count == 1)
            {
                int auxId = ((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem).idLineaOrdenVenta;

                total -= ((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem).subtotal;
                ordenVentaActual.total = total;

                daoVentas.EliminarLineaOrdenVenta(auxId);
                ordenVentaItems.Remove((lineaOrdenVenta)dgvDetalleOrdenVenta.CurrentRow.DataBoundItem);

                dgvDetalleOrdenVenta.DataSource = ordenVentaItems;

                txtTotal.Text = String.Format("{0:0.00}", total);

                int resultado = daoVentas.ModificarOrdenVenta(ordenVentaActual);

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

        private void dgvDetalleOrdenVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtNombreCajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnDocumentoPago_Click(object sender, EventArgs e)
        {
            frmDocumentoPago formDocPago = new frmDocumentoPago("otro",null, ordenVentaActual);
            formDocPago.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }
    }
    
}
