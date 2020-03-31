using System;

namespace Ejer_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string bin;
            Console.Title = "Ejercicio 13";

            Console.Write("Ingrese num a convertir(int):");
            num = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Conversor.DecimalBinario(num));

            Console.Write("Ingrese un binario:");
            bin = Console.ReadLine();
            Console.WriteLine(Conversor.BinarioDecimal(bin));
        }
    }
}
