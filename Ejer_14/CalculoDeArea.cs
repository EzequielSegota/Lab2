using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado,2);
        }

        public static double CalcularTriangulo(double basee,double altura)
        {
            return (basee*altura)/2;
        }

        public static double CalcularCirculo(double radio)
        {
            return Math.PI*(Math.Pow(radio,2));
        }
    }
}
