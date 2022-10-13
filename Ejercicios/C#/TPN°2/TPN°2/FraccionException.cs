using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN_2
{
    class FraccionException : Exception
    {
        public FraccionException() { }

        public FraccionException(string message): base("No puede ingresar un denominador de valor cero") { }

        public FraccionException(string message, Exception innerException):base(message, innerException) { }


    }
}
