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
    public partial class frmMesas : Form
    {
        private int idMesa;

        public int IdMesa { get => idMesa; set => idMesa = value; }

        public frmMesas()
        {
            InitializeComponent();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            IdMesa = 1;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa1.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            IdMesa = 8;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa8.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            IdMesa = 2;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa2.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            IdMesa = 3;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa3.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            IdMesa = 4;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa4.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            IdMesa = 5;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa5.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            IdMesa = 6;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa6.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            IdMesa = 7;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa7.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            IdMesa = 9;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa9.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            IdMesa = 10;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa10.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            IdMesa = 11;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa11.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            IdMesa = 12;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(IdMesa);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
                btnMesa12.BackColor = Color.FromArgb(255, 128, 128);
            }
        }
    }
}
