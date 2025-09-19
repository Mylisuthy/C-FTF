using RiwiMusic.Models;
using RiwiMusic.Services;
namespace RiwiMusic.Controllers;

public static class CustomerController
{
    // Crear cliente
    public static void CreateCustomer()
    {
        Console.Clear();
        Console.WriteLine("=== Registrar nuevo cliente ===\n");

        Console.Write("ID (número): ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("❌ ID inválido.");
            Console.ReadKey();
            return;
        }

        if (DataStore.customers.ContainsKey(id))
        {
            Console.WriteLine("❌ Ya existe un cliente con este ID.");
            Console.ReadKey();
            return;
        }

        Console.Write("Nombre: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Edad: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de tiquetes comprados: ");
        string tikets = Console.ReadLine();

        DataStore.customers.Add(id, new Customer
        {
            Id = id,
            Name = name,
            Email = email,
            Age = age,
            TiketsOugneed = tikets
        });

        Console.WriteLine("\n✅ Cliente registrado exitosamente.");
        Console.ReadKey();
    }

    // Editar cliente
    public static void EditCustomer(int index)
    {
        var customer = DataStore.customers.Values.ElementAt(index);

        Console.Clear();
        Console.WriteLine($"=== Editar cliente: {customer.Name} ===\n");

        Console.Write("Nuevo nombre (Enter para mantener): ");
        string newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName)) customer.Name = newName;

        Console.Write("Nuevo email (Enter para mantener): ");
        string newEmail = Console.ReadLine();
        if (!string.IsNullOrEmpty(newEmail)) customer.Email = newEmail;

        Console.Write("Nueva edad (Enter para mantener): ");
        string newAge = Console.ReadLine();
        if (int.TryParse(newAge, out int age)) customer.Age = age;

        Console.Write("Nueva cantidad de tiquetes (Enter para mantener): ");
        string newTikets = Console.ReadLine();
        if (!string.IsNullOrEmpty(newTikets)) customer.TiketsOugneed = newTikets;

        Console.WriteLine("\n✅ Cliente actualizado.");
        Console.ReadKey();
    }

    // Eliminar cliente
    public static void DeleteCustomer(int index)
    {
        var customer = DataStore.customers.ElementAt(index);

        Console.WriteLine($"\n¿Seguro que quieres eliminar a '{customer.Value.Name}'? (Y/N)");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            DataStore.customers.Remove(customer.Key);
            Console.WriteLine("\n✅ Cliente eliminado.");
        }
        else
        {
            Console.WriteLine("\n❌ Operación cancelada.");
        }
        Console.ReadKey();
    }

    // Buscar cliente por ID
    public static void FilterCustomer()
    {
        Console.Clear();
        Console.WriteLine("=== Buscar Cliente ===");
        Console.Write("Ingresa el ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("❌ ID inválido.");
            Console.ReadKey();
            return;
        }

        if (DataStore.customers.TryGetValue(id, out Customer customer))
        {
            Console.WriteLine($"\nID: {customer.Id}");
            Console.WriteLine($"Nombre: {customer.Name}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"Edad: {customer.Age}");
            Console.WriteLine($"Tiquetes: {customer.TiketsOugneed}");
        }
        else
        {
            Console.WriteLine("\n❌ No se encontró un cliente con ese ID.");
        }

        Console.ReadKey();
    }
}