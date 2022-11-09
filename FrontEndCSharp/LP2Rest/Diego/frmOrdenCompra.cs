using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Diego
{
    public partial class frmOrdenCompra : Form
    {
        private AlmacenWS.AlmacenWSClient daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
        private AlmacenWS.lineaOrdenCompra[] _lineaordenCompra;
        private AlmacenWS.ordenCompra _ordenCompraNuevo;
        //private AlmacenWS.ordenCompra _ordenCompra;
        private AlmacenWS.insumo _insumo;

        private BindingList<AlmacenWS.lineaOrdenCompra> _lineaOrdenComprainsumos;
        private AlmacenWS.lineaOrdenCompra _lineaOrdenCompraNuevo;
        private String estadoActual;
        private GestPersonasWS.proveedor _proveedor;
        public frmOrdenCompra()
        {
            daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
            InitializeComponent();
            _ordenCompraNuevo = new AlmacenWS.ordenCompra();
            _lineaOrdenComprainsumos = new BindingList<AlmacenWS.lineaOrdenCompra>();
            dgvLineaOrdenCompra.AutoGenerateColumns = false;
            dgvLineaOrdenCompra.DataSource = _lineaOrdenComprainsumos;
            estadoActual = "Nuevo";
            txtOrdenCompra.Enabled = false;
            txtProducto.Enabled = false;
            txtMonto.Enabled = false;
            txtProveedor.Enabled = false;
            txtEstado.Enabled = false;
            txtEstado.Visible = false;
            lblTitulo.Text = "Nueva Solicitud de Orden de Compra";
        }
        public frmOrdenCompra(String tipo, AlmacenWS.ordenCompra oc)
        {
            daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
            InitializeComponent();
            _ordenCompraNuevo = new AlmacenWS.ordenCompra();
            dgvLineaOrdenCompra.AutoGenerateColumns = false;
            if (tipo == "Ver")
            {
                _lineaordenCompra = daoGestAlmacen.ListarLineasOrdenCompra(oc.idOrdenCompra);
                dgvLineaOrdenCompra.DataSource = _lineaordenCompra;
                txtOrdenCompra.Text = "OC" + string.Format("{0:D5}", oc.idOrdenCompra);
                txtProveedor.Text = oc.proveedor.razonSocial;
                txtEstado.Text = oc.estado;
                txtMonto.Text = oc.total.ToString("N2");
                txtDescripcion.Text = oc.descripcion;
                dtpFechaRegistro.Value = oc.fechaHoraCumplimiento;
                dtpFechaCumplimiento.Value = oc.fechaHoraCumplimiento;
                estadoActual = "Ver";
                txtOrdenCompra.Enabled = false;
                txtProducto.Enabled = false;
                txtMonto.Enabled = false;
                txtProveedor.Enabled = false;
                txtEstado.Enabled = false;
                btnBuscarProveedor.Visible = false;
                btnAgregarInsumo.Visible = false;
                btnEliminarInsumo.Visible = false;
                btnBuscarProducto.Visible = false;

                txtCantidad.Visible = false;
                txtProducto.Visible = false;
                dtpFechaVencimiento.Visible = false;
                txtPrecioUnitario.Visible = false;
                lblCantidad.Visible = false;
                lblFecha.Visible = false;
                lblPrecio.Visible = false;
                lblProducto.Visible = false;
                groupBox1.Location = new Point(75, 236);
                lblTitulo.Text = "Detalle de Solicitud de Orden de Compra";
                btnGuardar.Visible = false;
                btnCancelar.Visible = false;
                toolStrip1.Visible = false;
                dtpFechaRegistro.Enabled = false;
                dtpFechaCumplimiento.Enabled = false;
                txtDescripcion.Enabled = false;

            }
            if (tipo == "Modificar")
            {


                _lineaOrdenComprainsumos = new BindingList<AlmacenWS.lineaOrdenCompra>();
                //_lineaOrdenComprainsumos =(daoGestAlmacen.ListarLineasOrdenCompra(oc.idOrdenCompra));
                dgvLineaOrdenCompra.AutoGenerateColumns = false;
                dgvLineaOrdenCompra.DataSource = _lineaOrdenComprainsumos;

                txtOrdenCompra.Text = "OC" + string.Format("{0:D5}", oc.idOrdenCompra);
                txtProveedor.Text = oc.proveedor.razonSocial;
                txtEstado.Text = oc.estado;
                txtMonto.Text = oc.total.ToString("N2");
                txtDescripcion.Text = oc.descripcion;
                dtpFechaRegistro.Value = oc.fechaHoraCumplimiento;
                dtpFechaCumplimiento.Value = oc.fechaHoraCumplimiento;
                estadoActual = "Modificar";
                txtOrdenCompra.Enabled = false;
                txtProducto.Enabled = false;
                txtMonto.Enabled = false;
                txtProveedor.Enabled = false;
                txtEstado.Enabled = false;
            }

        }

        private void dgvLineaOrdenCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                AlmacenWS.lineaOrdenCompra lineaOrdenCompra = (AlmacenWS.lineaOrdenCompra)dgvLineaOrdenCompra.Rows[e.RowIndex].DataBoundItem;
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[0].Value = lineaOrdenCompra.insumo.SKU;
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[1].Value = lineaOrdenCompra.insumo.nombre;
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[2].Value = lineaOrdenCompra.precioUnitario;
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[3].Value = lineaOrdenCompra.cantidad;
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[4].Value = (lineaOrdenCompra.precioUnitario * lineaOrdenCompra.cantidad);
                dgvLineaOrdenCompra.Rows[e.RowIndex].Cells[5].Value = lineaOrdenCompra.fechaVencimiento.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarInsumo_Click(object sender, EventArgs e)
        {
            _lineaOrdenCompraNuevo = new AlmacenWS.lineaOrdenCompra();
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Debe seleecionar un producto para agregar a la orden de compra", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _lineaOrdenCompraNuevo.insumo = new AlmacenWS.insumo();
            _lineaOrdenCompraNuevo.insumo.idInsumo = _insumo.idInsumo;
            _lineaOrdenCompraNuevo.insumo.SKU = _insumo.SKU;
            _lineaOrdenCompraNuevo.insumo.nombre = _insumo.nombre;
            if (txtPrecioUnitario.Text == "")
            {
                MessageBox.Show("Debe seleecionar el Precio Unitario del producto a agregar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _lineaOrdenCompraNuevo.precioUnitario = Double.Parse(txtPrecioUnitario.Text);
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debe seleecionar la cantidad del producto a agregar", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _lineaOrdenCompraNuevo.cantidad = Double.Parse(txtCantidad.Text);
            _lineaOrdenCompraNuevo.fechaVencimientoSpecified = true;
            _lineaOrdenCompraNuevo.fechaVencimiento = dtpFechaVencimiento.Value;
            _lineaOrdenComprainsumos.Add(_lineaOrdenCompraNuevo);
            txtProducto.Text = "";

            double montoActual;
            if (txtMonto.Text == "") montoActual = 0;
            else montoActual = Double.Parse(txtMonto.Text);

            txtMonto.Text = (montoActual + (Double.Parse(txtCantidad.Text)) * (Double.Parse(txtPrecioUnitario.Text))).ToString("N2");
            txtPrecioUnitario.Text = "";
            txtCantidad.Text = "";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmListarInsumosA formBusqInsumos = new frmListarInsumosA("Seleccionar");
            if (formBusqInsumos.ShowDialog() == DialogResult.OK)
            {
                _insumo = formBusqInsumos.InsumoSeleccionado;
                txtProducto.Text = "["+_insumo.SKU + "] " + _insumo.nombre;}
                
            }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _ordenCompraNuevo.descripcion = txtDescripcion.Text;
            _ordenCompraNuevo.fechaHoraCreacionSpecified = true;
            _ordenCompraNuevo.fechaHoraCumplimientoSpecified = true;
            _ordenCompraNuevo.fechaHoraCumplimiento = dtpFechaCumplimiento.Value;
            _ordenCompraNuevo.fechaHoraCreacion = dtpFechaRegistro.Value;
            _ordenCompraNuevo.proveedor = new AlmacenWS.proveedor();
            _ordenCompraNuevo.proveedor.idPersona = _proveedor.idPersona;
            _ordenCompraNuevo.total = Double.Parse(txtMonto.Text);
            _ordenCompraNuevo.lineasOrdenCompra = _lineaOrdenComprainsumos.ToArray();
            if (estadoActual == "Nuevo")
            {
                int resultado = daoGestAlmacen.InsertarOrdenCompra(_ordenCompraNuevo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado exitosamente la orden de compra", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrdenCompra.Text = resultado.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al registrar la oredn de compra", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (estadoActual == "Modificar")
            {
                //int resultado = daoGestAlmacen.ModificarOrdenCompra(_ordenCompraNuevo);
                /*if (resultado != 0)
                {
                    MessageBox.Show("Se ha registrado exitosamente la orden de compra", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOrdenCompra.Text = resultado.ToString();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al registrar la oredn de compra", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor formBuscarProveedor = new frmBuscarProveedor();
            if (formBuscarProveedor.ShowDialog() == DialogResult.OK)
            {
                _proveedor = formBuscarProveedor.ProveedorSeleccionada;
                txtProveedor.Text = _proveedor.razonSocial;
            }
        }
    }
}
