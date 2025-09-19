using RiwiMusic.Controllers;
using RiwiMusic.Services;
namespace RiwiMusic.Veaws;
public static class CustomerView
{
    public static void Menu()
    {
        int selec = 0;
        ConsoleKey key;

        do
        {
            RenderMenu(selec);
            key = Console.ReadKey(true).Key;

            // Navegación con ↑ ↓
            if (key == ConsoleKey.UpArrow)
                selec = (selec == 0) ? DataStore.customers.Count - 1 : selec - 1;
            else if (key == ConsoleKey.DownArrow)
                selec = (selec == DataStore.customers.Count - 1) ? 0 : selec + 1;

            // Acciones CRUD
            switch (key)
            {
                case ConsoleKey.X: // Avanzar
                    selec = (selec + 1) % DataStore.customers.Count;
                    break;

                case ConsoleKey.Z: // Retroceder
                    return;

                case ConsoleKey.C: // Crear
                    CustomerController.CreateCustomer();
                    break;

                case ConsoleKey.V: // Editar
                    CustomerController.EditCustomer(selec);
                    break;

                case ConsoleKey.M: // Eliminar
                    CustomerController.DeleteCustomer(selec);
                    break;

                case ConsoleKey.B: // Buscar
                    CustomerController.FilterCustomer();
                    break;
            }

        } while (true);
    }

    private static void RenderMenu(int selec)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=== Gestión de Clientes ===\n");
        Console.ForegroundColor = ConsoleColor.White;

        var customerList = DataStore.customers.Values.ToList();

        for (int i = 0; i < customerList.Count; i++)
        {
            var c = customerList[i];
            if (i == selec)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"> {c.Id} - {c.Name} | Email: {c.Email} | Edad: {c.Age} | Tiquetes: {c.TiketsOugneed}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {c.Id} - {c.Name} | Email: {c.Email} | Edad: {c.Age} | Tiquetes: {c.TiketsOugneed}");
            }
        }

        Console.WriteLine("\n↑ ↓ Navegar | X Siguiente | Z Volver | C Crear | V Editar | M Eliminar | B Buscar");
    }
}
