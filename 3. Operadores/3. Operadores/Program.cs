using System;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operacores númericos
            //Incremento decremento
            int dato1 = 0;
            dato1++;//dato1 = dato1 + 1; Incremento
            dato1--;//dato1 = dato1 - 1; Decremento
            dato1 += 5; //dato1 = dato1 + 5; Incremento en 5 
            dato1 *= 3; //dato1 = dato1 * 3; Incremento en 3 veces
            dato1 /= 2; //dato1 = dato1 / 2; Decremento en 2 veces
            dato1 += dato1;

            //Orden evaluacion de operadores númericos
            float dato2 = 4 / 3 * 2;
            float dato3 = 4 / (2 * 3);
            float dato4 = 4 + 6 * 2;
            float dato5 = 4 + 6 * (2 + 1);
            float dato6 = dato2 * dato3 - dato4 / dato5;

            //Datos Logicos 
            //Conjuncion - AND - Y - &&
            Console.WriteLine("--------- TABLA DE CONJUNCION ---------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("---------------------------------------");

            //Disyuncion - OR - O - ||
            Console.WriteLine("--------- TABLA DE DISYUNCION ---------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("---------------------------------------");

            //Negacion - NOT - NO - !
            Console.WriteLine("--------- TABLA DE NEGACION ---------");
            Console.WriteLine("!V = " + (!true));
            Console.WriteLine("!F = " + (!false));
            Console.WriteLine("---------------------------------------");

            //Operadores de Comparación
            Console.WriteLine("--------- TABLA DE COMPARACIÓN ---------");
            Console.WriteLine("5 == 5: " + (5 == 5));
            Console.WriteLine("5 != 5: " + (5 != 5));
            Console.WriteLine("5 < 10: " + (5 < 10));
            Console.WriteLine("5 > 10: " + (5 > 10));
            Console.WriteLine("5 <= 10: " + (5 <= 10));
            Console.WriteLine("5 >= 10: " + (5 >= 10));
            Console.WriteLine("---------------------------------------");

            
        }
    }
}
