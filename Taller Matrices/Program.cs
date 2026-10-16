using System;
namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto 1
            int[,] matriz1 = new int[10, 20];
            // La lleno de unos porque no decia con que llenarla
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz1[i, j] = 1;
                }
            }

            // Sumar las columnas
            for (int j = 0; j < 20; j++)
            { // recorro primero la columna creo
                int suma = 0;
                for (int i = 0; i < 10; i++)
                {
                    suma = suma + matriz1[i, j];
                }
                Console.WriteLine("La suma de la columna " + j + " es " + suma);
                Console.Write("Filas: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Columnas: ");
                int m = int.Parse(Console.ReadLine());
                char[,] matrizChars = new char[n, m];

                // Llenando la matriz original
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Ingrese un caracter: ");
                        matrizChars[i, j] = char.Parse(Console.ReadLine()); 
                    }
                }

                // intercambio
                for (int j = 0; j < m; j++)
                {
                    char temp = matrizChars[0, j];
                    matrizChars[0, j] = matrizChars[n - 1, j]; 
                    matrizChars[n - 1, j] = temp;
                }
                int[,] matriz3 = new int[5, 5];
                int[] frecuencias = new int[11];
                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matriz3[i, j] = rnd.Next(1, 11);
                        int numeroGenerado = matriz3[i, j];
                        frecuencias[numeroGenerado]++;
                    }
                }

                Console.WriteLine("Matriz de 5x5:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(matriz3[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nFrecuencias:");
                for (int k = 1; k <= 10; k++)
                {
                    Console.WriteLine("El número " + k + " salió " + frecuencias[k] + " veces.");
                }
                string[,] tablero = new string[5, 5];
                Random rnd2 = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        tablero[i, j] = "-";
                    }
                }

                for (int k = 0; k < 3; k++)
                {
                    int filaX = rnd2.Next(0, 5);
                    int colX = rnd2.Next(0, 5);
                    tablero[filaX, colX] = "X";
                }

                bool acerto = false;

                for (int intento = 1; intento <= 3; intento++)
                {
                    Console.WriteLine("\nIntento " + intento + " de 3");
                    Console.Write("Adivina la fila (0 al 4): ");
                    int f = int.Parse(Console.ReadLine());
                    Console.Write("Adivina la columna (0 al 4): ");
                    int c = int.Parse(Console.ReadLine());

                    if (tablero[f, c] == "X")
                    {
                        Console.WriteLine("¡Éxito! Encontraste una X en la posición: " + f + ", " + c);
                        acerto = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Fallaste.");
                    }
                }

                if (acerto == false)
                {
                    Console.WriteLine("\n Error, te quedaste sin intentos. asi era el tablero:");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write(tablero[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.Write("Ingrese filas: ");
                    int filas = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese columnas: ");
                    int col = int.Parse(Console.ReadLine());

                    int[,] matriz5 = new int[filas, col];
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write("Dato: ");
                            matriz5[i, j] = int.Parse(Console.ReadLine());
                        }
                    }

                    // invierto filas y columnas
                    int[,] matrizNueva = new int[col, filas];
                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            matrizNueva[j, i] = matriz5[i, j]; 
                            // le doy la vuelta a los indices
                        }
                    }

                    // imprimir la nueva
                    Console.WriteLine("Nueva matriz:");
                    for (int i = 0; i < col; i++)
                    {
                        for (int j = 0; j < filas; j++)
                        {
                            Console.Write(matrizNueva[i, j] + " ");
                        }
                        Console.WriteLine(); // salto de linea
                    }
                }

            }
        }
    }
}