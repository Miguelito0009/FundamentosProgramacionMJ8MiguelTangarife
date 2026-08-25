using System;
namespace _7.Ciclowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //1. generar 5 numeros enteros positivos y realizar y mostrar su suma 

            int contador = 1;
            int acumulador = 1;

            while (contador < 5) ;
            {
                contador++;
                acumulador = acumulador +contador;

            } 
            Console.WriteLine("La suma de los 5 numeros enteros positivos es: " + acumulador);

            */
            //crear un algoritmo que permita calcular la diferencia de un numero dado por el usuario. (5! = 1*2*3*4*5)

            int num1 = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un numero entero positivo: ");
            num1 = int.Parse(Console.ReadLine());

            while (contador <= num1)
            {
                acumulador = acumulador * contador;
                contador++;
            }

            Console.WriteLine("El factorial de " + num1 + " es: " + acumulador);
        }
    }
}
