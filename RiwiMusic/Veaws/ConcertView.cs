using RiwiMusic.Services;
using RiwiMusic.Controllers;
namespace RiwiMusic.Veaws;

public class ConcertView
{
    public static void Menu()
    {
        int selec = 0;
        ConsoleKey key;

        do
        {
            RenderMenu(selec);

            key = Console.ReadKey(true).Key;

            // Navegar ↑ ↓
            if (key == ConsoleKey.UpArrow)
                selec = (selec == 0) ? DataStore.concerts.Count - 1 : selec - 1;
            else if (key == ConsoleKey.DownArrow)
                selec = (selec == DataStore.concerts.Count - 1) ? 0 : selec + 1;

            // Acciones CRUD
            switch (key)
            {
                case ConsoleKey.X: // Avanzar
                    selec = (selec + 1) % DataStore.concerts.Count;
                    break;

                case ConsoleKey.Z: // Retroceder
                    return;

                case ConsoleKey.C: // Crear
                    ConcertCont.CreateConcert();
                    break;

                case ConsoleKey.V: // Editar
                    ConcertCont.EditConcert(selec);
                    break;

                case ConsoleKey.M: // Eliminar
                    ConcertCont.DeleteConcert(selec);
                    break;

                case ConsoleKey.B: // Buscar
                    ConcertCont.FilterConcert();
                    break;
            }

        } while (true);
    }

    private static void RenderMenu(int selec)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=== Gestión de Conciertos ===\n");
        Console.ForegroundColor = ConsoleColor.White;

        var concertsList = DataStore.concerts.Values.ToList();

        for (int i = 0; i < concertsList.Count; i++)
        {
            var c = concertsList[i];

            if (i == selec)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($@"> {c.Id} - {c.Name}
    More Inf
    ────────────────
    Site: {c.Location}
    Capacity: {c.Capacity}
    Date: {c.date}");

                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {c.Id} - {c.Name}");
            }
        }

        Console.WriteLine("\n↑ ↓ para navegar | X siguiente | Z volver | C crear | V editar | M eliminar | B buscar");
    }
}