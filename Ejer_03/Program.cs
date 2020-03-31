using System;

namespace Ejer_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,flag=0,j,i;

            Console.WriteLine("Ingrese un numero:");
            numero=int.Parse(Console.ReadLine());

            if(numero>1)
            {
                for(i=2;i<=numero;i++)
                {
                    for(j=i;j>=1;j--)
                    {
                        if(i%j==0)
                        {
                            flag++;
                        }
                    }
                    if(flag==2)
                    {
                        Console.Write("{0}-",i);
                    }
                    flag = 0;
                }

            }
        }
    }
}
