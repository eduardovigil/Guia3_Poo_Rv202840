﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3_POO_RV202840
{
    public class Alumno
    {

        string carnet;
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public float[] calificaciones = new float[3];
        public float[] Calificaciones
        {
            get { return calificaciones; }
            set { calificaciones = value; }
        }
    }
}
