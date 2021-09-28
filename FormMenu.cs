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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Banco = new Banco();
            Banco.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form estudiantes = new Estudiantes();
            estudiantes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Inventario = new Inventario();
            Inventario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Filtro = new Form1();
            Filtro.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
