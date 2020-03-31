using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_15
{
    public class Calculadora
    {
        public static float Calcular(float numUno,float numDos,char c)
        {
            float ret=-1;
            switch(c)
            {
                case '-':
                    ret = numUno - numDos;
                    break;
                case '+':
                    ret = numDos + numUno;
                    break;
                case '*':
                    ret = numUno * numDos;
                    break;
                case '/':
                    if(Validar(numDos))
                    {
                        ret = numUno / numDos;
                    }
                    break;
                default:
                    Console.WriteLine("No ingreso un operador valido!");
                    
                    break;
            }
            return ret;
        }

        private static bool Validar(float numDos)
        {
            bool ret = false;
            if(numDos!=0)
            {
                ret = true;
            }
            return ret;
        }
    }
}
