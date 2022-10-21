using LP2Rest;
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
    public partial class frmPrincipalA : Form
    {
        public frmPrincipalA()
        {
            InitializeComponent();
        }

        private void imgClientes_Click(object sender, EventArgs e)
        {
            btnUusarios_Click(sender, e);
        }

        private void btnUusarios_Click(object sender, EventArgs e)
        {
            frmListarUsuariosA formListUsuariosA = new frmListarUsuariosA();
            if (formListUsuariosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            btnCompras_Click(sender, e);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            frmListarOrdenesCompra formListarOrdenesCompra = new frmListarOrdenesCompra();
            if (formListarOrdenesCompra.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgEspec_Click(object sender, EventArgs e)
        {
            btnEventos_Click(sender, e);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmListarEventosA formListEventosA = new frmListarEventosA();
            if (formListEventosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgPlatos_Click(object sender, EventArgs e)
        {
            btnPlatos_Click(sender, e);
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgInsumos_Click(object sender, EventArgs e)
        {
            btnInsumos_Click(sender, e);
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            frmListarInsumosA formListInsumosA = new frmListarInsumosA();
            if (formListInsumosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgVentas_Click(object sender, EventArgs e)
        {
            btnVentas_Click(sender, e);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmListarOrdenesVentaA formListVentasA = new frmListarOrdenesVentaA();
            if (formListVentasA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgReclamos_Click(object sender, EventArgs e)
        {
            btnReclamos_Click(sender, e);
        }

        private void btnReclamos_Click(object sender, EventArgs e)
        {
            frmListarReclamosA formListReclamosA = new frmListarReclamosA();
            if (formListReclamosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void imgReportes_Click(object sender, EventArgs e)
        {
            btnReportes_Click(sender, e);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //Falta implementar
            frmListarReportesA formListReportesA = new frmListarReportesA();
            if (formListReportesA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            pbAsistencia_Click( sender,  e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListarUsuariosA formListUsuariosA = new frmListarUsuariosA();
            if (formListUsuariosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frmListarOrdenesCompra formListarOrdenesCompra = new frmListarOrdenesCompra();
            if (formListarOrdenesCompra.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmListarEventosA formListEventosA = new frmListarEventosA();
            if (formListEventosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListarInsumosA formListInsumosA = new frmListarInsumosA();
            if (formListInsumosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmListarOrdenesVentaA formListVentasA = new frmListarOrdenesVentaA();
            if (formListVentasA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmListarReclamosA formListReclamosA = new frmListarReclamosA();
            if (formListReclamosA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmListarReportesA formListReportesA = new frmListarReportesA();
            if (formListReportesA.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void side_btnPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            if (formListarPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
