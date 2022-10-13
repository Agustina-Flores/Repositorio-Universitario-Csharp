using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace empleado
{
    class Sector
    {
         
        private int codigo;
        private string denominacion;
        private int telefono;
        private List<Empleado> empleados;

        public int getCodigo()
        {
            return this.codigo;
        }
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public int getTelefono()
        {
            return this.telefono;
        }
        public void setTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public string getDenominacion()
        {
            return this.denominacion;
        }

        public void setDenominacion(string denominacion)
        {
            this.denominacion = denominacion;
        }

        public List<Empleado> getEmpleados()
        {
            return this.empleados;
        }

        public void setEmpleados(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }
        
        public void verificarDNIEmpleados()
        {
            if (empleados != null)
            {
                foreach (Empleado empleado1 in empleados)
                {
                    foreach (Empleado empleado2 in empleados)
                    {
                        if (empleado2.getCuit() == empleado1.getCuit())
                        {
                            if (empleado2.getApellido() != empleado1.getApellido())
                            {
                                Console.WriteLine("Los Empleados {0} {1} y {2} {3} poseen el mismo Cuit.", empleado1.getNombre(), empleado1.getApellido(), empleado2.getNombre(), empleado2.getApellido());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Los Empleados están correctamente cargados");
                        }
                    }
                }
            }
            
        }
        

         
    }  
}
