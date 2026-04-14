using System;

class Program
{
    static void Main()
    {
        int cantidad, opcion;
        double precioBase = 650;
        double iva = 0.12;
        double precioConIVA, totalSinDescuento, descuento = 0, totalPagar;
        string formaPago = "";

        Console.Write("Cantidad de impresoras: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Forma de pago:");
        Console.WriteLine("1. Efectivo (10%)");
        Console.WriteLine("2. Tarjeta de crédito (5%)");
        Console.WriteLine("3. Vale de regalo (15%)");

        Console.Write("Seleccione una opción: ");
        opcion = Convert.ToInt32(Console.ReadLine());

        precioConIVA = precioBase + (precioBase * iva);
        totalSinDescuento = precioConIVA * cantidad;

        switch (opcion)
        {
            case 1:
                formaPago = "Efectivo";
                descuento = totalSinDescuento * 0.10;
                break;

            case 2:
                formaPago = "Tarjeta de crédito";
                descuento = totalSinDescuento * 0.05;
                break;

            case 3:
                formaPago = "Vale de regalo";
                descuento = totalSinDescuento * 0.15;
                break;

            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        totalPagar = totalSinDescuento - descuento;

        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioConIVA);
        Console.WriteLine("Total sin descuento: Q" + totalSinDescuento);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + totalPagar);
    }
}