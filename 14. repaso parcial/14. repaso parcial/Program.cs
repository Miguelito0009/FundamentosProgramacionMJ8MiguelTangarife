using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.repaso_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* float cal;

             int cont = 0;

             float acum=0;

             int res;

             float prom;


             do

             {

                 cont++;

                 Console.WriteLine("Ingrese su nota");

                 cal = float.Parse(Console.ReadLine());

                 Console.WriteLine("Si desea agregar otra nota presione 1, de lo contrario presione 2");

                 res = int.Parse(Console.ReadLine());

                 acum += cal;


             }

             while (res == 1);

             prom = acum / cont;

             Console.WriteLine($"El promedio de sus notas es:{prom}");
             */


            int numero, contador;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            contador = numero;

            while (contador >= 1)
            {
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }

                contador--;
            }
        } 
    }
}
