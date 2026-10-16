using System;

namespace Trabajo3_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumaNotas = 0;
            int contadorNotas = 0;
            string opcion = "si";

            Console.WriteLine("--- Calculo de Promedio de Notas ---");

            while (opcion == "si" || opcion == "Si" || opcion == "SI")
            {
                Console.Write("Ingrese la calificacion: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                sumaNotas = sumaNotas + nota;
                contadorNotas = contadorNotas + 1;

                Console.Write("Desea ingresar otra calificacion? (si/no): ");
                opcion = Console.ReadLine();
                Console.WriteLine();
            }

            if (contadorNotas > 0)
            {
                double promedio = sumaNotas / contadorNotas;
                Console.WriteLine("El promedio de las calificaciones ingresadas es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}


namespace Trabajo3_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Encontrar Divisores de un Numero ---");

            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los divisores del numero " + numero + " son:");

            for (int i = numero; i >= 1; i--)
            {
                if (numero % i == 0)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Fin del programa. Presione una tecla para cerrar.");
            Console.ReadKey();
        }
    }
}
