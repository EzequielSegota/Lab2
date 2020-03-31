using System;

namespace Ejer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float num,min=0, max=0, promedio, acum=0;
            for(i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                num = float.Parse(Console.ReadLine());
                acum = num+acum;
                if (i == 0)
                {
                    min = max = num;
                }
                if(num>max)
                {
                    max = num;
                }
                if(num<min)
                {
                    min = num;
                }
            }
            promedio = acum / 5;
            Console.WriteLine("El promedio es:{0}\nEl maximo es:{1}\nEl minimo es:{2}", promedio,max,min);
        }
    }
}
