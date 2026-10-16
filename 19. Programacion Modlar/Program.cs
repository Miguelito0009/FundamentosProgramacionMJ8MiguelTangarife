using System;
namespace _19.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }
        static float Division()
        {
            float division = 1;
            float numero = 1;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número:");
                numero = float.Parse(Console.ReadLine());
                division /= numero;
                Console.WriteLine("Quiere seguir dividiendo?: (si) para continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 'si');
            return division;
        }
        static float Resta()
        {
            Console.WriteLine("Ingrese el número 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;

        }
        static float Multiplicacion()
        {
            float multiplicacion = 1;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número:");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Quiere seguir multiplicando?: (si) para continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 'si');
            return multiplicacion;
        }
        static float Suma()
        {
            float suma = 0;
            float numero = 0;
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingrese un número:");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Quiere seguir sumando?: (si) para continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 'si');
            return suma;
        }
        static void RealizarOperaciones(int opcion)
        {
            while ()
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La Suma de los números ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de los números ingresados es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La Multiplicación de los números ingresados es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La División de los números ingresados es {Division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }

        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMenu()
        {
            Console.WriteLine("---------------------- MENÚ -------------------------");
            Console.WriteLine("1.Suma                          2.Resta");
            Console.WriteLine("3.Multiplicación                4.División");
            Console.WriteLine("0.Salir");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ingrese una opción del menú:");
        }
    }
}
