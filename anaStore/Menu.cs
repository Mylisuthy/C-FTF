namespace anaStore;

public class Menu
{
    // Menu Options
    public static readonly string[] options =
    {
        "View Menu and Select Products",
        "View and Edit Order",
        "Pay my Order",
        "Exit"
    };

    // Output
    public static void Start()
    {
        int selec = 0;
        ConsoleKey key;

        do
        {
            RenderMenu(selec);

            // Lee la tecla presionada
            key = Console.ReadKey(true).Key;

            // Maneja flechas ↑ ↓
            selec = HandleInput(key, selec);

            // Si presiona X → Ejecuta la opción seleccionada
            if (key == ConsoleKey.X)
            {
                bool exitApp = ExecuteOption(selec); 
                if (exitApp) return; // Termina toda la app
            }
            // Si presiona Z → Sale desde menú principal
            else if (key == ConsoleKey.Z)
            {
                if (ConfirmExit()) // Pregunta si quiere salir
                    return;
            }

        } while (true);
    }

    // Arows manager
    public static int HandleInput(ConsoleKey key, int selec)
    {
        if (key == ConsoleKey.UpArrow)
            selec = (selec == 0) ? options.Length - 1 : selec - 1;
        else if (key == ConsoleKey.DownArrow)
            selec = (selec == options.Length - 1) ? 0 : selec + 1;

        return selec;
    }

    // Cases Selection
    public static bool ExecuteOption(int selec)
    {
        switch (selec + 1)
        {
            case 1:
                Purchase.SelectProduct(); 
                break;
            case 2:
                Purchase.ConfirmPurchase();
                break;
            case 3:
                Pay.PayProcess();
                break;
            case 4:
                return ConfirmExit(); // Exit
        }
        return false; // Seguir corriendo
    }

    // Render the menu
    public static void RenderMenu(int selec)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-------------------- Ana's Store Menu -------------------\n");
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < options.Length; i++)
        {
            if (i == selec)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"> {options[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"  {options[i]}");
            }
        }

        Console.WriteLine("\nUse ↑ ↓ to navigate, press X to select.");
    }
    
    public static bool ConfirmExit()
    {
        Console.Clear();
        Console.WriteLine("Are you sure you want to exit? (Y/N)");
        ConsoleKey response = Console.ReadKey(true).Key;

        return response == ConsoleKey.Y;
    }
}
