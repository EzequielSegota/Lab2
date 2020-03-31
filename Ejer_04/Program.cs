using System;

namespace Ejer_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, acum = 0;

            for(i=1;i<=10000;i++)
            {
                for(j=i-1;j>=1;j--)
                {
                    if(i%j==0)
                    {
                        acum += j;
                    }
                }

                if(acum==i)
                {
                    Console.WriteLine("Numero perfecto:{0}", i);
                }
                acum = 0;
            }
        }
    }
}
