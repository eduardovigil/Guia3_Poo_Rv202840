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
    public partial class InformeAlumno : Form
    {
        public InformeAlumno()
        {
            InitializeComponent();
        }
        public List<Alumno> Recibe = null; //creación de una lista que reciba
        private int editIndice = -1;
        private void actualizar() //función que llena el DGV del formulario 2
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Recibe;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccion);
            editIndice = pos;

            Alumno listalumno = Recibe[pos];

            //Lo siguiente es para cuando se seleccione el alumno, nos muestre los datos en los textbox correspondientes
            txtnombre.Text = listalumno.Nombre;
            txtcarnet.Text = listalumno.Apellido;
            txtmateria.Text = listalumno.Materia;
            txtapellido.Text = listalumno.Apellido;
            txtnota1.Text = Convert.ToString(listalumno.Calificaciones[0]);
            txtnota2.Text = Convert.ToString(listalumno.Calificaciones[1]);
            txtnota3.Text = Convert.ToString(listalumno.Calificaciones[2]);

            double promedio, nota1, nota2, nota3;
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            promedio = (nota1 + nota2 + nota3) / 3;
            txtprom.Text = Convert.ToString(promedio);
        }

        private void InformeAlumno_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
