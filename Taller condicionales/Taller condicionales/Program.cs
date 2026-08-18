using System;
internal class Program
{
    static void Main(string[] args)
    {
        // Leer tres números
        Console.Write("Ingrese el primer número: ");
        int.TryParse(Console.ReadLine(), out int Num1);

        Console.Write("Ingrese el segundo número: ");
        int.TryParse(Console.ReadLine(), out int Num2);

        Console.Write("Ingrese el tercer número: ");
        int.TryParse(Console.ReadLine(), out int Num3);

        // Si hay números iguales
        if (Num1 == Num2 || Num1 == Num3 || Num2 == Num3)
        {
            Console.WriteLine("Hay números iguales. Debe ingresar números diferentes.");
        }
        else
        {
            // Determinar cuál es el número mayor
            int mayor = Num1;
            string nombreMayor = "numero1";

            if (Num2 > mayor)
            {
                mayor = Num2;
                nombreMayor = "numero2";
            }

            if (Num3 > mayor)
            {
                mayor = Num3;
                nombreMayor = "numero3";
            }

            Console.WriteLine($"El número mayor es {nombreMayor} = {mayor}");

            // Ordenar de menor a mayor
            int menor = Num1;

            if (Num2 < menor)
            {
                menor = Num2;
            }

            if (Num3 < menor)
            {
                menor = Num3;
            }

            int suma = Num1 + Num2 + Num3;
            int medio = suma - mayor - menor;

            Console.WriteLine($"Números ordenados de menor a mayor: {menor}, {medio}, {mayor}");
        }
    }
}

        