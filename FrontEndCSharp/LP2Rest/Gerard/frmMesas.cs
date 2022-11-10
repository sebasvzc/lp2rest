using LP2Rest.VentasWS;
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
        //Conexiones
        VentasWS.VentasWSClient daoVentas;


        //Atributos
        private int idMesa;
        private int idMesero;

        public int IdMesa { get => idMesa; set => idMesa = value; }
        public int IdMesero { get => idMesero; set => idMesero = value; }

        //Utiles Mesas
        mesa[] listaMesas;
        
        private void actualizarMesas()
        {
            listaMesas = daoVentas.listarTodosMesas();
            Color colorVerde = Color.LightGreen;
            for (int i = 0; i < 12; i++)
            {
                switch (i)
                {
                    case 0:
                        if (listaMesas[0].disponible == true)
                        {
                            btnMesa1.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa1.BackColor = Color.Red;
                        }
                        break;
                    case 1:
                        if (listaMesas[1].disponible == true)
                        {
                            btnMesa2.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa2.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (listaMesas[2].disponible == true)
                        {
                            btnMesa3.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa3.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (listaMesas[3].disponible == true)
                        {
                            btnMesa4.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa4.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (listaMesas[4].disponible == true)
                        {
                            btnMesa5.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa5.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (listaMesas[5].disponible == true)
                        {
                            btnMesa6.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa6.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (listaMesas[6].disponible == true)
                        {
                            btnMesa7.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa7.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (listaMesas[7].disponible == true)
                        {
                            btnMesa8.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa8.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (listaMesas[8].disponible == true)
                        {
                            btnMesa9.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa9.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (listaMesas[9].disponible == true)
                        {
                            btnMesa10.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa10.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (listaMesas[10].disponible == true)
                        {
                            btnMesa11.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa11.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (listaMesas[11].disponible == true)
                        {
                            btnMesa12.BackColor = colorVerde;
                        }
                        else
                        {
                            btnMesa12.BackColor = Color.Red;
                        }
                        break;                    
                }
                
            }
        }

        public frmMesas(int auxIdMesero)
        {
            daoVentas = new VentasWSClient();      
            
            idMesero = auxIdMesero;
            



            InitializeComponent();

            actualizarMesas();

            
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
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[0],IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa1.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa1.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {
 
                
            }
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            IdMesa = 8;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[7],IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa8.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa8.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            IdMesa = 2;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa2.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa2.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            IdMesa = 3;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[2], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa3.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa3.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            IdMesa = 4;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa-1],IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa4.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa4.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            IdMesa = 5;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa5.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa5.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            IdMesa = 6;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa6.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa6.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            IdMesa = 7;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa7.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa7.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            IdMesa = 9;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa9.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa9.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            IdMesa = 10;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa10.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa10.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            IdMesa = 11;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa11.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa11.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            IdMesa = 12;
            frmOrdenVenta formOrdenVenta = new frmOrdenVenta(listaMesas[IdMesa - 1], IdMesero);
            formOrdenVenta.ShowDialog();
            if (formOrdenVenta.MesaSeleccionada.disponible == true)
            {
                btnMesa12.BackColor = Color.LightGreen;
            }
            else
            {
                btnMesa12.BackColor = Color.Red;
            }
            if (formOrdenVenta.DialogResult == DialogResult.OK)
            {


            }
        }

       
    }
}
