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
    public partial class frmCajero : Form
    {
        public frmCajero()
        {
            InitializeComponent();
        }

        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            frmMesas formMesas = new frmMesas();
            formMesas.ShowDialog();
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmListaOrdenVenta formListaOrdenVenta = new frmListaOrdenVenta();
            formListaOrdenVenta.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }
    }
}
