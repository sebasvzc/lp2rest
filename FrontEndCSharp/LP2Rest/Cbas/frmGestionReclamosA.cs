using LP2Rest.GestPersonasWS;
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
using static LP2Rest.frmListarReclamosA;

namespace LP2Rest
{
    public partial class frmGestionReclamosA : Form
    {

        //Utiles
        GestPersonasWS.GestPersonasWSClient daoGestionPersonas;

        //Otros
        reclamo reclamoAux;
        bool borrado;
        bool nuevo;

        public bool Borrado { get => borrado; set => borrado = value; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public frmGestionReclamosA()
        {
            Borrado = false;
            nuevo = true;

            reclamoAux = new reclamo();
            reclamoAux.cliente = new cliente();
            reclamoAux.empleado = new empleado();
            reclamoAux.administrador = new administrador();

            BindingList<Estado> listaEstados = new BindingList<Estado>();

            Estado auxEst = new Estado();
            auxEst.DescEst = "Por Atender"; auxEst.Valor = 0;
            listaEstados.Add(auxEst);

            auxEst = new Estado();
            auxEst.DescEst = "Atendido"; auxEst.Valor = 1;
            listaEstados.Add(auxEst);


            InitializeComponent();

            cboEstado.DataSource = listaEstados;
            cboEstado.DisplayMember = "DescEst";
            cboEstado.ValueMember = "Valor";

            cboEstado.SelectedValue = 0;
            dtpFecha.Enabled = true;
            rtbDesc.Enabled = true;
            rtbDesc.ReadOnly = false;

            tbIdAdmin.Enabled = false;
            tbNombreAdmin.Enabled = false;
            tbIdAdmin.Text = 9.ToString();
            tbNombreAdmin.Text = "Carlos Paz";


            daoGestionPersonas = new GestPersonasWSClient();
        }

        public frmGestionReclamosA(reclamo auxRec)
        {
            Borrado = false;
            nuevo = false;

            daoGestionPersonas = new GestPersonasWSClient();

            reclamoAux = new reclamo();
            reclamoAux = auxRec;

            BindingList<Estado> listaEstados = new BindingList<Estado>();

            Estado auxEst = new Estado();
            auxEst.DescEst = "Por Atender"; auxEst.Valor = 0;
            listaEstados.Add(auxEst);

            auxEst = new Estado();
            auxEst.DescEst = "Atendido"; auxEst.Valor = 1;
            listaEstados.Add(auxEst);


            InitializeComponent();

            cboEstado.DataSource = listaEstados;
            cboEstado.DisplayMember = "DescEst";
            cboEstado.ValueMember = "Valor";

            if (auxRec.estado == true) cboEstado.SelectedValue = 1;
            else cboEstado.SelectedValue = 0;
            txtIdReclamo.Text = auxRec.id.ToString();
            dtpFecha.Value = auxRec.fechaRegistro;
            dtpFecha.Enabled = false;
            rtbDesc.Text = auxRec.descripcion;

            txtDNICliente.Text = auxRec.cliente.DNI;
            txtNombreCliente.Text = auxRec.cliente.nombre + " " + auxRec.cliente.apellidoPaterno;
            txtTelefonoCliente.Text = auxRec.cliente.telefono;

            txtDNIEmpleado.Text = auxRec.empleado.DNI;
            txtNombreEmpleado.Text = auxRec.empleado.nombre + " " + auxRec.empleado.apellidoPaterno;
            txtTelefonoEmpleado.Text = auxRec.empleado.telefono;

            tbIdAdmin.Text = auxRec.administrador.idPersona.ToString();
            tbNombreAdmin.Text = auxRec.administrador.nombre + " " + auxRec.administrador.apellidoPaterno;

            rtbObs.Text = auxRec.observacion;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Borrado = false;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void label12_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                Borrado = false;

                reclamoAux.fechaRegistro = dtpFecha.Value;
                //reclamoAux.fechaRegistro = DateTime.Now;

                if (cboEstado.SelectedValue.ToString() == "1") reclamoAux.estado = false;
                else reclamoAux.estado = true;

                reclamoAux.descripcion = rtbDesc.Text;

                reclamoAux.cliente.idPersona = 3;
                reclamoAux.empleado.idPersona = 2;
                reclamoAux.administrador.idPersona = 9;

                reclamoAux.observacion = rtbObs.Text;

                int aux = daoGestionPersonas.InsertarReclamo(reclamoAux, dtpFecha.Value.ToString("dd-MM-yyyy HH:mm:ss"));

                if (aux == 0)
                {
                    MessageBox.Show("Creacion Fallida.", "Creacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reclamoAux.id = aux;

                    MessageBox.Show("Creacion Exitosa.", "Creacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdReclamo.Text = aux.ToString();

                    rtbDesc.Enabled = false;
                    rtbDesc.ReadOnly = true;

                    dtpFecha.Enabled = false;

                    nuevo = false;
                }


            }
            else
            {
                Borrado = false;

                reclamoAux.observacion = rtbObs.Text;
                reclamoAux.fechaAtencion = DateTime.Now;

                daoGestionPersonas.ModificarReclamo(reclamoAux);

                MessageBox.Show("Modificacion Exitosa.", "Modificacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
