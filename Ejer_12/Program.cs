using System;

namespace Ejer_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int acum=0;
            char validacion;
            Console.Title = "Ejercicio 12";
            do {
                Console.Write("Ingrese un valor a sumar:");
                acum += int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Su suma vale:{0}\nContinuar?(S/N)", acum);
                validacion=char.Parse(Console.ReadLine());
            } while (ValidarRespuesta.ValidarS_N(validacion));
            
        }
    }
}
