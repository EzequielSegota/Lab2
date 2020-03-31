using System;

namespace Ejer_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, m, a,i,diasVividos=0;
            Console.WriteLine("Ingrese dia de nac:");
            d=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes de nac:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese año de nac:");
            a = int.Parse(Console.ReadLine());

            diasVividos += (DateTime.DaysInMonth(a,m)-d);
            for(i=m+1;i<=12;i++)
            {
                diasVividos += DateTime.DaysInMonth(a, i);
            }

            for(i=a+1;i<DateTime.Now.Year;i++)
            {
                if(i%4==0 || (i%100!=0 && i%400==0))
                {
                    diasVividos += 366;
                }
                else
                {
                    diasVividos += 365;
                }
            }

            for(i=1;i<DateTime.Now.Month;i++)
            {
                diasVividos += DateTime.DaysInMonth(DateTime.Now.Year,i);
            }

            diasVividos += DateTime.Now.Day;

            Console.WriteLine("Dias Vividos:{0}",diasVividos);
        
        }
    }
}
