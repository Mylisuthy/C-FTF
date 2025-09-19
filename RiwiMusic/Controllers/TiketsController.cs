using RiwiMusic.Models;
using RiwiMusic.Services;
namespace RiwiMusic.Controllers;
    
public static class TiketController
{
    // Crear un nuevo tiquete
    public static void CreateTiket()
    {
        Console.Clear();
        Console.WriteLine("=== Registrar nueva compra de tiquete ===\n");

        Console.Write("ID del tiquete: ");
        if (!int.TryParse(Console.ReadLine(), out int IdTiket))
        {
            Console.WriteLine("ID inválido.");
            Console.ReadKey();
            return;
        }

        if (DataStore.tikets.ContainsKey(IdTiket))
        {
            Console.WriteLine("Ya existe un tiquete con ese ID.");
            Console.ReadKey();
            return;
        }

        // Selección de cliente
        Console.WriteLine("\n--- Clientes disponibles ---");
        foreach (var c in DataStore.customers.Values)
            Console.WriteLine($"{c.Id} - {c.Name}");
        Console.Write("ID del cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int IdCustomer) || !DataStore.customers.ContainsKey(IdCustomer))
        {
            Console.WriteLine("Cliente no encontrado.");
            Console.ReadKey();
            return;
        }

        // Selección de concierto
        Console.WriteLine("\n--- Conciertos disponibles ---");
        foreach (var c in DataStore.concerts.Values)
            Console.WriteLine($"{c.Id} - {c.Name} ({c.Location})");
        Console.Write("ID del concierto: ");
        if (!int.TryParse(Console.ReadLine(), out int IdConcert) || !DataStore.concerts.ContainsKey(IdConcert))
        {
            Console.WriteLine("Concierto no encontrado.");
            Console.ReadKey();
            return;
        }

        Console.Write("Información adicional del tiquete: ");
        string info = Console.ReadLine();

        var customer = DataStore.customers[IdCustomer];
        var concert = DataStore.concerts[IdConcert];

        // Guardar tiquete
        DataStore.tikets.Add(IdTiket, new Tiket
        {
            IdTiket = IdTiket,
            IdCustomer = IdCustomer,
            CustomerName = customer.Name,
            IdConcert = IdConcert,
            ConcertName = concert.Name,
            InfTiket = info
        });

        // Incrementar ventas del concierto
        concert.ventas++;

        Console.WriteLine("\n✅ Compra registrada exitosamente.");
        Console.ReadKey();
    }

    // Editar tiquete
    public static void EditTiket(int index)
    {
        if (DataStore.tikets.Count == 0)
        {
            Console.WriteLine("No hay tiquetes para editar.");
            Console.ReadKey();
            return;
        }

        var tiket = DataStore.tikets.Values.ElementAt(index);

        Console.Clear();
        Console.WriteLine($"=== Editar Tiquete: {tiket.IdTiket} ===\n");

        Console.Write("Nueva información adicional (Enter para mantener): ");
        string newInfo = Console.ReadLine();
        if (!string.IsNullOrEmpty(newInfo)) tiket.InfTiket = newInfo;

        Console.WriteLine("\nTiquete actualizado.");
        Console.ReadKey();
    }

    // Eliminar tiquete
    public static void DeleteTiket(int index)
    {
        if (DataStore.tikets.Count == 0)
        {
            Console.WriteLine("No hay tiquetes para eliminar.");
            Console.ReadKey();
            return;
        }

        var tiket = DataStore.tikets.ElementAt(index);

        Console.WriteLine($"\n¿Seguro que deseas eliminar el tiquete ID {tiket.Value.IdTiket}? (Y/N)");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            // Decrementar ventas del concierto
            if (DataStore.concerts.ContainsKey(tiket.Value.IdConcert))
            {
                DataStore.concerts[tiket.Value.IdConcert].ventas--;
            }

            DataStore.tikets.Remove(tiket.Key);
            Console.WriteLine("Tiquete eliminado.");
        }
        else
        {
            Console.WriteLine("Operación cancelada.");
        }

        Console.ReadKey();
    }

    // Buscar tiquete por ID
    public static void FilterTiket()
    {
        Console.Clear();
        Console.WriteLine("=== Buscar Tiquete ===");
        Console.Write("Ingrese el ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID inválido.");
            Console.ReadKey();
            return;
        }

        if (DataStore.tikets.TryGetValue(id, out Tiket tiket))
        {
            Console.WriteLine($"\nID Tiquete: {tiket.IdTiket}");
            Console.WriteLine($"Cliente: {tiket.CustomerName}");
            Console.WriteLine($"Concierto: {tiket.ConcertName}");
            Console.WriteLine($"Info: {tiket.InfTiket}");
        }
        else
        {
            Console.WriteLine("\nNo se encontró un tiquete con ese ID.");
        }

        Console.ReadKey();
    }
}