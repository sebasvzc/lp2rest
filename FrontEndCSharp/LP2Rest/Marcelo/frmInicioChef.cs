using LP2Rest.GestPersonasWS;
using LP2Rest.Gonzalo;
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
    public partial class frmInicioChef : Form
    {
        private GestPersonasWS.asistencia _asistencia;
        private GestPersonasWS.GestPersonasWSClient _daoAsistencia;
        public frmInicioChef()
        {
            InitializeComponent();
            _asistencia = new GestPersonasWS.asistencia();
            _daoAsistencia = new GestPersonasWS.GestPersonasWSClient();
            
            pbSalida.Hide();
            lblSalida.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            pbPlatos_Click(sender, e);
        }

        private void pbPlatos_Click(object sender, EventArgs e)
        {
            frmBusquedaReceta formPlatos = new frmBusquedaReceta();
            if (formPlatos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbInsumos_Click(object sender, EventArgs e)
        {
            frmBusquedaInsumos formInsumos = new frmBusquedaInsumos();
            if (formInsumos.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void lblInsumos_Click(object sender, EventArgs e)
        {
            pbInsumos_Click(sender, e);
        }

        private void pbSolicitudCompras_Click(object sender, EventArgs e)
        {
            frmSolicitudesCompras formSolCompras = new frmSolicitudesCompras();
            if (formSolCompras.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pbAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            string resultado = "";
            frmValidarAsistencia formValidarAsistencia = new frmValidarAsistencia();
            if (formValidarAsistencia.ShowDialog() == DialogResult.OK)
            {

                resultado = formValidarAsistencia.Estado;
            }
            if (resultado == "Aceptado")
            {
                //Insertar la asistencia
                DateTime ingreso = DateTime.Now;

                string date_str = ingreso.ToString("yyyy/MM/dd");
                string hora_str = ingreso.ToString("HH:mm:ss");
                _asistencia.fechaIngreso = date_str;
                _asistencia.horaIngreso = hora_str;


                //Se asume (momentaneamente) que el admin tiene idCuentaUsuario = 4 
                _asistencia.idCuentaUsuario = 2;

                MessageBox.Show("Se registró la asistencia");
                pbAsistencia.Hide();
                lblAsistencia.Hide();
                pbSalida.Show();
                lblSalida.Show();

            }
        }

        private void lblSalida_Click(object sender, EventArgs e)
        {
            string resultado = "";
            frmValidarAsistencia formValidarAsistencia = new frmValidarAsistencia();
            if (formValidarAsistencia.ShowDialog() == DialogResult.OK)
            {
                resultado = formValidarAsistencia.Estado;
            }
            if (resultado == "Aceptado")
            {
                //Insertar la fecha de registro

                //Se registra el empleado utilizando el DAO de conexión

                int resultadoInsercion = 0;
                // Para registrar la salida
                DateTime salida = DateTime.Now;

                string date_str = salida.ToString("yyyy/MM/dd");
                string hora_str = salida.ToString("HH:mm:ss");
                _asistencia.fechaSalida = date_str;
                _asistencia.horaSalida = hora_str;


                resultadoInsercion = _daoAsistencia.insertarAsistencia(_asistencia);
                if (resultadoInsercion != 0)
                {
                    MessageBox.Show("Se registró exitosamente la salida");
                    lblSalida.Hide();
                    pbSalida.Hide();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al momento de registrar la salida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }
    }
}
