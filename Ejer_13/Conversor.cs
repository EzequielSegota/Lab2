using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_13
{
    public class Conversor
    {
        public static string DecimalBinario(int valor)
        {
            return Convert.ToString(valor,2); 
        }

        public static int BinarioDecimal(string valor)
        {
            return Convert.ToInt32(valor,2);
        }
    }
}
