using System;
namespace _8.CiclosWhile__trabajo_en_casa_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int acumulador = 0;

            Console.WriteLine("Ingrese un numero entero positivo para sumar: ");
            Console.WriteLine("ingrese un numero negativo para terminar: ");

            num = int.Parse(Console.ReadLine());

            while (num >= 0)
            {
                acumulador += num;
                Console.WriteLine("Ingrese un numero entero positivo para sumar ");
                Console.WriteLine("ingrese un numero negativo para terminar: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma total de los numeros ingresados es: " + acumulador);

        }
    }
}
