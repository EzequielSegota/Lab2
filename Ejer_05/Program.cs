using System;

namespace Ejer_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,j,k,sumNumAnt=0,sumNumSig=0;
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            if(num>1)
            {
                for(i=1;i<num;i++)
                {
                    for(j=i-1;j>=1;j--)
                    {
                        sumNumAnt += j;
                    }

                    for(k=i+1;k<=num;k++)
                    {
                        sumNumSig += k;
                    }

                    if(sumNumSig==sumNumAnt)
                    {
                        Console.WriteLine("Suma de anteriores:{0}\nNumero Centrico:{1}\nSuma de siguientes:{2}",sumNumAnt,i,sumNumSig);
                    }
                    sumNumAnt = 0;
                    sumNumSig = 0;
                }
            }
        }
    }
}
