using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ejercicio
{
	class Program
	{
		static void Main(string[] args)
		{
			//numerosposicion();
			 //cadena();
			  //numeros();
			 // ejercicioRecursion();
			//objeto();
			// arreglo();
		}

		public static string num(string param, int startIndex, int length)
		{
			 
		 string result =  param.Substring(startIndex, length);
		 return result;
		}
		private static void numerosposicion()
        {  
			string cadena;
			Console.WriteLine("Introduce un texto: ");
			cadena = Console.ReadLine();
		
			for(int i=0;i<cadena.Length;i++)
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
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}",cuatro, i + 1 + " el num es par");
						break;
					case "5":
						int cinco = 5;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", cinco, i + 1 + " el num es impar");
						break;
					case "6":
						int seis = 6;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", seis, i + 1  + " el num es par");
						break;
					case "7":
						int siete = 7;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", siete, i + 1 + " el num es impar");
						break;
					case "8":
						int ocho = 8;
						Console.WriteLine("Se encontro el numero {0}  en la posicion {1}", ocho, i + 1 +" el num es par");
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
		public static string Mid(string param, int startIndex, int length)
		{
			string result = param.Substring(startIndex, length);
			return result;
		}
		private static void cadena()
		{
			string cadena;
			int i = 0;
			 
			// guardamos las vocales en un array de enteros
			int[] vocales = { 0, 0, 0, 0, 0 };

			Console.Write("Introduce un texto : ");
			cadena = Console.ReadLine();

			// recorremos cada uno de los caracteres en busca de las vocales
			for (i = 0; i < cadena.Length; i++)
			{
				switch (Mid(cadena.ToUpper(), i, 1))
				{
					case "A":
						vocales[0] += 1;
						break;
					case "E":
						vocales[1] += 1;
						break;
					case "I":
						vocales[2] += 1;
						break;
					case "O":
						vocales[3] += 1;
						break;
					case "U":
						vocales[4] += 1;
						break;

				}
			}
			Console.WriteLine("La letra A aparece " + vocales[0] + " veces");
			Console.WriteLine("La letra E aparece " + vocales[1] + " veces");
			Console.WriteLine("La letra I aparece " + vocales[2] + " veces");
			Console.WriteLine("La letra O aparece " + vocales[3] + " veces");
			Console.WriteLine("La letra U aparece " + vocales[4] + " veces");

			Console.Write("Pulse una Tecla:");
			Console.ReadLine();
		}
		private static void numeros()
		{
			string cadena;
			int i = 0;

			// guardamos las vocales en un array de enteros
			int[] vocales = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

			Console.Write("Introduce una cadena : ");
			cadena = Console.ReadLine();

			// recorremos cada uno de los caracteres en busca de las vocales
			for (i = 0; i < cadena.Length; i++)
			{
				switch (Mid(cadena.ToUpper(), i, 1))
				{
					case "1":
						vocales[0] += 1;
						break;
					case "2":
						vocales[1] += 1;
						break;
					case "3":
						vocales[2] += 1;
						break;
					case "4":
						vocales[3] += 1;
						break;
					case "5":
						vocales[4] += 1;
						break;
					case "6":
						vocales[5] += 1;
						break;
					case "7":
						vocales[6] += 1;
						break;
					case "8":
						vocales[7] += 1;
						break;
					case "9":
						vocales[8] += 1;
						break;
				}
			}
			Console.WriteLine("El numero 1 aparece " + vocales[0] + " veces");
			Console.WriteLine("El numero 2 aparece " + vocales[1] + " veces");
			Console.WriteLine("El numero 3 aparece " + vocales[2] + " veces");
			Console.WriteLine("El numero 4 aparece " + vocales[3] + " veces");
			Console.WriteLine("El numero 5 aparece " + vocales[4] + " veces");
			Console.WriteLine("El numero 6 aparece " + vocales[5] + " veces");
			Console.WriteLine("El numero 7 aparece " + vocales[6] + " veces");
			Console.WriteLine("El numero 8 aparece " + vocales[7] + " veces");
			Console.WriteLine("El numero 9 aparece " + vocales[8] + " veces");

			Console.Write("Pulse una Tecla:");
			Console.ReadLine();
		}

		private static void ejercicioRecursion()
		{
			Console.WriteLine("Ingrese un numero");
			int numero = int.Parse(Console.ReadLine());
			int resultado = operacionRecursiva(numero);
			Console.WriteLine("Resultado: " + resultado);
			Console.Write("Pulse una Tecla:");
			Console.ReadLine();
		}
		static int operacionRecursiva(int nro)
		{
			if (nro != 0)
			{
				return operacionRecursiva(nro / 10) + nro % 10;
			}
			else
			{
				return 0;
			}
		}

		 private static void objeto()
		 {
			Empleado empleado = new Empleado();

		
			JornadaLaboral jb = new JornadaLaboral(new DateTime(2020, 10, 10),400);
			JornadaLaboral jb2 = new JornadaLaboral(new DateTime(2019, 2 , 2),480);
			//jb.fecha(new DateTime(2020, 10, 10));
			//jb.setMinutosTrabajados(480);

			//jb2.setFecha(new DateTime(2019, 2, 2));
			//jb2.setMinutosTrabajados(400);

			List<JornadaLaboral> jornadas = new List<JornadaLaboral>();
			jornadas.Add(jb);
			jornadas.Add(jb2);

			empleado.setJornadaLaboral(jornadas);
			var resultado =empleado.totalTrabajadoMes(2, 2019);
			//var resultado = empleado.totalTrabajadoMes(2, 2019);

		 	Console.WriteLine("total minutos:  " + resultado);

			Console.WriteLine(string.Format("{0}:{1}", (resultado / 60), resultado));
			//Console.WriteLine(string.Format("{0}:{1}", Horas(resultado), Minutosrestantes(resultado)));

		}
		/*
		private static int Horas(int minutos)
		{
			return minutos / 60;
		}
		/*
		private static object Minutosrestantes(int minutos)
		{
			return minutos % 60;
		}
		*/
		public static void arreglo()
        {
			int tamanio = 0;
			List<char> chars = new List<char>();
			//Console.Write(" ingrese tamaño arreglo");
			//tamanio = Convert.ToInt32(Console.ReadLine());

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
	}

	}
	 

