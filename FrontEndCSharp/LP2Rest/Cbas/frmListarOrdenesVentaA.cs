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
    public partial class frmListarOrdenesVentaA : Form
    {
        //Conexiones
        private VentasWS.VentasWSClient daoVentas;

        //Utiles
        private ordenVenta[] ordenesVentasActuales;
        private ordenVenta ordenVentaSeleccionada;

        private void inicializacion()
        {
            daoVentas = new VentasWS.VentasWSClient();

            InitializeComponent();

            dgvOrdenesVentas.AutoGenerateColumns = false;

            btnNuevo.Enabled = false;
        }

        public frmListarOrdenesVentaA()
        {
            inicializacion();
        }

        public frmListarOrdenesVentaA(bool mostrarNuevo)
        {
            inicializacion();
            if (!mostrarNuevo)
            {
                //btnNuevo.Hide();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionOrdenesVentaA formGestionOrdenesVentaA = new frmGestionOrdenesVentaA();
            formGestionOrdenesVentaA.ShowDialog();
        }

        private void btnBuscar_click(object sender, EventArgs e)
        {
            DateTime auxFechaIni = new DateTime();
            DateTime auxFechaFin = new DateTime();
            
            auxFechaIni = dtpFechaIni.Value;
            auxFechaFin = dtpFechaFin.Value;

            double totalIni, totalFin;
            if(txtTotalIni.Text == "")
            {
                totalIni = 0.0;
            }
            else
            {
                totalIni = Double.Parse(txtTotalIni.Text);
            }
            if (txtTotalFin.Text == "")
            {
                totalFin = 99999.9;
            }
            else
            {
                totalFin = Double.Parse(txtTotalFin.Text);
            }


            ordenesVentasActuales = daoVentas.listarBusquedaOrdenesVentaAdministrador(  txtNombCli.Text,
                                                                                        txtApeCLi.Text,
                                                                                        auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                        auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                        totalIni,
                                                                                        totalFin
                                                                                        );
            if(ordenesVentasActuales == null)
            {
                MessageBox.Show("No se ha encontrado Ordenes de Venta", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvOrdenesVentas.DataSource = null;
            }
            else
            {
                dgvOrdenesVentas.DataSource = ordenesVentasActuales;
            }
        }

        private void dgvOrdenesVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            try{
                ordenVenta auxOrdVent = (ordenVenta)dgvOrdenesVentas.Rows[e.RowIndex].DataBoundItem;

                dgvOrdenesVentas.Rows[e.RowIndex].Cells[0].Value = auxOrdVent.idOrdenVenta.ToString();
                dgvOrdenesVentas.Rows[e.RowIndex].Cells[1].Value = auxOrdVent.cliente.nombre + " " + auxOrdVent.cliente.apellidoPaterno;
                dgvOrdenesVentas.Rows[e.RowIndex].Cells[2].Value = auxOrdVent.fecha.ToShortDateString();
                dgvOrdenesVentas.Rows[e.RowIndex].Cells[3].Value = String.Format("{0:0.00}", auxOrdVent.total );
                dgvOrdenesVentas.Rows[e.RowIndex].Cells[4].Value = auxOrdVent.estado;

            }
            catch(Exception ex)
            {

            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvOrdenesVentas.SelectedRows.Count == 1)
            {
                ordenVentaSeleccionada = new ordenVenta();

                ordenVentaSeleccionada = (ordenVenta)dgvOrdenesVentas.CurrentRow.DataBoundItem;

                frmGestionOrdenesVentaA formOrdVenAdmin = new frmGestionOrdenesVentaA(ordenVentaSeleccionada);

                if(formOrdVenAdmin.ShowDialog() == DialogResult.OK)
                {
                    btnBuscar_click(sender,e);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvOrdenesVentas.SelectedRows.Count == 1)
            {
                ordenVenta aux = (ordenVenta)dgvOrdenesVentas.CurrentRow.DataBoundItem;
                int resultado = daoVentas.EliminarOrdenVenta(aux.idOrdenVenta);
                if(resultado != 0)
                {
                    MessageBox.Show("Borrado de Orden de Venta exitoso.", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_click(sender,e);
                }
                else
                {
                    MessageBox.Show("Error al borrar Orden de Venta", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una Orden de Venta", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
