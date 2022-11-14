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
    public partial class frmListarReclamosA : Form
    {

        //Utiles
        GestPersonasWS.GestPersonasWSClient daoGestionPersonas;


        //Otros
        reclamo auxRec;

        public reclamo AuxRec { get => auxRec; set => auxRec = value; }

        //Clase Estado
        public class Estado
        {
            private string descEst;
            private int valor;

            public string DescEst { get => descEst; set => descEst = value; }
            public int Valor { get => valor; set => valor = value; }
        }

        public frmListarReclamosA()
        {
            BindingList<Estado> listaEstados = new BindingList<Estado>();

            Estado auxEst = new Estado();
            auxEst.DescEst = "Por Atender"; auxEst.Valor = 0;
            listaEstados.Add(auxEst);

            auxEst = new Estado();
            auxEst.DescEst = "Atendido"; auxEst.Valor = 1;
            listaEstados.Add(auxEst);

            auxEst = new Estado();
            auxEst.DescEst = "-"; auxEst.Valor = 3;
            listaEstados.Add(auxEst);


            InitializeComponent();

            daoGestionPersonas = new GestPersonasWSClient();
            dgvReclamos.AutoGenerateColumns = false;


            cboEstado.DataSource = listaEstados;
            cboEstado.SelectedIndex = 2;
            cboEstado.DisplayMember = "DescEst";
            cboEstado.ValueMember = "Valor";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmGestionReclamosA formGestionReclamosA = new frmGestionReclamosA();
            if(formGestionReclamosA.ShowDialog() == DialogResult.OK)
            {
                DateTime auxFechaIni = new DateTime();
                DateTime auxFechaFin = new DateTime();

                auxFechaIni = dtpFechaInicial.Value;
                auxFechaFin = dtpFechaFin.Value;
                dgvReclamos.DataSource = daoGestionPersonas.ListarBusquedaReclamos(tbNomCli.Text,
                                                                                   tbApeCli.Text, 
                                                                                   tbNomEmp.Text, 
                                                                                   tbApeEmp.Text, 
                                                                                   tbNomAdm.Text, 
                                                                                   tbApeAdm.Text, 
                                                                                   auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"),
                                                                                   auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"), 
                                                                                   (int)cboEstado.SelectedValue); 
            }
        }

        private void dgvReclamos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            reclamo auxRec = (reclamo)dgvReclamos.Rows[e.RowIndex].DataBoundItem;
            dgvReclamos.Rows[e.RowIndex].Cells[0].Value = auxRec.cliente.nombre + " " + auxRec.cliente.apellidoPaterno;
            dgvReclamos.Rows[e.RowIndex].Cells[1].Value = auxRec.empleado.nombre + " " + auxRec.empleado.apellidoPaterno;
            dgvReclamos.Rows[e.RowIndex].Cells[2].Value = auxRec.fechaRegistro.ToShortDateString();

            if (auxRec.estado == false)
            {
                dgvReclamos.Rows[e.RowIndex].Cells[3].Value = "Por Atender";
            }
            else
            {
                dgvReclamos.Rows[e.RowIndex].Cells[3].Value = "Atendido";
            }

            dgvReclamos.Rows[e.RowIndex].Cells[4].Value = auxRec.descripcion;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime auxFechaIni = new DateTime();
            DateTime auxFechaFin = new DateTime();

            auxFechaIni = dtpFechaInicial.Value;
            auxFechaFin = dtpFechaFin.Value;

            GestPersonasWS.reclamo[ ] listaRecs = daoGestionPersonas.ListarBusquedaReclamos(tbNomCli.Text, tbApeCli.Text, tbNomEmp.Text, tbApeEmp.Text, tbNomAdm.Text, tbApeAdm.Text, auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"), auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"), (int)cboEstado.SelectedValue);
            
            if (listaRecs != null)
            {
                dgvReclamos.DataSource = listaRecs;
            }
            else
            {
                MessageBox.Show("No se ha encontrado reclamos", "Mensaje de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvReclamos.DataSource = listaRecs;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReclamos.SelectedRows.Count == 1)
            {
                auxRec = new reclamo();

                auxRec = (reclamo)dgvReclamos.CurrentRow.DataBoundItem;

                frmGestionReclamosA formReclamo = new frmGestionReclamosA(auxRec);

                if (formReclamo.ShowDialog() == DialogResult.OK)
                {

                    DateTime auxFechaIni = new DateTime();
                    DateTime auxFechaFin = new DateTime();
                    auxFechaIni = dtpFechaInicial.Value;
                    auxFechaFin = dtpFechaFin.Value;
                    dgvReclamos.DataSource = daoGestionPersonas.ListarBusquedaReclamos(tbNomCli.Text, tbApeCli.Text, tbNomEmp.Text, tbApeEmp.Text, tbNomAdm.Text, tbApeAdm.Text, auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"), auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"), (int)cboEstado.SelectedValue); ;
                }
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReclamos.SelectedRows.Count == 1)
            {
                DateTime auxFechaIni = new DateTime();
                DateTime auxFechaFin = new DateTime();

                auxFechaIni = dtpFechaInicial.Value;
                auxFechaFin = dtpFechaFin.Value;

                auxRec = new reclamo();

                auxRec = (reclamo)dgvReclamos.CurrentRow.DataBoundItem;

                daoGestionPersonas.EliminarReclamo(auxRec);

                auxRec = null;

                dgvReclamos.DataSource = daoGestionPersonas.ListarBusquedaReclamos(tbNomCli.Text, tbApeCli.Text, tbNomEmp.Text, tbApeEmp.Text, tbNomAdm.Text, tbApeAdm.Text, auxFechaIni.ToString("dd-MM-yyyy HH:mm:ss"), auxFechaFin.ToString("dd-MM-yyyy HH:mm:ss"), (int)cboEstado.SelectedValue);

                MessageBox.Show("Borrado Exitoso.", "Borrado de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
