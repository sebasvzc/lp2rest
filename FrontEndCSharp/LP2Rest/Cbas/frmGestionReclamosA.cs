using LP2Rest.GestPersonasWS;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
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
        bool editado;

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
            reclamoAux.cliente = new cliente();                 reclamoAux.cliente.idPersona = 0;
            reclamoAux.empleado = new empleado();               reclamoAux.empleado.idPersona = 0;
            reclamoAux.administrador = new administrador();

            BindingList<Estado> listaEstados = new BindingList<Estado>();

            Estado auxEst = new Estado();
            auxEst.DescEst = "Por Atender"; auxEst.Valor = 0;
            listaEstados.Add(auxEst);

            auxEst = new Estado();
            auxEst.DescEst = "Atendido"; auxEst.Valor = 1;
            listaEstados.Add(auxEst);


            InitializeComponent();

            txtIdReclamo.Enabled = false;

            txtDNICliente.Enabled = false;
            txtDNIEmpleado.Enabled = false;

            txtNombreCliente.Enabled = false;
            txtNombreEmpleado.Enabled = false;

            txtTelefonoCliente.Enabled = false;
            txtTelefonoEmpleado.Enabled = false;

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

            txtFechaAtencion.Text = "-";

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

            txtIdReclamo.Enabled = false;

            txtIdReclamo.Enabled = false;

            txtDNICliente.Enabled = false;
            txtDNIEmpleado.Enabled = false;

            txtNombreCliente.Enabled = false;
            txtNombreEmpleado.Enabled = false;

            txtTelefonoCliente.Enabled = false;
            txtTelefonoEmpleado.Enabled = false;

            cboEstado.DataSource = listaEstados;
            cboEstado.DisplayMember = "DescEst";
            cboEstado.ValueMember = "DescEst";

            if (auxRec.estado == true)
            {
                cboEstado.SelectedValue = "Atendido";
                txtFechaAtencion.Text = auxRec.fechaRegistro.ToString("dd-MM-yyyy");
            }
            else
            {
                cboEstado.SelectedValue = "Por Atender";
                txtFechaAtencion.Text = "-";
            }

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

            tbIdAdmin.Enabled = false;
            tbNombreAdmin.Enabled = false;
            tbIdAdmin.Text = 69.ToString();
            tbNombreAdmin.Text = "Josep Guardiola";

            tbIdAdmin.Text = auxRec.administrador.idPersona.ToString();
            tbNombreAdmin.Text = auxRec.administrador.nombre + " " + auxRec.administrador.apellidoPaterno;

            rtbObs.Text = auxRec.observacion;

            if (auxRec.fechaRegistro != null)
            {
                txtFechaAtencion.Text = auxRec.fechaRegistro.ToString("dd-MM-yyyy");
            }
            else
            {
                txtFechaAtencion.Text = "-";
            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Borrado = false;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
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

                //reclamoAux.fechaRegistro = dtpFecha.Value;
                //reclamoAux.fechaRegistro = DateTime.Now;

                if (cboEstado.SelectedValue.ToString() == "Atendido") reclamoAux.estado = true;
                else reclamoAux.estado = false;

                reclamoAux.descripcion = rtbDesc.Text;

                if (reclamoAux.cliente.idPersona == 0 || reclamoAux.empleado.idPersona == 0)
                {
                    if(reclamoAux.cliente.idPersona == 0)
                        MessageBox.Show("Creacion Fallida. Cliente vacio.", "Creacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (reclamoAux.empleado.idPersona == 0)
                        MessageBox.Show("Creacion Fallida. Empleado vacio.", "Creacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    reclamoAux.observacion = rtbObs.Text;
                    reclamoAux.administrador.idPersona = 9;

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

                //reclamoAux.cliente.idPersona = 3;
                //reclamoAux.empleado.idPersona = 2;
                reclamoAux.administrador.idPersona = 9;              


            }
            else
            {
                Borrado = false;

                reclamoAux.observacion = rtbObs.Text;
                reclamoAux.fechaAtencionSpecified = true;
                reclamoAux.fechaAtencion = DateTime.Now;
                if (cboEstado.SelectedValue.ToString() == "Atendido") reclamoAux.estado = true;
                else reclamoAux.estado = false;


                int resultado = daoGestionPersonas.ModificarReclamo(reclamoAux);

                if(resultado == 1)
                {
                    MessageBox.Show("Modificacion Exitosa.", "Modificacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFechaAtencion.Text = reclamoAux.fechaAtencion.ToShortDateString();
                }
                else
                {
                    MessageBox.Show("Modificacion Fallida.", "Modificacion de Reclamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                


            }
        }

        private void btEmpleado_Click(object sender, EventArgs e)
        {
            frmGestionEmpleadosBusquedaEmpleado formBusqEmp = new frmGestionEmpleadosBusquedaEmpleado();
            if (formBusqEmp.ShowDialog() == DialogResult.OK)
            {
                reclamoAux.empleado = formBusqEmp.EmpleadoSeleccionado;

                txtDNIEmpleado.Text = reclamoAux.empleado.DNI;
                txtNombreEmpleado.Text = reclamoAux.empleado.nombre + " " + reclamoAux.empleado.apellidoPaterno;
                txtTelefonoEmpleado.Text = reclamoAux.empleado.telefono;
            }
        }

        private void txtDNIEmpleado_TextChanged(object sender, EventArgs e)
        {

        }


        private void btCliente_Click(object sender, EventArgs e)
        {
            frmGestionReclamoBusquedaCliente formBusqCli = new frmGestionReclamoBusquedaCliente();
            if (formBusqCli.ShowDialog() == DialogResult.OK)
            {
                reclamoAux.cliente = formBusqCli.clienteSeleccionado;

                txtDNICliente.Text = reclamoAux.cliente.DNI;
                //txtDNICliente.Text = reclamoAux.cliente.idPersona.ToString();
                txtNombreCliente.Text = reclamoAux.cliente.nombre + " " + reclamoAux.cliente.apellidoPaterno;
                txtTelefonoCliente.Text = reclamoAux.cliente.telefono;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
