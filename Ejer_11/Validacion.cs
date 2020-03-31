using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_11
{
    public class Validacion
    {
        /*Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/

        public static bool Validar(int valor, int min, int max)
        {
            bool aux=true;
            if(valor<min || valor>max)
            {
                aux = false;
            }
            return aux;
        }
    }
}
