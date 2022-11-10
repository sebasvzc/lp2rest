﻿using System;
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
    public partial class frmListaOrdenVentaMesero : Form
    {
        //Conexiones
        private VentasWS.VentasWSClient daoVentas;

        public frmListaOrdenVentaMesero()
        {
            daoVentas = new VentasWS.VentasWSClient();

            InitializeComponent();

            dgvVentas.AutoGenerateColumns = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime auxFechaIni = new DateTime();
            DateTime auxFechaFin = new DateTime();

            auxFechaIni = dtpFechaIni.Value;
            auxFechaFin = dtpFechaFin.Value;

            double auxSI, auxSF;

            if (txtMontoIni.Text == "") { auxSI = 0.0; } else { auxSI = Double.Parse(txtMontoIni.Text); }
            if (txtMontoFin.Text == "") { auxSF = 99999999.0; } else { auxSF = Double.Parse(txtMontoFin.Text); }
            ;


            VentasWS.ordenVenta[] listaVentas = daoVentas.listarBusquedaOrdenesVenta(
                                                                                    txtNombre.Text,
                                                                                    txtApellido.Text,
                                                                                    auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                    auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                    auxSI,
                                                                                    auxSF
                                                                                    );
            if (listaVentas != null)
            {
                dgvVentas.DataSource = listaVentas;
            }
            else
            {
                MessageBox.Show("No se ha encontrado empleados", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            VentasWS.ordenVenta auxVenta = (VentasWS.ordenVenta)dgvVentas.Rows[e.RowIndex].DataBoundItem;
            dgvVentas.Rows[e.RowIndex].Cells[0].Value = auxVenta.idOrdenVenta.ToString();
            dgvVentas.Rows[e.RowIndex].Cells[1].Value = auxVenta.cliente.nombre + " " + auxVenta.cliente.apellidoPaterno;
            dgvVentas.Rows[e.RowIndex].Cells[2].Value = auxVenta.fecha.ToShortDateString();
            dgvVentas.Rows[e.RowIndex].Cells[3].Value = String.Format("{0:0.00}", auxVenta.total);
        }
    }
}
