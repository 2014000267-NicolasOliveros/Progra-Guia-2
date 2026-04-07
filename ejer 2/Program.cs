internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----Calculadora Basica-----");
        string opc;
        int n1;
        int n2;
        double res;
        Console.WriteLine("1 - Suma");
        Console.WriteLine("2 - Resta");
        Console.WriteLine("3 - Multiplicación");
        Console.WriteLine("4 - División");
        Console.WriteLine("Digite la Opción:");
        opc = Console.ReadLine();
        Console.WriteLine("Digite sus 2 valores");
        Console.WriteLine("Valor 1:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Valor 2:");
        n2 = Convert.ToInt32(Console.ReadLine());

        switch(opc)

        {
            case "1":
                res = n1+n2;
                Console.WriteLine("La suma es: "+res);
                break;
            case "2":
                res = n1 - n2;
                Console.WriteLine("La resta es: " + res);
                break;
            case "3":
                res = n1 * n2;
                Console.WriteLine("La multiplicación es: " + res);
                break;
            case "4":
                res = n1 / n2;
                Console.WriteLine("La división es: " + res);
                break;
            default:
                Console.WriteLine("Error al operar");
                break;
        }

    }
}