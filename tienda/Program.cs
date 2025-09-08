namespace tienda;

public class pedidos;
{
    static void Main(string[] args)
    {
        Console.WriteLine("bienvenido a la tienda.");

        Console.WriteLine("como te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine("cuantas manzanas quiere?");
        int manzanas = int.Parse(Console.ReadLine());

        Console.WriteLine("cuanto cuesta cada manzana?");
        double precioManzana = double.Parse(Console.ReadLine());

        double totalManzana = manzanas * precioManzana;

        Console.WriteLine("quieres bolsa plastica true/false");
        bool quiereBolsa = bool.Parse(Console.ReadLine());

        double precioBolsa = 100;
        double total = totalManzana;

        if (quiereBolsa)
        {
            total += precioBolsa;
        }
        
    }
}