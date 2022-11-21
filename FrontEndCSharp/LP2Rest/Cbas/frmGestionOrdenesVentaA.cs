using LP2Rest;
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
    public partial class frmGestionOrdenesVentaA : Form
    {
        //Conexiones
        private VentasWS.VentasWSClient daoVentas;

        //Utiles
        private ordenVenta ordenVentaActual;
        private BindingList<lineaOrdenVenta> ordenVentaItems;
        private VentasWS.cliente clienteSeleccionado;
        private VentasWS.mesero meseroSeleccionado;
        private VentasWS.cajero cajeroSeleccionado;

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

            btnSeleccionarMesa.Enabled = true;

            txtCantidad.Enabled = true;
            txtDescuento.Enabled = true;

            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmGestionClientes formGestionClientes = new frmGestionClientes();
            formGestionClientes.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
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
            formBuscarMesero.ShowDialog();
        }
    }
}
