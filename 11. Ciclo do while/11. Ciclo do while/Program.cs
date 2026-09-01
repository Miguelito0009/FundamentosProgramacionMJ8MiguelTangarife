using System;

namespace _11.CicloWhile

{

    internal class Program
    {

        static void Main(string[] args)

        {

            /*  int contador = 1;

              int acumulador = 0;


              do

              {

                  acumulador += contador;

                  contador++;


              }while (contador <=5);


              Console.WriteLine($"La suma dee los cinco primeros numeros enteros es:{acumulador}");


          int num1;

            string desi;


            do
            {

                Console.WriteLine("ingrese el numero que desea multiplicar");

                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"{num1} x1 = {num1 * 1}");

                Console.WriteLine($"{num1} x2 = {num1 * 2}");

                Console.WriteLine($"{num1} x3 = {num1 * 3}");

                Console.WriteLine($"{num1} x4 = {num1 * 4}");

                Console.WriteLine($"{num1} x5 = {num1 * 5}");

                Console.WriteLine($"{num1} x6 = {num1 * 6}");

                Console.WriteLine($"{num1} x7 = {num1 * 7}");

                Console.WriteLine($"{num1} x8 = {num1 * 8}");

                Console.WriteLine($"{num1} x9 = {num1 * 9}");

                Console.WriteLine($"{num1} x10 = {num1 * 10}");

                Console.WriteLine("Desea seguir multiplicando números? Para Si presione 1, Para No presione 2");

                desi = Console.ReadLine();

            } while (desi == "1");

            Console.WriteLine("Fin");
            */


            //Crear un algoritmo que permita calcular y mostar por pantalla los numeros primos hasta el numero 100


            int numero = 1;
            int contador = 0;
            int acumulador = 0;

            do
            {
                int divisor = 1;
                contador = 0;

                do
                {
                    if (numero % divisor == 0)
                    {
                        contador++;
                    }

                    divisor++;

                } while (divisor <= numero);

                if (contador == 2)
                {
                    Console.WriteLine(numero);
                    acumulador++;
                }

                numero++;

            } while (numero <= 100);

            Console.WriteLine("Cantidad de números primos: " + acumulador);
           
        }

    }

}