using LP2Rest.GestPersonasWS;
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
    public partial class frmListarUsuariosA : Form
    {
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;
        private GestPersonasWS.empleado _empleadoSeleccionado;
        public frmListarUsuariosA()
        {
            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            _empleadoSeleccionado = new GestPersonasWS.empleado();
            dgvEmpleados.AutoGenerateColumns = false;

            List<string> listaCargos = new List<string>()
                    {
                        "Administrador",
                        "Recepcionista",
                        "Chef",
                        "Cajero",
                        "Mesero"
                    };

            cboArea.DataSource = listaCargos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dgvEmpleados.DataSource = daoGestPersonas.ListarBusquedaEmpleados(txtNombre.Text, txtApellidoPaterno.Text, txtDNI.Text,
            //  cboArea.SelectedValue.ToString(), dtpFechaDesde.Value.ToString(), dtpFechaHasta.Value.ToString(), 
            // Double.Parse(txtSueldoDesde.Text), Double.Parse(txtSueldaHasta.Text));
            //dgvEmpleados.DataSource = daoGestPersonas.ListarTodosEmpleados();
            DateTime auxFechaIni = new DateTime();
            DateTime auxFechaFin = new DateTime();

            auxFechaIni = dtpFechaDesde.Value;
            auxFechaFin = dtpFechaHasta.Value;

            double auxSI, auxSF;

            if (txtSueldoDesde.Text == "") { auxSI = 0.0; } else { auxSI = Double.Parse(txtSueldoDesde.Text); }
            if (txtSueldaHasta.Text == "") { auxSF = 99999999.0; } else { auxSF = Double.Parse(txtSueldaHasta.Text); }
            ;


            GestPersonasWS.empleado[] listaEmps = daoGestPersonas.ListarBusquedaEmpleados(
                                                                                            txtNombre.Text,
                                                                                            txtApellidoPaterno.Text,
                                                                                            txtDNI.Text,
                                                                                            cboArea.SelectedValue.ToString(),
                                                                                            auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                            auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                            auxSI,
                                                                                            auxSF
                                                                                            );
            if (listaEmps != null)
            {
                dgvEmpleados.DataSource = listaEmps;
            }
            else
            {
                MessageBox.Show("No se ha encontrado empleados", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GestPersonasWS.empleado empleado = (GestPersonasWS.empleado)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = empleado.DNI;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = empleado.nombre + " " + empleado.apellidoPaterno;
            //falta implementar
            //if (empleado.cuentaUsuario.tipoEmpleado == 'A')
            //{
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Administrador";
            //}
            //else if (empleado.cuentaUsuario.tipoEmpleado == 'C')
            //{
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Cajero";
            //}
            //else if (empleado.cuentaUsuario.tipoEmpleado == 'M')
            //{
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Mesero";
            //}
            //else if (empleado.cuentaUsuario.tipoEmpleado == 'R')
            //{
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Repartidor";
            //}
            //else if (empleado.cuentaUsuario.tipoEmpleado == 'F')
            //{
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Chef";
            //}
            //else {
            //    dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "No definido";
            //}
            if (empleado is administrador) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Administrador";
            if (empleado is recepcionista) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Recepcionista";
            if (empleado is chef) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Chef";
            if (empleado is cajero) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Cajero";
            if (empleado is mesero) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Mesero";
            dgvEmpleados.Rows[e.RowIndex].Cells[3].Value = empleado.telefono;
            dgvEmpleados.Rows[e.RowIndex].Cells[4].Value = empleado.email;


        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionUsuariosA formGestionUsuariosA = new frmGestionUsuariosA();
            if (formGestionUsuariosA.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            _empleadoSeleccionado = (GestPersonasWS.empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            txtNombre.Text = _empleadoSeleccionado.nombre;
            txtApellidoPaterno.Text = _empleadoSeleccionado.apellidoPaterno;
            txtDNI.Text = _empleadoSeleccionado.DNI;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _empleadoSeleccionado = (GestPersonasWS.empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            //daoGestPersonas(_empleadoSeleccionado);
        }
    }
}
