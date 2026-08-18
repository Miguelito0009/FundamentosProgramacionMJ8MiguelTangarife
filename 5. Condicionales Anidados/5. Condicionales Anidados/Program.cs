using System;
namespace _5.Condicionales_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados
            //b.
            int num1 = 0;
            int num2 = 0;       
            int num3 = 0;

            Console.WriteLine("Ingrese 3 valores diferentes:");
            Console.Write("Ingrese el valor del numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del numero 3: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            { //verdadera
                if (num1 > num3)
                    Console.WriteLine("El numero 1 es el mayor");
                else
                    Console.WriteLine("El numero 3 es el mayor");
            }
            else
            { //falsa
                if (num2 > num3)
                    Console.WriteLine("El numero 2 es el mayor");
                else
                    Console.WriteLine("El numero 3 es el mayor");
            }
        }
    }
}