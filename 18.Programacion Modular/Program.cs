using System;
namespace _18programacionmodular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Miguel");
            MostrarMensaje("Miguel", "Tangarife Arroyave");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Procedmientos SIN parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos CON parámetros
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");
        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de Fundamentos de Programación");
        }
    }
}