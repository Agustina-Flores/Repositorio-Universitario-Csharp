using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicios
{
	class Program
	{
		static void Main(string[] args)
		{
			 numerosposicion();
			 recursion();
			 arreglo();
			//objetos();
			//linq();
		}
		public static string num(string param, int startIndex, int length)
		{

			string result = param.Substring(startIndex, length);
			return result;
		}

		private static void numerosposicion()
		{
			string cadena;
			Console.WriteLine("Introduce un texto: ");
			cadena = Console.ReadLine();

			for (int i = 0; i < cadena.Length; i++)
			{

				switch (num(cadena, i, 1))
				{
					case "1":
						int uno = 1;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", uno, i + 1 + " el num es impar");
						break;
					case "2":
						int dos = 2;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", dos, i + 1 + " el num es par");
						break;
					case "3":
						int tres = 3;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", tres, i + 1 + " el num es impar");
						break;
					case "4":
						int cuatro = 4;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", cuatro, i + 1 + " el num es par");
						break;
					case "5":
						int cinco = 5;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", cinco, i + 1 + " el num es impar");
						break;
					case "6":
						int seis = 6;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", seis, i + 1 + " el num es par");
						break;
					case "7":
						int siete = 7;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", siete, i + 1 + " el num es impar");
						break;
					case "8":
						int ocho = 8;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", ocho, i + 1 + " el num es par");
						break;
					case "9":
						int nueve = 9;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", nueve, i + 1 + " el num es impar");
						break;
					case "0":
						int cero = 0;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", cero, i + 1 + " el num es par");
						break;
				}

			}
		} 

		public static void recursion()
        {
			Console.WriteLine("Ingresa un numero");
			int numero = Int32.Parse(Console.ReadLine());
			int resultado = suma(numero);
			Console.WriteLine("El resultado es: " + resultado);
			Console.Write("Pulse una Tecla:");
			Console.ReadLine();
		}

		static int suma(int n)
        {
			if (n != 0)
			{
				return suma(n / 10) + n % 10;
			}
			else
			{
				return 0;
			}
		}

		public static void arreglo()
		{
			int tamanio = 0;
			List<char> chars = new List<char>();
			 

			do
			{
				Console.Write(" ingrese tamaño arreglo");
				tamanio = Convert.ToInt32(Console.ReadLine());

			} while (tamanio <= 0);


			int i = 0;
			do
			{
				Console.Write(" ingrese caracter");
				var charT = Convert.ToChar(Console.ReadLine());
				if (!chars.Contains(charT))
				{
					chars.Add(charT);
					i++;
				}

			} while (i < tamanio);


			ResolverArray(tamanio, chars.ToArray());
		}
		public static void ResolverArray(int tamanio, char[] valores)
		{

			int n = tamanio;
			int i;
			int j;
			int k;


			for (i = 1; i <= n; i++)
			{
				for (j = i, k = 1; k <= n; k++, j++)
				{
					if (j > n)
					{
						for (j = 1; k <= n; k++, j++)
						{
							Console.Write(" {0:D}", valores[j - 1]);
						}
					}

					else
					{
						Console.Write(" {0:D}", valores[j - 1]);
					}
				}
				Console.Write("\n");
			}
		}

		public static void objetos()
        {
			Empleado e1 = new Empleado();
			JornadaLaboral jl1 = new JornadaLaboral(new DateTime(2020, 10, 10), 400);
			JornadaLaboral jl2 = new JornadaLaboral(new DateTime(2019, 2, 2), 480);

			List<JornadaLaboral> jornadas = new List<JornadaLaboral>();
			jornadas.Add(jl1);
			jornadas.Add(jl2);

			e1.setJornadaLaboral(jornadas);
			var resultado = e1.totalTrabajadoMes(2, 2019);

			Console.WriteLine("total minutos trabajados:  " + resultado);

			Console.WriteLine(string.Format("{0}:{1}", (resultado / 60), resultado));
		}

		public static void linq()
        {
			IList<Cliente> clientes = new List<Cliente>() {
			new Cliente() { Id = 1, Nombre = "Juan", Apellido = "Perez", Domicilio =
			"Salta 314", Telefono = 154356989, Saldo = 20000, Cuit = 20291126587 } ,
			 new Cliente() { Id = 2, Nombre = "Pedro", Apellido = "Hernandez", Domicilio =
			"Chaco 456", Telefono = 151454789, Saldo = 36000, Cuit = 20244126587 } ,
			 new Cliente() { Id = 3, Nombre = "Jose", Apellido = "Chatruc", Domicilio =
			"Lavalle 789", Telefono = 154352589, Saldo = 28000, Cuit = 20291336587 } ,
			 new Cliente() { Id = 4, Nombre = "Carlos" , Apellido = "Alonso", Domicilio =
			"Rioja 14", Telefono = 154354789, Saldo = 45000, Cuit = 20297726587 } ,
			 new Cliente() { Id = 5, Nombre = "Claudio" , Apellido = "Ahumada", Domicilio =
			"Lima 125", Telefono = 154964789, Saldo = 28000, Cuit = 20291125587 } ,
			 new Cliente() { Id = 5, Nombre = "Sebastian" , Apellido = "Tobar", Domicilio =
			"Rawson 123", Telefono = 154357489, Saldo = 22000, Cuit = 20291158447 } ,
			 new Cliente() { Id = 5, Nombre = "Javier" , Apellido = "Puebla", Domicilio =
			"Italia 987", Telefono = 154358589, Saldo = 33000, Cuit = 20301126587 } ,
			 new Cliente() { Id = 5, Nombre = "Fabian" , Apellido = "Gilar", Domicilio =
			"Las Viñas 987", Telefono = 154554789, Saldo = 38000, Cuit = 20311126587 } ,
			 new Cliente() { Id = 5, Nombre = "Victor" , Apellido = "Pereira", Domicilio =
			"25 de Mayo 654", Telefono = 154356589, Saldo = 37000, Cuit = 20321126587 } ,
			 new Cliente() { Id = 5, Nombre = "Nelson" , Apellido = "Piquet", Domicilio =
			"Peru 987", Telefono = 154454789, Saldo = 26000, Cuit = 20331126587 }
			 };

			// Clientes cuyo saldo sea mayor a 30000 ordenados por saldo ascendente

			var clienteQuery = from cliente in clientes
							   where cliente.Saldo > 30000
							   orderby cliente.Saldo ascending
							   select cliente.Saldo;

			foreach (var cliente in clienteQuery)
			{
				Console.WriteLine("Clientes cuyo saldo es mayor a 30000 ordenados por saldo ascendente: " + cliente);

			}
			Console.WriteLine("Presionar enter para continuar");
			Console.ReadLine();

			//Clientes cuyo apellido inicien con p ordenados por Nombre


			var clienteQuery1 = from cliente1 in clientes
								where cliente1.Apellido.StartsWith("P")
								orderby cliente1.Nombre
								select cliente1.Nombre;


			foreach (var cliente1 in clienteQuery1)
			{
				Console.WriteLine("Clientes cuyo apellido inicien con p ordenados por Nombre: " + cliente1);

			}
			Console.WriteLine("Presionar enter para continuar");
			Console.ReadLine();

			//cantidad de saldos.

			var clienteQuery2 = from cliente2 in clientes
								select cliente2;
			int saldos = clienteQuery2.Count();

			Console.WriteLine("Cantidad de Saldos : " + saldos);

			Console.WriteLine("Presionar enter para continuar");
			Console.ReadLine();

			//cliente con el máximo saldo. (

			var clienteQuery3 = from cliente3 in clientes
								select cliente3.Saldo;

			var maximoSaldo = clienteQuery3.Max();

			var clienteQuery4 = from cliente4 in clientes
								where cliente4.Saldo == maximoSaldo
								select cliente4.Nombre;
			Console.WriteLine("Nombre del Cliente con el maximo saldo::  " + clienteQuery4.First());

			Console.WriteLine("Presionar enter para continuar");
			Console.ReadLine();

			//Promedio Saldos

			var clienteQuery5 = from cliente5 in clientes
								select cliente5.Saldo;

			var promedio = clienteQuery5.Average();

			Console.WriteLine("Promedio : " + promedio);

			Console.WriteLine("Presionar enter para continuar");
			Console.ReadLine();

		}

	}
}

