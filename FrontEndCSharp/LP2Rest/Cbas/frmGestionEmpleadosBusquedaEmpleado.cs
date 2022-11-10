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
    public partial class frmGestionEmpleadosBusquedaEmpleado : Form
    {
        //Conexiones
        private GestPersonasWS.GestPersonasWSClient daoGestPersonas;

        //Utiles
        private empleado empleadoSeleccionado;

        public empleado EmpleadoSeleccionado { get => empleadoSeleccionado; set => empleadoSeleccionado = value; }

        public frmGestionEmpleadosBusquedaEmpleado()
        {
            EmpleadoSeleccionado = new empleado();

            List<string> listaCargos = new List<string>()
                    {
                        "Administrador",
                        "Recepcionista",
                        "Chef",
                        "Cajero",
                        "Mesero"
                    };
            

            InitializeComponent();
            daoGestPersonas = new GestPersonasWS.GestPersonasWSClient();
            dgvEmpleados.AutoGenerateColumns = false;

            cboArea.DataSource = listaCargos;
            

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime auxFechaIni = new DateTime();
            DateTime auxFechaFin = new DateTime();

            auxFechaIni = dtpFechaNacimientoIni.Value;
            auxFechaFin = dtpFechaNacimientoFin.Value;

            double auxSI, auxSF;

            if (txtSueldoIni.Text == "") { auxSI = 0.0;        } else { auxSI = Double.Parse(txtSueldoIni.Text); }
            if (txtSueldoFin.Text == "") { auxSF = 99999999.0; } else { auxSF = Double.Parse(txtSueldoFin.Text); }
            ;


            GestPersonasWS.empleado[] listaEmps = daoGestPersonas.ListarBusquedaEmpleados(
                                                                                            txtNombre.Text,
                                                                                            txtApellido.Text,
                                                                                            txtDNI.Text,
                                                                                            cboArea.SelectedValue.ToString(),                                                                                            
                                                                                            auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                            auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                            auxSI,
                                                                                            auxSF
                                                                                            );
            if(listaEmps != null)
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
            GestPersonasWS.empleado auxEmpleado = (GestPersonasWS.empleado)dgvEmpleados.Rows[e.RowIndex].DataBoundItem;
           
            dgvEmpleados.Rows[e.RowIndex].Cells[0].Value = auxEmpleado.DNI;
            dgvEmpleados.Rows[e.RowIndex].Cells[1].Value = auxEmpleado.nombre + " " + auxEmpleado.apellidoPaterno;
            if (auxEmpleado is administrador) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Administrador";
            if (auxEmpleado is recepcionista) dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Recepcionista";
            if (auxEmpleado is chef)          dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Chef";
            if (auxEmpleado is cajero)        dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Cajero";
            if (auxEmpleado is mesero)        dgvEmpleados.Rows[e.RowIndex].Cells[2].Value = "Mesero";
            dgvEmpleados.Rows[e.RowIndex].Cells[3].Value = auxEmpleado.telefono;
            dgvEmpleados.Rows[e.RowIndex].Cells[4].Value = auxEmpleado.email;


        }


        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 1)
            {
                empleado auxEmp = (empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                empleadoSeleccionado = auxEmp;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un empleado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionEmpleadosBusquedaEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
