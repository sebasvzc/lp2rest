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

        public frmGestionOrdenesVentaA()
        {
            InitializeComponent();
        }
        public frmGestionOrdenesVentaA(ordenVenta auxOrdenVenta)
        {
            daoVentas = new VentasWSClient();

            ordenVentaActual = auxOrdenVenta;

            //lineaOrdenVenta[] aux = daoVentas.ListarBusquedaLineasOrdenVenta(ordenVentaActual.idOrdenVenta);
            //if (aux == null)
            //{
            //    ordenVentaItems = new BindingList<lineaOrdenVenta>();
            //}
            //else
            //{
            //    ordenVentaItems = new BindingList<lineaOrdenVenta>(aux.ToList());
            //}

            ordenVentaItems = new BindingList<lineaOrdenVenta>(daoVentas.ListarBusquedaLineasOrdenVenta(ordenVentaActual.idOrdenVenta).ToList() );
            

            InitializeComponent();

            dgvDetalleOrdenVenta.DataSource = ordenVentaItems;

            dgvDetalleOrdenVenta.AutoGenerateColumns = true;

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
    }
}
