using System;

class Program
{
    static void Main(string[] args)
    {
        // Ingresar datos del empleado
        Console.Write("Ingrese el nombre:");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese los años trabajados:");
        int añosTrabajados = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la calificación del año actual (0.0, 0.4, 0.6 o 1.0):");
        string entradaActual = Console.ReadLine();

        Console.Write("Ingrese la calificación del año anterior (0.0, 0.4, 0.6 o 1.0):");
        string entradaAnterior = Console.ReadLine();

        // Convertir las calificaciones
        double calificacionActual = double.Parse(entradaActual.Replace(".", ","));
        double calificacionAnterior = double.Parse(entradaAnterior.Replace(".", ","));

        // Validar las calificaciones
        bool actualValida =
            calificacionActual == 0.0 ||
            calificacionActual == 0.4 ||
            calificacionActual == 0.6 ||
            calificacionActual == 1.0;

        bool anteriorValida =
            calificacionAnterior == 0.0 ||
            calificacionAnterior == 0.4 ||
            calificacionAnterior == 0.6 ||
            calificacionAnterior == 1.0;

        if (!actualValida || !anteriorValida)
        {
            Console.WriteLine("Error: calificación inválida. El programa terminará.");
        }
        else
        {
            // Calcular promedio
            double promedioCalificacion =
                (calificacionActual + calificacionAnterior) / 2;

            // Determinar porcentaje de aumento
            double porcentajeAumento;

            if (añosTrabajados == 0)
            {
                porcentajeAumento = 0;
            }
            else if (añosTrabajados > 5)
            {
                porcentajeAumento = 30;
            }
            else if (promedioCalificacion < 0.4)
            {
                porcentajeAumento = 5;
            }
            else if (promedioCalificacion < 0.6)
            {
                porcentajeAumento = 10;
            }
            else
            {
                porcentajeAumento = 20;
            }

            // Sueldo base
            double sueldoBase = 2500000;

            // Calcular valor del aumento
            double valorAumento =
                sueldoBase * (porcentajeAumento / 100);

            // Mostrar resultados
            Console.WriteLine();
            Console.WriteLine("----- RESULTADOS -----");
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Promedio de calificación: " + promedioCalificacion);
            Console.WriteLine("el sueldo base: $" + sueldoBase.ToString("N0"));
            Console.WriteLine("Porcentaje de aumento aplicado: " + porcentajeAumento + "%");
            Console.WriteLine("Valor del aumento: $" + valorAumento.ToString("N0"));
            Console.WriteLine("Sueldo final: $" + (sueldoBase + valorAumento).ToString("N0"));
        }
    }
}
