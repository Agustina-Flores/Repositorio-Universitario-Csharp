using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicios
{
    class Empleado
    {
        private string nombreCompleto { get; set; }
        List<JornadaLaboral> jornadasLaborales = new List<JornadaLaboral>();

 
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


        public int totalTrabajadoMes(int mes, int anio)
        {
            int total = 0;
            foreach (var jornada in jornadasLaborales)
            {
                if (jornada.getFecha().Year == anio && jornada.getFecha().Month == mes)
                {
                    total = total + jornada.getMinutosTrabajados();
                }
            }

            return total;
        }
    }
}
