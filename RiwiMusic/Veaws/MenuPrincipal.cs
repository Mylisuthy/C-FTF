namespace RiwiMusic.Veaws;

public class FirstuMenu
{
    public static readonly string[] options =
    {
        "Concert Managments",
        "Client Managments",
        "Tikets Managments",
        "Especific Information"
    };

    public static void Start()
    {
        int selec = 0;
        ConsoleKey key;

        do
        {
            RenderMenu(selec);
            key = Console.ReadKey(true).Key;

            // Navegación con flechas
            selec = HandleInput(key, selec);

            // Selección con X
            if (key == ConsoleKey.X)
            {
                bool exitApp = ExecuteOption(selec);
                if (exitApp) return;
            }
            // Salir con Z
            else if (key == ConsoleKey.Z)
            {
                if (ConfirmExit()) return;
            }

        } while (true);
    }

    private static int HandleInput(ConsoleKey key, int selec)
    {
        if (key == ConsoleKey.UpArrow)
            selec = (selec == 0) ? options.Length - 1 : selec - 1;
        else if (key == ConsoleKey.DownArrow)
            selec = (selec == options.Length - 1) ? 0 : selec + 1;

        return selec;
    }

    private static bool ExecuteOption(int selec)
    {
        switch (selec + 1)
        {
            case 1:
                ConcertView.Menu();
                break;
            case 2:
                CustomerView.Menu();
                break;
            case 3:
                TiketView.Menu();
                break;
            case 4:
                Console.WriteLine("\n→ Consultas LINQ (Próximamente)");
                Console.ReadKey();
                break;
        }
        return false;
    }

    private static void RenderMenu(int selec)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========= RIWI MUSIC =========\n");
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < options.Length; i++)
        {
            if (i == selec)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"> {options[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {options[i]}");
            }
        }

        Console.WriteLine("\n↑ ↓ para navegar | X para seleccionar | Z para salir");
    }

    private static bool ConfirmExit()
    {
        Console.Clear();
        Console.WriteLine("¿Deseas salir del programa? (Y/N)");
        return Console.ReadKey(true).Key == ConsoleKey.Y;
    }
}