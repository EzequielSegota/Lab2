using System;

namespace Ejer_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicial, anioFinal,i;
            Console.WriteLine("Ingrese año inicial:");
            anioInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año final:");
            anioFinal = int.Parse(Console.ReadLine());
            Console.Write("Los años bisiestos entre {0} y {1} son:", anioInicial, anioFinal);
            for(i=anioInicial;i<=anioFinal;i++)
            {
                if (i % 4 == 0 || (i % 100 != 0 && i % 400 == 0))
                    Console.Write("{0}-",i);
            }
        }
    }
}
