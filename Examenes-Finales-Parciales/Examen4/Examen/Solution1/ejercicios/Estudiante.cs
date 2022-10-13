using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private long id;
        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
