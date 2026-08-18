using System;
    internal class Program
    {
        static void Main(string[] args)
        {
           //Condicionales Múltiples
        int respuesta = 0;
        Console.WriteLine("-----MENÚ-----");
        Console.WriteLine("1. Opción 1");
        Console.WriteLine("2. Opción 2");
        Console.WriteLine("3. Opción 3");
        Console.WriteLine("4. Opción 4");
        Console.WriteLine("5. Opción 5");
        Console.WriteLine("-----------");
        Console.Write("Seleccione una opción: ");
        respuesta = int.Parse(Console.ReadLine());

        switch (respuesta)
        {
            case 1:
                Console.WriteLine("Usted seleccionó la opción 1");
                break;
            case 2:
                Console.WriteLine("Usted seleccionó la opción 2");
                break;
            case 3:
                Console.WriteLine("Usted seleccionó la opción 3");
                break;
            case 4:
                Console.WriteLine("Usted seleccionó la opción 4");
                break;
            case 5:
                Console.WriteLine("Usted seleccionó la opción 5");
                break;
            default:
                Console.WriteLine("Elija una opción válida");
                break;
        }
    }
}