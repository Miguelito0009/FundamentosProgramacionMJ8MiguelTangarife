using System;

class Program
{
    static void Main()
    {
        /* int[] vector = new int[15];

         for (int i = 0; i < 15; i++)
         {
             Console.Write("Ingrese el número " + (i + 1) + ": ");
             vector[i] = int.Parse(Console.ReadLine());
         }

         int maximo = vector[0];
         int minimo = vector[0];

         for (int i = 1; i < 15; i++)
         {
             if (vector[i] > maximo)
             {
                 maximo = vector[i];
             }

             if (vector[i] < minimo)
             {
                 minimo = vector[i];
             }
         }

         Console.WriteLine();
         Console.WriteLine("El número máximo es: " + maximo);
         Console.WriteLine("El número mínimo es: " + minimo);*/

        int[] vector1 = new int[10];
        int[] vector2 = new int[10];
        int iguales = 0;
        Console.WriteLine("Ingrese los números del primer vector:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            vector1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nIngrese los números del segundo vector:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            vector2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            if (vector1[i] == vector2[i])
            {
                iguales++;
            }
        }
        Console.WriteLine("\nCantidad de elementos iguales: " + iguales);
    }
}