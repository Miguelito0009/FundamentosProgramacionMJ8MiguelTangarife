using System;

namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;

            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los cinco primeros números es: {acumulador}");
        }
    }
}
