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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }
        private List<Alumno> Alumnos = new List<Alumno>();
        private int editIndice = -1;

        public float promedio(float nota1, float nota2, float nota3)
        {
            float notapromedio = (nota1 + nota2 + nota3) / 3;
            return notapromedio;
        }


        private void limpiar()
        {
            txtapellido.Clear();
            txtcarnet.Clear();
            txtmateria.Clear();
            txtnombre.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Alumno alumnos = new Alumno();
            alumnos.Nombre = txtnombre.Text;
            alumnos.Apellido = txtapellido.Text;
            alumnos.Carnet = txtcarnet.Text;
            alumnos.Materia = txtmateria.Text;
            alumnos.Calificaciones[0] = float.Parse(txtnota1.Text);
            alumnos.Calificaciones[1] = float.Parse(txtnota2.Text);
            alumnos.Calificaciones[2] = float.Parse(txtnota3.Text);

            float notaPromedio = promedio(alumnos.Calificaciones[0], alumnos.Calificaciones[1], alumnos.Calificaciones[2]);

            if (editIndice > -1)
            {
                Alumnos[editIndice] = alumnos;
                editIndice = -1;
            }
            else
            {
                Alumnos.Add(alumnos);
            }

            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformeAlumno formulario = new InformeAlumno(); //instancia de otro formulario
            formulario.Recibe = Alumnos; 
            /*lista original Personas es enviada a la lista PersonaRecibe que está en 
             * el formulario 2 y que puede ser invocada por medio de la instancia del segundo formulario */
            formulario.Show(); //mostar el segundo formulario
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Menu = new FormMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
