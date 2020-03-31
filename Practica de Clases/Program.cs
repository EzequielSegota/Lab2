using System;

namespace Practica_de_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string lala;

            Sello.mensaje = "Hola Mundo!";
            
            lala = Sello.Imprimir();

            Console.WriteLine(lala);


            Sello.Borrar();
            lala = Sello.Imprimir();

            Console.WriteLine(lala);


            Sello.mensaje = "Hola Mundoo!";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirColor();
            //Console.WriteLine(Sello.Imprimir());
            
        }
    }
}
