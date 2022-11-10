﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Rest.Omar
{
    public partial class frmModificarPlato : Form
    {
        private AlmacenWS.insumo[] insumos;
        private MenuWS.MenuWSClient daoMenu;
        private AlmacenWS.AlmacenWSClient daoAlmacen;
        private MenuWS.itemVenta itemVenta; 
        private MenuWS.itemVenta[] lineasCombo;
        private double total = 0;
        private int tipoItemVenta;
        public frmModificarPlato()
        {
            InitializeComponent();
        }

        public frmModificarPlato(MenuWS.itemVenta platoModificar)
        {
            InitializeComponent();
            tipoItemVenta = platoModificar.tipoItem.idTipoItem;
            cbDisponible.Items.Add("Disponible");
            cbDisponible.Items.Add("Agotado");
            
            if(platoModificar.disponible == 1)
                cbDisponible.SelectedItem = cbDisponible.Items[0];
            else
                cbDisponible.SelectedItem = cbDisponible.Items[1];
            daoMenu = new MenuWS.MenuWSClient();
            daoAlmacen = new AlmacenWS.AlmacenWSClient();
            dgvInsumos.AutoGenerateColumns = false;

            txtIdPlato.Text = platoModificar.idItemVenta.ToString();
            txtNombrePlato.Text = platoModificar.nombre;
            txtStock.Text = platoModificar.stock.ToString();
            txtPrecioVenta.Text = platoModificar.precio.ToString("N2");
            txtDescuento.Text = platoModificar.descuento.ToString("N2");

            if (tipoItemVenta == 3)
            {
                txtReceta.Visible = false;
                lblReceta.Visible = false;
                try{
                    lineasCombo = daoMenu.listarLineasComboXIdCombo(platoModificar.idItemVenta).ToArray();
                    dgvInsumos.DataSource = lineasCombo.ToList();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                foreach (MenuWS.itemVenta iv in lineasCombo)
                {
                    total += iv.stock * iv.precio;
                }
                txtTotal.Text = total.ToString("N2");
            }
            else
            {
                try //No funciona
                {
                    insumos = daoAlmacen.listarInsumosPorIdItemVenta(platoModificar.idItemVenta).ToArray();
                    dgvInsumos.DataSource = insumos.ToList();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                txtReceta.Text = platoModificar.recetaDePreparacion;
                foreach (AlmacenWS.insumo insumo in insumos)
                {
                    total += insumo.stock * insumo.precioCompra;
                }
                txtTotal.Text = total.ToString("N2");
            }
        }

        private void dgvInsumos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if(tipoItemVenta != 3)
                {
                    AlmacenWS.insumo insumo = (AlmacenWS.insumo)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
                    dgvInsumos.Rows[e.RowIndex].Cells[0].Value = insumo.SKU;
                    dgvInsumos.Rows[e.RowIndex].Cells[1].Value = insumo.nombre;
                    dgvInsumos.Rows[e.RowIndex].Cells[2].Value = insumo.stock.ToString();
                    dgvInsumos.Rows[e.RowIndex].Cells[3].Value = insumo.precioCompra.ToString("N2");
                    dgvInsumos.Rows[e.RowIndex].Cells[4].Value = (insumo.precioCompra * insumo.stock).ToString("N2");
                }
                else
                {
                    MenuWS.itemVenta lineaCombo = (MenuWS.itemVenta)dgvInsumos.Rows[e.RowIndex].DataBoundItem;
                    dgvInsumos.Rows[e.RowIndex].Cells[0].Value = lineaCombo.idItemVenta;
                    dgvInsumos.Rows[e.RowIndex].Cells[1].Value = lineaCombo.nombre;
                    dgvInsumos.Rows[e.RowIndex].Cells[2].Value = lineaCombo.stock.ToString();
                    dgvInsumos.Rows[e.RowIndex].Cells[3].Value = lineaCombo.precio.ToString("N2");
                    dgvInsumos.Rows[e.RowIndex].Cells[4].Value = (lineaCombo.precio * lineaCombo.stock).ToString("N2");
                }
                
            }
            catch (Exception ex)
            {

            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            itemVenta = new MenuWS.itemVenta();
            itemVenta.idItemVenta = Int32.Parse(txtIdPlato.Text);
            itemVenta.nombre = txtNombrePlato.Text;
            itemVenta.stock = Int32.Parse(txtStock.Text);
            itemVenta.descuento = Double.Parse(txtDescuento.Text);
            itemVenta.precio = Double.Parse(txtTotal.Text) + Double.Parse(txtGanancia.Text) - itemVenta.descuento;
            if(tipoItemVenta != 3)
                itemVenta.recetaDePreparacion = txtReceta.Text;
            if (cbDisponible.SelectedItem.ToString() == "Disponible")
                itemVenta.disponible = 1;
            else
                itemVenta.disponible = 0;
            if(itemVenta.precio <= 0)
                MessageBox.Show("ERROR: El precio del producto se está modificando como negativo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int resultado = daoMenu.ModificarItemVenta(itemVenta);
                if (resultado != 0)
                {
                    txtPrecioVenta.Text = itemVenta.precio.ToString("N2");
                    MessageBox.Show("Se ha modificado exitosamente el producto", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de modificar el producto", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
