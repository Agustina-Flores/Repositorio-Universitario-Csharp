using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articulo> articulos = new List<Articulo>() {
            new Articulo() { Id = 1, Nombre = "Harina", Origen = "Argentina", Marca =
            "Arcor", CodigoBarra = 154356989, Stock = 2000, Precio = 80 } ,
             new Articulo() { Id = 2, Nombre = "Fideos", Origen = "Argentina", Marca =
            "Terrabusi", CodigoBarra = 151454789, Stock = 3600, Precio = 150 } ,
             new Articulo() { Id = 3, Nombre = "Arroz", Origen = "Argentina", Marca = "Dos Hermanos", CodigoBarra = 154352589, Stock = 2800, Precio = 160 } ,
             new Articulo() { Id = 4, Nombre = "Carne Molida" , Origen = "Argentina", Marca
            = "Estancia", CodigoBarra = 154354789, Stock = 4500, Precio = 320 } ,
             new Articulo() { Id = 5, Nombre = "Cerveza" , Origen = "Argentina", Marca =
            "Quilmes", CodigoBarra = 154964789, Stock = 2800, Precio = 110 } ,
             new Articulo() { Id = 5, Nombre = "Galletas" , Origen = "Argentina", Marca =
            "Surtidas", CodigoBarra = 154357489, Stock = 2200, Precio = 60 } ,
             new Articulo() { Id = 5, Nombre = "Gaseosa" , Origen = "Argentina", Marca =
            "Coca", CodigoBarra = 154358589, Stock = 3300, Precio = 150 } ,
             new Articulo() { Id = 5, Nombre = "Queso" , Origen = "Argentina", Marca =
            "Ilolay", CodigoBarra = 154554789, Stock = 3800, Precio = 390 } ,
             new Articulo() { Id = 5, Nombre = "Jamon" , Origen = "Argentina", Marca = "3 cruces", CodigoBarra = 154356589, Stock = 3000, Precio = 420 } ,
             new Articulo() { Id = 5, Nombre = "Aceite" , Origen = "Argentina", Marca ="Cocinero", CodigoBarra = 154454789, Stock = 2600, Precio = 220 }
         };

            //Articulos cuyo Stock sea mayor a 3000 ordenados por Stock descendente

            var articuloQuery = from articulo in articulos
                                where articulo.Stock > 3000
                                orderby articulo.Stock descending
                                select articulo.Stock;

            foreach (var articulo in articuloQuery)
            {
                Console.WriteLine("Articulos cuyo Stock sea mayor a 3000 ordenados por Stock descendente : " + articulo);
            }
            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();

            // Articulos cuyo Nombre inicie con g ordenados  por Nombre.

            var articulo1Query = from articulo1 in articulos
                                 where articulo1.Nombre.StartsWith("G")
                                 orderby articulo1.Nombre
                                 select articulo1.Nombre;

            foreach (var articulo1 in articulo1Query)
            {
                Console.WriteLine("Articulos cuyo Nombre inicie con g ordenados por Nombre : " + articulo1);
            }
            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();

            // Cantidad de Precios

            var articulo2Query = from articulo2 in articulos
                                 select articulo2;

            int precios = articulo2Query.Count();

            Console.WriteLine("Cantidad de Precios : " + precios);

            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();

            //artículo con el Precio mínimo

            var articulo3Query = from articulo3 in articulos
                                 select articulo3.Precio;

            var precioMinimo = articulo3Query.Min();

            var articulo4Query = from articulo4 in articulos
                                 where articulo4.Precio == precioMinimo
                                 select articulo4.Nombre;


            Console.WriteLine("Nombre del Articulo con el precio minimo : " + articulo4Query.First());


            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();

            //Indique el promedio de los Precios. 

            var articulo5Query = from articulo5 in articulos
                                 select articulo5.Precio;

            var resultadoPromedio = articulo5Query.Average();

            Console.WriteLine("Promedio : " + resultadoPromedio);

            Console.WriteLine("Presionar enter para continuar");
            Console.ReadLine();
        }

    }
}
