using LP2Rest.Gonzalo;
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
    public partial class frmPrincipalMesero : Form
    {
        private static Form formularioActivo = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        public frmPrincipalMesero()
        {
            InitializeComponent();
        }
        
        public void abrirFormulario(Form formularioMostrar)
        {
            if(formularioActivo != null)
              formularioActivo.Close();
            label1.Hide();
            formularioActivo = formularioMostrar;
            formularioMostrar.TopLevel = false;
            formularioMostrar.FormBorderStyle = FormBorderStyle.None;
            formularioMostrar.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioMostrar);
            formularioMostrar.Show();

        }
        private void imgUsuarios_Click(object sender, EventArgs e)
        {
            frmMesas formMesas = new frmMesas();
            formMesas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se registró la asistencia");
        }

        private void imgCompras_Click(object sender, EventArgs e)
        {
            frmListaOrdenVentaMesero formListaOrdenVenta = new frmListaOrdenVentaMesero();
            formListaOrdenVenta.ShowDialog();
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            btnAsistencia_Click( sender,  e);
        }

        private void imgPlatos_Click(object sender, EventArgs e)
        {
            frmListarPlatos formListarPlatos = new frmListarPlatos();
            formListarPlatos.ShowDialog();
        }

        private void sdbtnVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmListaOrdenVentaMesero());
        }

        private void sdbtnPlatos_Click(object sender, EventArgs e)
        {

            btnMesas.Hide();
            btnPlatos.Hide();
            btnVentas.Hide();
            abrirFormulario(new frmListarPlatosMesero());

        }

        private void sdbtnMesas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new frmMesas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }


        private void btnPlatos_Click(object sender, EventArgs e)
        {
            btnMesas.Hide();
            btnPlatos.Hide();
            btnVentas.Hide();
            abrirFormulario(new frmListarPlatosMesero());

        }
    }
}
