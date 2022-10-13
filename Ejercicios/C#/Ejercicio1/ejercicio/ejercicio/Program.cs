using System;
using System.Text;

namespace ejercicio
{
    class Program
    {
     
        static void Main(string[] args)
        {

           divisible();
             //random();
            // esPar();
            //operaciones();
            // calcularSueldos();
            //recursion();
          cadenas();

        }
        public static void divisible()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                    Console.WriteLine("numeros divisibles entre 2 y 5: " + i);
                Console.WriteLine("");
            }


        }

        public static void random()
        {
             
            
            Random random = new Random();

            int numeroAleatorio = random.Next(1, 100);
           // Console.WriteLine("Numero aleatorio generado: " + numeroAleatorio);
            bool ingreso = false;
            int contador = 0;


            do
            {

                Console.WriteLine("Ingrese un numero entre 0 y 100");
                int numero = Int32.Parse(Console.ReadLine());

                contador++;
                if (numero < numeroAleatorio)
                {
                    Console.WriteLine("Es muy bajo");
                }
                else if (numero > numeroAleatorio)
                {
                    Console.WriteLine("Es muy alto");
                }

                else
                {
                    Console.WriteLine("Correcto numero encontrado , cantidad de intentos " + contador);
                    ingreso = true;
                }
            } while (ingreso == false);

        }

        public static void esPar()
        {
            string opcion = "";
            do
            {
                Console.WriteLine("Ingrese numero ");
                int numero = Int32.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El numero " + numero + " es par");

                }
                else
                {
                    Console.WriteLine("El numero " + numero + " es impar");
                }

                Console.WriteLine("Desea ingresar mas numeros.Ingrese si para continuar  o no para salir ");
                opcion = Console.ReadLine();
                 

            } while (opcion.Equals("si"));
        }


        public static void operaciones()
        {
            string operacion ="";
            bool ingreso = false;
            do
            {

                Console.WriteLine("Ingrese dos numero decimales");
                double numero1 = Double.Parse(Console.ReadLine());
                double numero2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Elija la operacion matematica que realizara(" +
                    "a.Suma +," +
                    "b.Resta -," +
                    "c.Multiplicacion *," +
                    "d.Division /" +
                    "e.Modulo ,%)");
                operacion = Console.ReadLine();
                Console.WriteLine("\n");

                switch (operacion)
                {
                    
                    case "a":
                        {
                            Console.WriteLine("La suma es: " + suma(numero1, numero2));
                            ingreso = false;
                            break;
                        }
                    case "b":
                        {
                            Console.WriteLine("La resta es: " + resta(numero1, numero2));
                            ingreso = false;
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine("La multiplicacion es: " + multiplicacion(numero1, numero2));
                            ingreso = false;
                            break;
                        }
                    case "d":
                        {

                            Console.WriteLine("La division es: " + division(numero1, numero2));
                            ingreso = false;
                            break;
                        }
                    case "e":
                        {
                            Console.WriteLine("El modulo es: " + modulo(numero1, numero2));
                            ingreso = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("La opción ingresada no es válida");
                            ingreso = true;
                            break;
                        }
                }

            } while (ingreso == true);
        }
            static double suma(double n1, double n2)
            {
                double suma = n1 + n2;
                return suma;
            }

            static double resta(double n1, double n2)
            {
                double resta = n1 - n2;
                return resta;
            }

            static double multiplicacion(double n1, double n2)
            {
                double mult = n1 * n2;
                return mult;
            }

            static double division(double n1, double n2)
            {
                double div = n1 / n2;
                return div;
            }
            static double modulo(double n1, double n2)
            {
                double mod = n1 % n2;
                return mod;
            }

 

        public static void recursion()
        {
            Console.WriteLine("Ingrese un numero");
            long numero = Int32.Parse(Console.ReadLine());
              mult(numero,1);
        }

        static void mult(long valor, int iteracion)
        {
            long valorCalculado = valor * valor;
            Console.WriteLine(iteracion + " iteracion => " + valor + "*" + valor + "=" + valorCalculado);
            if (valorCalculado > 100000000)
            {
                return;
            }
            mult(valorCalculado, ++iteracion);
        }

        public static void cadenas()
        {
           

            string palabra = "hola mundo";
            string palabra2 = "HOLA MUNDO";
            StringBuilder sb = new StringBuilder(palabra2, 50);
            Console.WriteLine("Ingrese cadena");
            string cadena = Console.ReadLine();
            Console.WriteLine(cadena.Length);
             
            Console.WriteLine(palabra.Contains("mundo"));
            Console.WriteLine(palabra.IndexOf('a'));//posicion //3
            Console.WriteLine(palabra.Remove(1, 5));//hundo
            Console.WriteLine(palabra.Replace('m', '-'));//hola -undo
            Console.WriteLine(palabra.Substring(5));//mundo
             
            Console.WriteLine(palabra.ToUpper());// HOLA MUNDO
            Console.WriteLine(palabra2.ToLower());//hola mundo

            sb.Append("World!!"); //HOLA MUNDOWorld
            Console.WriteLine(sb);

            sb.Append("World!!");
        }
        public static void calcularSueldos()
        {
            int horaEntrada, horaSalida, minEntrada, minSalida, minTotales, horasFinales;
            double sueldo, horasDiurnas, horasNocturnas;
            do
            {
                Console.WriteLine("Por favor ingrese el horario de ingreso: ");
                horaEntrada = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese los minutos de ingreso: ");
                minEntrada = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese el horario de salida: ");
                horaSalida = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese los minutos de salida: ");
                minSalida = Int32.Parse(Console.ReadLine());
                horasFinales = horaSalida - horaEntrada;
                minTotales = horasAMinutos(horasFinales) + minEntrada + minSalida;

                if (minTotales > 480 )//|| minTotales < 0
                {
                    Console.WriteLine("La cantidad máxima de horas a trabajar es 8 horas diarias");
                }
            } while (minTotales > 480 );//|| minTotales < 0

            if (horaEntrada < horaSalida )
            {
                if (horaEntrada >= 8 && horaSalida <= 20)//8-16
                {
                    horasFinales = horaSalida - horaEntrada;
                    minTotales = horasAMinutos(horasFinales) - minEntrada + minSalida;
                    sueldo = (minTotales / 60) * 10;
                    Console.WriteLine("Las horas trabajadas hoy son: " + (minTotales / 60) + "hs");
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));
                }
                else if (horaEntrada > 8 && horaSalida > 20)//18-23*
                {
                    horasDiurnas = (horasAMinutos(20 - horaEntrada) - minEntrada) / 60;
                    horasNocturnas = (horasAMinutos(horaSalida - 20) + minSalida) / 60;
                    sueldo = (horasDiurnas * 10) + (horasNocturnas * 15);
                    Console.WriteLine("Las horas trabajadas hoy son: " + (horasDiurnas + horasNocturnas) + "hs");
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));

                }
                else if (horaEntrada < 8 && horaSalida < 20)//7:45-14:20*
                {
                    horasNocturnas = (horasAMinutos(8 - horaEntrada) - minEntrada) / 60;
                    horasDiurnas = (horasAMinutos(20 - horaSalida) - minSalida) / 60;
                    sueldo = (horasDiurnas * 10) + (horasNocturnas * 15);
                    Console.WriteLine("Las horas trabajadas hoy son: " + (horasDiurnas + horasNocturnas));
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));
                }
                else if (horaEntrada > 8 && horaSalida <= 20 && minSalida > 0)//18-20:45*
                {
                    horasNocturnas = (horasAMinutos(20 - horaSalida) + minSalida) / 60;
                    horasDiurnas = (horasAMinutos(20 - horaEntrada) - minEntrada) / 60;
                    sueldo = (horasDiurnas * 10) + (horasNocturnas * 15);
                    Console.WriteLine("Las horas trabajadas hoy son: " + (horasDiurnas + horasNocturnas));
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));
                }
            }
            if (horaEntrada > horaSalida)
            {
                if (horaEntrada >= 20 && horaSalida <= 8)//22:30-3*
                {
                    horasFinales = (24 - horaEntrada) + horaSalida;
                    minTotales = horasAMinutos(horasFinales) - minEntrada + minSalida;
                    sueldo = (minTotales / 60) * 15;
                    Console.WriteLine("Las horas trabajadas hoy son: " + (minTotales / 60) + "hs");
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));

                }
                else if (horaEntrada < 20 && horaSalida < 8)//19:30-3
                {
                    horasDiurnas = (horasAMinutos(20 - horaEntrada) - minEntrada) / 60;
                    horasNocturnas = (horasAMinutos(24 - 20) + horasAMinutos(0 + horaSalida) + minSalida) / 60;
                    sueldo = (horasDiurnas * 10) + (horasNocturnas * 15);
                    Console.WriteLine("Las horas trabajadas hoy son: " + (horasDiurnas + horasNocturnas));
                    Console.WriteLine("El salario del día es de: $" + sueldo);
                    Console.WriteLine("El salario del mes es de: $" + (sueldo * 24));
                }
            }

        }
         
        static int horasAMinutos(int horas) 
        {
            return (horas * 60);
        }
        
        
    }


    }
    //}
 