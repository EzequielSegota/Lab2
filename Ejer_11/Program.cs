using System;

namespace Ejer_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag=10,min=100,max=-100,valor,acum=0;
            float promedio;
            Console.Title = "Ejercicio 11";
            do
            {
                Console.Write("Ingrese un valor:");
                valor=int.Parse(Console.ReadLine());
                if(Validacion.Validar(valor,-100,100))
                {
                    if(valor<min)
                    {
                        min = valor;
                    }
                    if(valor>max)
                    {
                        max = valor;
                    }
                    acum += valor;
                    flag--;
                }
                else
                {
                    Console.WriteLine("Error, debe ser entre -100 y 100");
                }
            } while (flag>0);
            promedio = (float)acum/10;
            Console.Clear();

            Console.Write("El promedio es:{0}\nEl mayor valor fue:{1}\nEl menor valor fue:{2}",promedio,max,min);

            
        }
    }
}
