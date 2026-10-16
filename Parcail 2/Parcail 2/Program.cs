using System;

class Program
{
    static void Main()
    {       
       //registro de 12 vehiculos de un parqueadero,seleccionando si es moto, carro o camion
        int tipo;
        double horas;
        double valorPagar;
        double totalRecaudado = 0;
        int motos = 0;
        int automoviles = 0;
        int camiones = 0;
        

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("Vehículo #" + i);
            Console.Write("Ingrese el tipo de vehículo ( 1 = Moto, 2 = Automóvil, 3 = Camión): ");
            
            tipo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de horas estacionado: ");
            horas = double.Parse(Console.ReadLine());

            valorPagar = 0;

            if (tipo == 1)
            {
                valorPagar = horas * 3000;

                if (horas > 4)
                {
                    valorPagar = valorPagar * 0.90;
                }

                motos++;
            }
            else if (tipo == 2)
            {
                if (horas > 3)
                {
                    valorPagar = 20000;
                }
                else
                {
                    valorPagar = horas * 5000;
                }

                automoviles++;
            }
            else if (tipo == 3)
            {
                valorPagar = horas * 10000;

                if (horas > 5)
                {
                    valorPagar = valorPagar + 15000;
                }

                camiones++;
            }
            else
            {
                Console.WriteLine("Tipo de vehículo inválido.");
                i--;
            }

            totalRecaudado = totalRecaudado + valorPagar;

            Console.WriteLine("Valor a pagar: $" + valorPagar);
        }
        Console.WriteLine("---- REPORTE FINAL DEL PARQUEADERO ----");
        Console.WriteLine("Total recaudado: $" + totalRecaudado);
        Console.WriteLine("Cantidad de motos: " + motos);
        Console.WriteLine("Cantidad de automóviles: " + automoviles);
        Console.WriteLine("Cantidad de camiones: " + camiones);
        Console.WriteLine("-----------------------------------");
    }
}