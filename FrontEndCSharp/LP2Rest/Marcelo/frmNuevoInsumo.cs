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
    public partial class frmNuevoInsumo : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private AlmacenWS.AlmacenWSClient daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
        private AlmacenWS.insumo insumoNuevo;
        //private MenuWS.tipoProducto tipoProductoNuevo;

        private string _estado;

        public frmNuevoInsumo()
        {
            InitializeComponent();
            _estado = "Nuevo";
            lblTitulo.Text = "Crear nuevo Insumo";
            //daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            insumoNuevo = new AlmacenWS.insumo();

            cbTipoProducto.DataSource = daoGestAlmacen.ListarTipoProducto();
            cbTipoProducto.DisplayMember = "nombre";
            cbTipoProducto.ValueMember = "idTipoProducto";
            var umedidas = Enum.GetValues(typeof(AlmacenWS.unidadMedida));
            cbUnidadMedida.DataSource = umedidas;
            //cbUnidadMedida.DisplayMember = "KG";
        }

        public frmNuevoInsumo(AlmacenWS.insumo insumoModificar)
        {
            InitializeComponent();
            insumoNuevo = new AlmacenWS.insumo();
            _estado = "Modificar";
            lblTitulo.Text = "Modificar Insumo";
            cbTipoProducto.DataSource = daoGestAlmacen.ListarTipoProducto();
            cbTipoProducto.DisplayMember = "nombre";
            cbTipoProducto.ValueMember = "idTipoProducto";
            cbTipoProducto.SelectedItem = insumoModificar.tipoProducto;
            cbUnidadMedida.DataSource = Enum.GetValues(typeof(AlmacenWS.unidadMedida));
            cbUnidadMedida.SelectedItem = insumoModificar.unidadMedida;
            insumoNuevo.idInsumo = insumoModificar.idInsumo;
            txtbNombre.Text = insumoModificar.nombre;
            txtDescripcion.Text = insumoModificar.descripcion;
            txtSKU.Text = insumoModificar.SKU;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            insumoNuevo.SKU = txtSKU.Text;
            insumoNuevo.descripcion = txtDescripcion.Text;
            insumoNuevo.nombre = txtbNombre.Text;
            insumoNuevo.stock = 0;
            insumoNuevo.precioCompra = 0;
            insumoNuevo.tipoProducto = (AlmacenWS.tipoProducto)cbTipoProducto.SelectedItem;

            AlmacenWS.unidadMedida enumedida = (AlmacenWS.unidadMedida)cbUnidadMedida.SelectedItem;
            insumoNuevo.unidadMedidaSpecified = true;
            insumoNuevo.unidadMedida = enumedida;

            if (_estado == "Modificar")
            {
                resultado = daoGestAlmacen.ModificarInsumo(insumoNuevo);
                if (resultado != 0)
                {
                    MessageBox.Show("Se ha modificado exitosamente el insumo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de modificar el insumo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_estado == "Nuevo")
            {
                //Borrar:

                resultado = daoGestAlmacen.InsertarInsumo(insumoNuevo);
                if (resultado != 0)
                {

                    MessageBox.Show("Se ha registrado exitosamente el insumo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar el insumo por el " + insumoNuevo.unidadMedida, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}