using System;

class Program
{
    static void Main()
    {
        double opc, a, res, rad;

        Console.WriteLine("**************************");
        Console.WriteLine("***  MENÚ DE OPCIONES  ***");
        Console.WriteLine("**************************");
        Console.WriteLine("1 - Seno");
        Console.WriteLine("2 - Coseno");
        Console.WriteLine("3 - Tangente");

        Console.Write("Seleccione una opción: ");
        opc = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite su ángulo en grados: ");
        a = Convert.ToDouble(Console.ReadLine());

        rad = a * Math.PI / 180;

        switch ((int)opc)
        {
            case 1:
                res = Math.Sin(rad);
                Console.WriteLine("Seno: " + res);
                break;

            case 2:
                res = Math.Cos(rad);
                Console.WriteLine("Coseno: " + res);
                break;

            case 3:
                res = Math.Tan(rad);
                Console.WriteLine("Tangente: " + res);
                break;

            default:
                Console.WriteLine("Error al operar");
                break;
        }
    }
}