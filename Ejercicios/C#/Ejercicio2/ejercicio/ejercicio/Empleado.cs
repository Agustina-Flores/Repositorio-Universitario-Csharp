using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ejercicio
{
    public class Empleado
    {
        private string nombreCompleto { get; set; }
        private List<JornadaLaboral> jornadasLaborales = new List<JornadaLaboral>();
       
        public string getnombreCompleto()
        {
            return this.nombreCompleto;
        }

        public void setnombreCompleto(string nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }

        public List<JornadaLaboral> getJornadaLaboral()
        {
            return this.jornadasLaborales;
        }

        public void setJornadaLaboral(List<JornadaLaboral> jornadasLaborales)
        {
            this.jornadasLaborales = jornadasLaborales;
        }

        public  int totalTrabajadoMes(int mes,int anio)
        {
            int total = 0;
            foreach (var jornada in jornadasLaborales)
            {
                if (jornada.Fecha.Year == anio && jornada.Fecha.Month == mes)
                {
                 total = total + jornada.MinutosTrabajados;
                }
            }

            return total;
        }
    }
}
