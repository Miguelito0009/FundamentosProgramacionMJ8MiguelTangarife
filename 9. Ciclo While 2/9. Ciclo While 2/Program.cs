using System;
namespace _9.Ciclo_While_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo que pida ingresar numeros enteros al azar, num mayores que 0, nume menores que 0 y iguales que 0

            int cantnum = 0;
            int num = 0;
            int contador = 0;
            int mayores = 0;
            int menores = 0;
            int ceros = 0;

            Console.WriteLine("Ingrese la cantidad de numeros:");
            cantnum = int.Parse(Console.ReadLine());

            while (cantnum > contador)
            {
                contador ++;
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());


                if (num > 0)
                {
                    mayores++;
                }
                else if (num < 0)
                {
                    menores++;
                  
                }
                else
                {
                    ceros++;
                    
                }
            }
            Console.WriteLine($"La cantidad de numeros mayores que 0 es: {mayores}");
            Console.WriteLine($"La cantidad de numeros menores que 0 es: {menores}");
            Console.WriteLine($"La cantidad de numeros iguales que 0 es: {ceros}");
        }
    }
}
