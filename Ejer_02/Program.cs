using System;

namespace Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("El cuadrado de {0} es {1}", num, Math.Pow(num, 2));
                    Console.WriteLine("El cubo de {0} es {1}", num, Math.Pow(num, 3));
                }
                else
                {
                    Console.WriteLine("Error, reingrese el numero!");
                }
            } while (num <= 0);
            
        }
    }
}
