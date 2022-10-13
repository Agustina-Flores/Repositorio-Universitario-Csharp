using System;
using System.Collections.Generic;

namespace ejercicios
{
    static class Ejercicio
    {
        //variables globales
        //Un arreglo de articulo de 10 filas  y 3 columnas
        public static string[,] articulos = new string[10, 3]{{"100","Gaseosa","120"},
        {"150","Fideos","50"},{"200","Arroz","60"},{"250","Harina","55"},{"300","Lavandina","70"},
        {"350","Cafe","200"},{"400","Azucar","120"},{"450","Yerba","80"},{"500","Te","90"},
        {"550","Docena de Huevos","160"}};

        //Una Lista de obj de ItemArticulos

        public static List<ItemArticulo> itemarticulos = new List<ItemArticulo>();
    }
    class Ticket
    {
        static void Main(string[] args)
        {
            double total = 0;
            string opcion = "";
            bool existe = false;
            do
            {
                Console.WriteLine("Ingrese un codigo");
                int codigo = Int32.Parse(Console.ReadLine());

                //Console.WriteLine(Ejercicio.articulos.GetLength(0));10 //filas
                //Console.WriteLine(Ejercicio.articulos.GetLength(1)); 3 //columnas


                for (int i = 0; i < Ejercicio.articulos.GetLength(0); i++)
                {
                    if (Int32.Parse(Ejercicio.articulos[i, 0]) == codigo)//recorro filas de la primera columna
                    {
                        existe = true;
                        Console.WriteLine("Ingrese cantidad de articulos");
                        int cantidad = Int32.Parse(Console.ReadLine());
                        ItemArticulo ia = new ItemArticulo();
                        ia.codigo = Int32.Parse(Ejercicio.articulos[i, 0]);
                        ia.nombre = (Ejercicio.articulos[i, 1]);
                        ia.precio = Double.Parse(Ejercicio.articulos[i, 2]);
                        ia.cantidad = cantidad; //?
                        Ejercicio.itemarticulos.Add(ia);
                        Console.WriteLine("Desea cargar un nuevo artículo.Ingrese Si para continuar con la carga o presione otra tecla para salir");
                        opcion = Console.ReadLine();
                        break;
                    }
                }
                if (existe == false)
                {
                    Console.WriteLine("El código ingresado no existe, intente nuevamente");
                    Console.WriteLine("Desea cargar un nuevo artículo.Ingrese SI para continuar con la carga o presione otra tecla para salir");
                    opcion = Console.ReadLine();

                }
            } while ((opcion == "si" || opcion == "SI" || opcion == "Si"));
            if (Ejercicio.itemarticulos.Count <= 0)
            {
                Console.WriteLine("Aplicacion terminada");
                return;
            }
            //Empieza a imprimir subtotal y total
            Console.WriteLine("codigo articulo precio  cantidad subtotal");
            foreach (var articulo in Ejercicio.itemarticulos)
            {

                double subtotal = articulo.precio * articulo.cantidad;
                total = total + subtotal;
                Console.WriteLine(articulo.codigo.ToString() + "\t" + articulo.nombre + "\t" + articulo.precio.ToString() + "\t" + articulo.cantidad.ToString() + "\t" + subtotal.ToString());

            }
            Console.WriteLine("\t" + "\t" + "\t" + "\t" + "TOTAL: " + total);
        }
    }

}
  
