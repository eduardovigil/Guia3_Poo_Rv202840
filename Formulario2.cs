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
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }
        public List<Persona> PersonaRecibe = null; //creación de una lista que reciba

        DataTable directorio = new DataTable(); //DataTable
        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dgvRecibir.DataSource = directorio;
            dgvRecibir.DataSource = PersonaRecibe;
        }

        private void BtnRellenar_Click(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
