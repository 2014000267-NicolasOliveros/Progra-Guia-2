using System;

class Program
{
    static void Main()
    {
        int opcion;
        double valor;

        Console.WriteLine("===== CONVERSOR DE LONGITUD =====");
        Console.WriteLine("1. Metros");
        Console.WriteLine("2. Pies");
        Console.WriteLine("3. Centímetros");
        Console.WriteLine("4. Pulgadas");

        Console.Write("Seleccione una opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor: ");
        valor = Convert.ToDouble(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("En pies: " + (valor * 3.28084));
                Console.WriteLine("En centímetros: " + (valor * 100));
                Console.WriteLine("En pulgadas: " + (valor * 39.3701));
                break;

            case 2:
                Console.WriteLine("En metros: " + (valor * 0.3048));
                Console.WriteLine("En centímetros: " + (valor * 30.48));
                Console.WriteLine("En pulgadas: " + (valor * 12));
                break;

            case 3:
                Console.WriteLine("En metros: " + (valor * 0.01));
                Console.WriteLine("En pies: " + (valor * 0.0328084));
                Console.WriteLine("En pulgadas: " + (valor * 0.393701));
                break;

            case 4:
                Console.WriteLine("En metros: " + (valor * 0.0254));
                Console.WriteLine("En pies: " + (valor * 0.0833333));
                Console.WriteLine("En centímetros: " + (valor * 2.54));
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}