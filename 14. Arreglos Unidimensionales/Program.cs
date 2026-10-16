using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]; 
            numeros[0] = 4; 
            numeros[1] = 8; 
            numeros[2] = 19; 
            numeros[3] = 55; 
            numeros[4] = 60; Console.WriteLine("el dato almacenado en la posicion 4 con indice 3 es: " + numeros[3]); float[] notas = new float[5]; notas[0] = 2.9f; notas[1] = 6.7f; notas[2] = 4.4f; notas[3] = 3.2f; notas[4] = 4.3f; char[] simbolos = new char[] { '▓', '♫', 'ᾣ' }; string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("ingrese el nombre para la posición " + (i + 1) + " de indice " + i);
                nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < nombres.Length; i++)
            {
            }
            {
                int[] numeros2 = new int[10];
                numeros[0] = 4;
            }
        }
    }
}