using System;

namespace Ejer_15
{
    class Program
    {
        static void Main(string[] args)
        {
            float operadorUno, operadorDos;
            char c;
            Console.Title="Ejercicio 15";

            Console.Write("Ingrese primer num:");
            operadorUno = float.Parse(Console.ReadLine());

            Console.WriteLine("Numero Uno:{0}",operadorUno);

            Console.Write("Ingrese segundo num:");
            operadorDos = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Numero Uno:{0}\nNumero Dos:{1}", operadorUno,operadorDos);

            Console.Write("Ingrese operador:");
            c = char.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Resultado:{0}",Calculadora.Calcular(operadorUno,operadorDos,c));

        }
    }
}
