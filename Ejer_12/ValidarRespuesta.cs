using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_12
{
    public class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool ret=false;
            if(c=='s' || c=='S')
            {
                ret = true;
            }
            return ret;
        }
    }
}
