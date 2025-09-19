using RiwiMusic.Controllers;
using RiwiMusic.Services;
namespace RiwiMusic.Veaws;

public static class TiketView
{
    public static void Menu()
    {
        int selec = 0;
        ConsoleKey key;

        do
        {
            RenderMenu(selec);
            key = Console.ReadKey(true).Key;

            // Navegación ↑ ↓
            if (key == ConsoleKey.UpArrow)
                selec = (selec == 0) ? DataStore.tikets.Count - 1 : selec - 1;
            else if (key == ConsoleKey.DownArrow)
                selec = (selec == DataStore.tikets.Count - 1) ? 0 : selec + 1;

            // Acciones CRUD
            switch (key)
            {
                case ConsoleKey.X: // Avanzar
                    selec = (selec + 1) % DataStore.tikets.Count;
                    break;

                case ConsoleKey.Z: // Retroceder
                    return;

                case ConsoleKey.C: // Crear
                    TiketController.CreateTiket();
                    break;

                case ConsoleKey.V: // Editar
                    TiketController.EditTiket(selec);
                    break;

                case ConsoleKey.M: // Eliminar
                    TiketController.DeleteTiket(selec);
                    break;

                case ConsoleKey.B: // Buscar
                    TiketController.FilterTiket();
                    break;
            }

        } while (true);
    }

    private static void RenderMenu(int selec)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("=== Gestión de Tiquetes ===\n");
        Console.ForegroundColor = ConsoleColor.White;

        var tiketList = DataStore.tikets.Values.ToList();

        if (tiketList.Count == 0)
        {
            Console.WriteLine("No hay tiquetes registrados.");
        }
        else
        {
            for (int i = 0; i < tiketList.Count; i++)
            {
                var t = tiketList[i];
                if (i == selec)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"> ID: {t.IdTiket} | Cliente: {t.CustomerName} | Concierto: {t.ConcertName} | Info: {t.InfTiket}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  ID: {t.IdTiket} | Cliente: {t.CustomerName} | Concierto: {t.ConcertName} | Info: {t.InfTiket}");
                }
            }
        }

        Console.WriteLine("\n↑ ↓ Navegar | X Siguiente | Z Volver | C Crear | V Editar | M Eliminar | B Buscar");
    }
}
