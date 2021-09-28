using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_3_POO_RV202840
{
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }
        /*listado que permite tener varios elementos de la clase cliente bancos*/
        private List<DatosBanco> datosbancos = new List<DatosBanco>();
        private int edit_indice = -1;
        //el índice para editar comienza en -1, esto significa que no hay ninguno seleccionado, esto servirá para el DataGridView.
        private void actualizar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = datosbancos; 
            /*los nombres de columna que veremos son los de las propiedades*/
        }
        private void limpiar()
        {
            txtnombre.Clear();
            txtapellidos.Clear();
            txtdui.Clear();
            txtmonto.Clear();
            txtnit.Clear();
            txtncuenta.Clear();

        }
        private void Banco_Load(object sender, EventArgs e)
        {
            cmbcuenta.Items.Add("Corriente");
            cmbcuenta.Items.Add("Ahorros");
            cmbcuenta.Items.Add("Plazos");
            cmbsucursal.Items.Add("Santa Marcos");
            cmbsucursal.Items.Add("Galeria");
            cmbsucursal.Items.Add("Alta Vista");
            cmbsucursal.Items.Add("San Bartolo");
            cmbsucursal.Items.Add("Santa Figueroa");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccion); //almacena en cual fila estoy
            edit_indice = pos; //copio esa variable en índice editado

            DatosBanco per = datosbancos[pos]; /*esta variable de tipo persona, se carga con los valores que le pasa el listado*/

            txtdui.Text = per.Dui;
            txtnombre.Text = per.Nombre; //lo que tiene el atributo se lo doy al textbox
            txtapellidos.Text = per.Apellido;
            cmbcuenta.Text = per.TipoCuenta;
            txtnit.Text = per.Nit;
            txtncuenta.Text = per.NumeroCuenta;
            txtmonto.Text = per.Monto;
            cmbsucursal.Text = per.Sucursal;
        }

        private void BtnInscreso_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase persona y guardo a través de las propiedades
            DatosBanco per = new DatosBanco();
            per.Nombre = txtnombre.Text;
            per.Apellido = txtapellidos.Text;
            per.Dui = txtdui.Text;
            per.TipoCuenta = cmbcuenta.Text;
            per.Nit = txtnit.Text;
            per.NumeroCuenta = txtncuenta.Text;
            per.Monto = txtmonto.Text;
            per.Sucursal = cmbsucursal.Text;
            if (edit_indice > -1) //verifica si hay un índice seleccionado
            {
                datosbancos[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {

                datosbancos.Add(per); 
                /*al arreglo de Personas le agrego el objeto creado con todos los datos que recolecté*/

            }
            actualizar();//llamamos al procedimiento que guarda en datagrid
            limpiar();//mandamos a llamar la función que limpia
        }

        private void cmbcuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbcuenta.Text == "Corriente")
            {
                txtncuenta.Text = "CC-";
            }
            else if (cmbcuenta.Text == "Ahorros")
            {
                txtncuenta.Text = "CA-";
            }
            else if (cmbcuenta.Text == "Plazos")
            {
                txtncuenta.Text = "CP-";
            }
        }

        private void txtdui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtncuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
