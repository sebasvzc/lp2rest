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
    public partial class frmListarUsuariosA : Form
    {
        public frmListarUsuariosA()
        {
            InitializeComponent();
            dgvEmpleados.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvEmpleados.DataSource = daoEmpleado.listarPorDNINombre(txtDNINombre.Text);
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
         

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionUsuariosA frm = new frmGestionUsuariosA();
            frm.ShowDialog();
        }
    }
}
