using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_de_Clases
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            Sello.mensaje = ArmarFormatoMensaje();
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            int i, largoString;
            string asteriscos = "";
            largoString = Sello.mensaje.Length;
            for (i = 0; i < largoString + 2; i++)
            {
                asteriscos += "*";
            }
            return (asteriscos + "\n*" + Sello.mensaje + "*\n" + asteriscos);
        }
    }  
}
