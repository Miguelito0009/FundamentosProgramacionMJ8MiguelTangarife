using System;
using System.Runtime.CompilerServices;

namespace _2.Constante__Tiposdedatosoperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const String iva = "19%";
            string nombre = "Miguelito";
            nombre = "Tangarife";

            //iva = "20%"; a una constante no se le puede cambiar el valor

            //Tipos de datos
            //Numericos
            byte dato1 = 225;
            int dato2 = -12365;
            long dato3 = 123456789;

            //Decimales
            float dato4 = 5.3f;
            double dato5 = 12.35;
            decimal dato6 = 16848446841.854894848m;

            //No numericos
            char dato7 = '?';//un solo caracter
            string dato8 = "Mirame el estress";//varios caracteres
            bool dato9 = false;//true o false
            object dato10 = new object();

            //OPERADORES

            //Operadores numericos

            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}", dato11, dato12);

            //Operadores arimeticos 
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es:{0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("La resta es:{0}", dato14);

            // float dato16 =(float) 5 / 3;
            float dato16 = 5f / 3f;
            Console.WriteLine("La division es:{0}", dato16);

        }
    }
}
