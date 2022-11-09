﻿using LP2Rest.Diego;
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
    public partial class frmSolicitudesCompras : Form
    {
        private AlmacenWS.insumo _insumo;
        private AlmacenWS.AlmacenWSClient daoGestAlmacen;

        private AlmacenWS.ordenCompra ordenCompraSeleccionado;
        public frmSolicitudesCompras()
        {
            daoGestAlmacen = new AlmacenWS.AlmacenWSClient();
            InitializeComponent();
            txtSKU.Enabled = false;
            txtNombre.Enabled = false;
            dgvOrdenCompras.AutoGenerateColumns = false;
        }


        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarInsumo_Click(object sender, EventArgs e)
        {
            frmListarInsumosA frmBuscarInsumosA = new frmListarInsumosA("string");
            if (frmBuscarInsumosA.ShowDialog() == DialogResult.OK)
            {
                _insumo = frmBuscarInsumosA.InsumoSeleccionado;
                txtSKU.Text = _insumo.SKU;
                txtNombre.Text = _insumo.nombre;
                //txtNombreCompletoActor.Text = _actor.nombre + " " + _actor.apellidoPaterno;*/
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double montoMin, montoMax;
            int idInsumo, idOrden;
            if (txtMontoMin.Text == "") montoMin = -1;
            else montoMin = Double.Parse(txtMontoMin.Text);

            if (txtMontoMax.Text == "") montoMax = -1;
            else montoMax = Double.Parse(txtMontoMax.Text);
            if (txtSKU.Text == "") idInsumo = -1;
            else idInsumo = _insumo.idInsumo;


            if (txtNumOrden.Text == "") idOrden = -1;
            else idOrden = Int32.Parse(txtNumOrden.Text);

            AlmacenWS.ordenCompra[] ordenCompras = daoGestAlmacen.FiltrarOrdenCompra(idOrden, dtpFechaMaxRegistro.Value,
                dtpFechaMinRegistro.Value, montoMax,
                montoMin, idInsumo);
            if (ordenCompras != null)
                dgvOrdenCompras.DataSource = ordenCompras.ToList();
            else
            {
                dgvOrdenCompras.DataSource = null;
                MessageBox.Show("No se ha encontrado ninguna orden de compra con el filtro seleccionado", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVerOC_Click(object sender, EventArgs e)
        {
            if (dgvOrdenCompras.CurrentRow != null)
            {
                ordenCompraSeleccionado = (AlmacenWS.ordenCompra)dgvOrdenCompras.CurrentRow.DataBoundItem;
                // MessageBox.Show("Se va modificar el " + insumoSeleccionado.i, "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmOrdenCompra frm = new frmOrdenCompra("Ver", ordenCompraSeleccionado);
                if (frm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmOrdenCompra frm = new frmOrdenCompra();
            frm.ShowDialog();
        }

        private void dgvOrdenCompras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AlmacenWS.ordenCompra ordenCompra = (AlmacenWS.ordenCompra)
                dgvOrdenCompras.Rows[e.RowIndex].DataBoundItem;
            dgvOrdenCompras.Rows[e.RowIndex].Cells[0].Value = "OC" + string.Format("{0:D5}", ordenCompra.idOrdenCompra);
            dgvOrdenCompras.Rows[e.RowIndex].Cells[1].Value = ordenCompra.proveedor.razonSocial;
            dgvOrdenCompras.Rows[e.RowIndex].Cells[2].Value = ordenCompra.fechaHoraCreacion.Date.ToString("dd/MM/yyyy");
            dgvOrdenCompras.Rows[e.RowIndex].Cells[3].Value = ordenCompra.fechaHoraCumplimiento.Date.ToString("dd/MM/yyyy");
            dgvOrdenCompras.Rows[e.RowIndex].Cells[4].Value = ordenCompra.total.ToString("N2");
            dgvOrdenCompras.Rows[e.RowIndex].Cells[5].Value = ordenCompra.estado;
        }
    }
}
