using System;

class Program
{
    static void Main()
    {
        int sector, cantidad;
        double precio = 0, total;

        Console.WriteLine("===== SECTORES DEL ESTADIO =====");
        Console.WriteLine("1. Palco (Q300.00)");
        Console.WriteLine("2. Tribuna (Q100.00 - Q125.00)");
        Console.WriteLine("3. Preferencia (Q50.00 - Q75.00)");
        Console.WriteLine("4. Generales (Q30.00 - Q50.00)");

        Console.Write("Seleccione un sector: ");
        sector = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese cantidad de entradas: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        switch (sector)
        {
            case 1:
                precio = 300;
                break;

            case 2:
                precio = 112.5;
                break;

            case 3:
                precio = 62.5;
                break;

            case 4:
                precio = 40;
                break;

            default:
                Console.WriteLine("Sector inválido");
                precio = 0;
                break;
        }

        total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}