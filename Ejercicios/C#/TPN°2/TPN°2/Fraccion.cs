using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN_2
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public int Numerador
        {
            get
            {
                return numerador;
            }

            set
            {
                numerador = value;
            }
        }

        public int Denominador
        {
            get
            {
                return denominador;
            }

            set
            {
                denominador = value;
            }
        }

        public int suma(int n1, int n2, int d1, int d2)
        {
            if (d1 == 0 || d2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                int suma = 0;
                int denominador = mcm(d1, d2);
                suma = ((denominador / d1) * n1) + ((denominador / d2) * n2);
                return suma;
            }
        }
        public int resta(int n1, int n2, int d1, int d2)
        {

            if (d1 == 0 || d2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                int resta = 0;
                int denominador = mcm(d1, d2);
                resta = ((denominador / d1) * n1) - ((denominador / d2) * n2);
                return resta;
            }
        }
        public int multiplicacionNumerador(int n1, int n2)
        {
            return n1 * n2;

        }
        public int multiplicacionDenominador(int d1, int d2)
        {
            if (d1 == 0 || d2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                return d1 * d2;
            }
        }
        public int divisionNum(int n1, int d2)
        {
            if (d2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                return n1 * d2;
            }
        }
        public int divisionDen(int n2, int d1)
        {
            if (d1 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                return n2 * d1;
            }
        }
        public int mcm(int d1, int d2)
        {
            if (d1 == 0 || d2 == 0)
            {
                throw new FraccionException();
            }
            else
            {
                int mcm = 0;
                if (d1 == d2)
                {
                    mcm = d1;
                }
                else if (d1 == 1)
                {
                    mcm = d2;
                }
                else if (d2 == 1)
                {
                    mcm = d1;
                }
                else if (d1 != d2)
                {
                    int minimo = Math.Min(d1, d2);
                    for (int i = 1; i <= minimo; i++)
                    {
                        if (d1 % i == 0 && d2 % i == 0)
                        {
                            int mcd = i;
                            mcm = (d1 * d2) / mcd;
                        }
                    }
                }
                return mcm;
            }
        }
    }
}
