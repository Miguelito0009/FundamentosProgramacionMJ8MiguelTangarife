using System;
using System.Diagnostics.Eventing.Reader;

namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de control Condicional

            /*  //Simple
              //1. Crea un algoritmo que lea la edad del usuario, si el usuario es mayor de 18, se debe mostrar "Bienvenido a mi sitio web"
              byte edad = 0;
              Console.WriteLine("Ingrese su edad: ");
              edad = Convert.ToByte(Console.ReadLine());
              if (edad >= 18)
              {
                  //Si la condición es verdadera, se ejecuta este bloque de código
                  Console.WriteLine("Bienvenido a mi sitio web");
              }
              }*/

            //Ingresar nombre y sueldo, si supera los 3000 mostrar el nombre de la persona en pantalla, indicando que debe abonar impuestos

            /*   string nombre = ("Ingrese su nombre");
               Console.WriteLine("Ingrese su nombre: ");
               nombre = Console.ReadLine();
               float sueldo = 0;
               Console.WriteLine("Ingrese su sueldo: ");
               sueldo = Convert.ToSingle(Console.ReadLine());

               if (sueldo > 3000)
               {
                   Console.WriteLine("El empleado {0} debe pagar impuestos.", nombre);
                   Console.WriteLine("El total de impuestos a pagar es: {0}", sueldo * 0.19);

               }*/


            //Condicional doble
            // Crea un algoritmo que lea la edad del usuario, si el usuario es mayor de 18, se debe mostrar "Bienvenido a mi sitio web", de lo contrario, mostrar no es apto para el sitio web
            byte edad = 0;
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //Si la condición es verdadera, se ejecuta este bloque de código
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No tienes la edad suficiente para acceder a mi sitio web");
            }
        }
    }
}
