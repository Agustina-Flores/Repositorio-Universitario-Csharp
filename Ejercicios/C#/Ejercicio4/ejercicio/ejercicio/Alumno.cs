using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio
{
    public class Alumno
    {
        private string nombre;
        private List<Nota> notas;
        //public string Nombre { get => nombre; set => nombre = value; }
       // internal List<Nota> Notas { get => notas; set => notas = value; }

        /*
        public Alumno(string nombre, List<Nota> notas)
        {
            Nombre = nombre;
            Notas = notas;

        }
        */
        public Alumno(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public List<Nota> getNotas()
        {
            return this.notas;
        }

        public void setNotas(List<Nota> notas)
        {
            this.notas = notas;
        }


        public double getMaximaNota()
        {
            double notamx = 0;
            foreach(Nota n in notas)
            {
                if(n.valor > notamx)
                notamx = n.valor;
            }

            return notamx;
        }
           

        public double PromedioNota()
        {
            double total = 0;
            int contador = 0;
            double promedio =0;

            if (this.notas != null)
            {
                foreach (Nota nota in notas)
                {
                    total += nota.valor;
                    contador++;

                }
                promedio = (total / contador);

            }
            return promedio;
        }
    }
}
