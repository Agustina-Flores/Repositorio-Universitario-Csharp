using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TPN_2
{
    class Program
    {
        static void Main(string[] args)
        {
                        //ejercicio B1)
                        Fraccion fr1 = new Fraccion();
                        Fraccion fr2 = new Fraccion();
                        int opcion;

                        try
                        {
                            Console.WriteLine("Ingrese un número para el numerador: ");
                            fr1.Numerador = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Ingrese un número para el denominador: ");
                            fr1.Denominador = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Ingrese un número para el numerador: ");
                            fr2.Numerador = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Ingrese un número para el denominador: ");
                            fr2.Denominador = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Qué operación desea realizar: ");
                            Console.WriteLine("1.Sumar ");
                            Console.WriteLine("2.Restar");
                            Console.WriteLine("3.Multiplicar");
                            Console.WriteLine("4.Dividir");
                            opcion = Convert.ToInt16(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    int sumaFrac=fr1.suma(fr1.Numerador, fr2.Numerador, fr1.Denominador, fr2.Denominador);
                                    Console.WriteLine("La suma es: " + sumaFrac + "/" + fr1.mcm(fr1.Denominador, fr2.Denominador));
                                    break;
                                case 2:
                                    int restaFrac=fr1.resta(fr1.Numerador, fr2.Numerador, fr1.Denominador, fr2.Denominador);
                                    Console.WriteLine("La resta es: " + restaFrac + "/" + fr1.mcm(fr1.Denominador, fr2.Denominador));
                                    break;
                                case 3:
                                    int numeradorMult=fr1.multiplicacionNumerador(fr1.Numerador, fr2.Numerador);
                                    int denominadorMult=fr1.multiplicacionDenominador(fr1.Denominador, fr2.Denominador);
                                    Console.WriteLine("La multiplicación es: " + numeradorMult + "/" + denominadorMult);
                                    break;
                                case 4:
                                    int numeradorDiv = fr1.divisionNum(fr1.Numerador, fr2.Denominador);
                                    int denominadorDiv = fr1.divisionDen(fr2.Numerador, fr1.Denominador);
                                    Console.WriteLine("La división es: " + numeradorDiv + "/" + denominadorDiv);
                                    break;
                                default:
                                    Console.WriteLine("La opción ingresada no es correcta");
                                    break;
                            }
                        }
                        catch (FraccionException e)
                        {
                            Console.WriteLine("Excepción: "+e.Message);
                        }
                        Console.ReadKey();

                        //ejercicio B2)
                        string cadena1, cadena2;
                        Console.WriteLine("Ingrese una cadena de texto");
                        cadena1 = Console.ReadLine();
                        Console.WriteLine("Ingrese la cadena de texto que desea buscar en la anterior");
                        cadena2 = Console.ReadLine();
                        if (cadena2.Length <= cadena1.Length)
                        {
                            if (cadena1.Contains(cadena2) == true)
                            {
                                Console.WriteLine("ENCONTRADO");
                            }
                            else
                            {
                                Console.WriteLine("NO ENCONTRADO");
                            }
                        }

                        //ejercicio C1)
                        int filas, columnas;
                        Console.WriteLine("Ingrese el número de filas");
                        filas = Console.Read();
                        Console.WriteLine("Ingrese el número de columnas");
                        columnas = Console.Read();
                        String[,] matriz=new String [filas,columnas];
                        for(int i=0; i<=filas; i++)
                        {
                            for(int j=0; j<=columnas; j++)
                            {
                                if((i+1 == filas && j+1 == columnas) || (i+1 == columnas && j+1 == filas))
                                {
                                    matriz [i,j]= "X";
                                }else
                                {
                                    matriz[i, j] = "0";
                                }
                            }
                        }
                        for(int i=0; i<=filas; i++)
                        {
                            for(int j=0; j<=columnas; j++)
                            {
                                Console.WriteLine(matriz[i, j]+" ");
                            }
                            Console.WriteLine("");
                        }

                        //ejercicio C2)
                        String cadena;
                        Console.WriteLine("Ingrese una cadena de numeros separados por coma");
                        cadena = Console.ReadLine();
                        String [] matrizCadena=cadena.Split(',');
                        int suma = 0;
                        for(int i=0; i<=matrizCadena.Length; i++)
                        {
                            suma += Convert.ToInt32(matrizCadena[i]);
                        }
                        for(int i=0; i<=matrizCadena.Length; i++)
                        {
                            Console.WriteLine(matrizCadena[i] + " ");
                        }
                        Console.WriteLine("La suma de los números ingresados es= " + suma);

                        //ejercicio D7)

                        List<Figura> figuras = new List<Figura>();
                        Figura f1 = new Figura();
                        Rectangulo r1 = new Rectangulo();
                        Triangulo tri1 = new Triangulo();
                        Circulo c1 = new Circulo();
                        Figura f2 = new Figura();
                        Rectangulo r2 = new Rectangulo();
                        Triangulo tri2 = new Triangulo();
                        Circulo c2 = new Circulo();
                        figuras.Add(f1);
                        figuras.Add(r1);
                        figuras.Add(tri1);
                        figuras.Add(c1);
                        figuras.Add(f2);
                        figuras.Add(r2);
                        figuras.Add(tri2);
                        figuras.Add(c2);
                        foreach(Figura figura in figuras)
                        {
                            figura.Dibujar();
                        }
            
            //ejercicio E)

            Thread t1 = new Thread(ejecutarHiloCincoSeg);
            t1.Start();
            Thread t2 = new Thread(ejecutarHiloDiezSeg);
            t2.Start();
        }
        static void ejecutarHiloCincoSeg()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 5");
                Thread.Sleep(5000);
            }
        }
        static void ejecutarHiloDiezSeg()
        {
            while (true)
            {
                Console.WriteLine("HILO EJECUTADO 10");
                Thread.Sleep(10000);
            }
        }
        
    }
}
