using System;

namespace Ejer_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,j;

            Console.Title="Ejercicio 9";

            Console.Write("Ingrese una altura:");
            num=int.Parse(Console.ReadLine());

            for(i=0;i<num;i++)
            {
                Console.WriteLine("*");
                for(j=i+2;j>1;j--)
                {
                    Console.Write("**");
                }
                j = 0;
            }
        }
    }
}
