using RiwiMusic.Models;
using RiwiMusic.Services;
namespace RiwiMusic.Controllers;


public class ConcertCont

{
    // Crear concierto
    public static void CreateConcert()
    {
        Console.Clear();
        Console.WriteLine("=== Registrar nuevo concierto ===\n");

        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());

        if (DataStore.concerts.ContainsKey(id))
        {
            Console.WriteLine("Ya existe un concierto con este ID.");
            Console.ReadKey();
            return;
        }

        Console.Write("Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Capacidad: ");
        int capacity = int.Parse(Console.ReadLine());

        Console.Write("Ubicación: ");
        string location = Console.ReadLine();

        Console.Write("Fecha (YYYY-MM-DD): ");
        string date = Console.ReadLine();

        DataStore.concerts.Add(id, new Concert
        {
            Id = id,
            Name = name,
            Capacity = capacity,
            Location = location,
            ventas = 0,
            date = date
        });

        Console.WriteLine("\nConcierto registrado exitosamente.");
        Console.ReadKey();
    }

    // Editar concierto
    public static void EditConcert(int index)
    {
        var concert = DataStore.concerts.Values.ElementAt(index);

        Console.Clear();
        Console.WriteLine($"=== Editar concierto: {concert.Name} ===\n");

        Console.Write("Nuevo nombre (enter para mantener): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)) concert.Name = newName;

        Console.Write("Nueva capacidad (enter para mantener): ");
        string newCap = Console.ReadLine();
        if (int.TryParse(newCap, out int cap)) concert.Capacity = cap;

        Console.Write("Nueva ubicación (enter para mantener): ");
        string newLoc = Console.ReadLine();
        if (!string.IsNullOrEmpty(newLoc)) concert.Location = newLoc;

        Console.Write("Nueva fecha (enter para mantener): ");
        string newDate = Console.ReadLine();
        if (!string.IsNullOrEmpty(newDate)) concert.date = newDate;

        Console.WriteLine("\nConcierto actualizado.");
        Console.ReadKey();
    }

    // Eliminar concierto
    public static void DeleteConcert(int index)
    {
        var concert = DataStore.concerts.ElementAt(index);

        Console.WriteLine($"\n¿Seguro que quieres eliminar '{concert.Value.Name}'? (Y/N)");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            DataStore.concerts.Remove(concert.Key);
            Console.WriteLine("\nConcierto eliminado.");
        }
        else
        {
            Console.WriteLine("\nOperación cancelada.");
        }
        Console.ReadKey();
    }

    // Filtrar por ID
    public static void FilterConcert()
    {
        Console.Clear();
        Console.WriteLine("=== Buscar Concierto ===");
        Console.Write("Ingresa el ID: ");
        int id = int.Parse(Console.ReadLine());

        if (DataStore.concerts.TryGetValue(id, out Concert concert))
        {
            Console.WriteLine($"\nID: {concert.Id}");
            Console.WriteLine($"Nombre: {concert.Name}");
            Console.WriteLine($"Ubicación: {concert.Location}");
            Console.WriteLine($"Fecha: {concert.date}");
            Console.WriteLine($"Capacidad: {concert.Capacity}");
            Console.WriteLine($"Ventas: {concert.ventas}");
        }
        else
        {
            Console.WriteLine("\nNo se encontró un concierto con ese ID.");
        }

        Console.ReadKey();
    }
}