using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Estudiante> estudiantes = new List<Estudiante>() {
             new Estudiante() { Id = 1, Nombre = "Juan", Edad = 19 } ,
             new Estudiante() { Id = 2, Nombre = "Pedro", Edad = 21 } ,
             new Estudiante() { Id = 3, Nombre = "Jose", Edad = 25 } ,
             new Estudiante() { Id = 4, Nombre = "Carlos" , Edad = 20 } ,
             new Estudiante() { Id = 5, Nombre = "David" , Edad = 23 }
             };


            //Estudiantes cuya edad se encuentre entre los 18 y 22 años

            var estudianteQuery = from estudiante1 in estudiantes
                                  where estudiante1.Edad > 18 && estudiante1.Edad < 22
                                  orderby estudiante1.Nombre
                                  select estudiante1.Nombre;

            foreach (var estudiante1 in estudianteQuery)
            {
                Console.WriteLine("Estudiantes cuya edad se encuentre entre los 18 y 22 años : " + estudiante1);
            }
            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();

            //Estuduantes cuyo nombre comience con la letra J

            var estudianteQuery1 = from estudiante2 in estudiantes
                                   where estudiante2.Nombre.StartsWith("J")
                                   orderby estudiante2.Nombre
                                   select estudiante2.Nombre;

            foreach (var estudiante2 in estudianteQuery1)
            {
                Console.WriteLine("Estudiantes cuyo nombre comience con la letra J : " + estudiante2);
            }
            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();
            
             
        }
    }
}
