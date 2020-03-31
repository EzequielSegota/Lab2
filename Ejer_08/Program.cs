using System;

namespace Ejer_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadasXMes, antiguedadAnios,flag=0;
            float valorHora,valorNeto, valorBruto, descuento;
            string nombre;
            do
            {
                Console.Write("Ingrese un nombre:");
                nombre = Console.ReadLine();

                Console.Write("Ingrese valor x hora:");
                valorHora = float.Parse(Console.ReadLine());

                Console.Write("Ingrese horas trabajadas al mes:");
                horasTrabajadasXMes = int.Parse(Console.ReadLine());

                Console.Write("Ingrese antiguedad(años):");
                antiguedadAnios = int.Parse(Console.ReadLine());

                valorBruto = valorHora * horasTrabajadasXMes + (antiguedadAnios * 150);
                descuento = (valorBruto * 13) / 100;
                valorNeto = valorBruto - descuento;

                Console.WriteLine("Nombre:{0}-Valor x Hora:{1}-Antiguedad:{2}\nImporte Bruto:{3}-Descuento:{4}-Importe Neto:{5}", nombre, valorHora, antiguedadAnios, valorBruto, descuento, valorNeto);
                
                Console.Write("Desea ingresar otro usuario?(1.Sí-0.No):");
                flag=int.Parse(Console.ReadLine());

                Console.Clear();
            } while(flag==1);
            
        }
    }
}
