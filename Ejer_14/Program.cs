using System;

namespace Ejer_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo, alturaTriangulo;
            Console.Title="Ejercicio 14";

            Console.Write("Ingrese lado de Cuadrado:");
            Console.WriteLine("Su area de cuadrado es:{0}",CalculoDeArea.CalcularCuadrado(double.Parse(Console.ReadLine())));
            Console.Write("Ingrese base de Triangulo:");
            baseTriangulo=double.Parse(Console.ReadLine());
            Console.Write("Ingrese altura de Triangulo:");
            alturaTriangulo=double.Parse(Console.ReadLine());
            Console.WriteLine("Su area de triangulo es:{0}",CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo));
            Console.Write("Ingrese radio de Circulo:");
            Console.WriteLine("Su area de circulo es:{0}",CalculoDeArea.CalcularCirculo(double.Parse(Console.ReadLine())));
        }
    }
}
