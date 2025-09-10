
namespace shihiro;

public class sekiro
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("bienvenido al programa, ¿que deseas hacer hoy?");
            Console.WriteLine("1. sumar");
            Console.WriteLine("2. restar");
            Console.WriteLine("0. Salir");
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out int resultado))
            {
                Console.WriteLine("Error, número inválido.");
                continue;
            }
            
            int opcion = Convert.ToInt32(input);

            switch (opcion)
            {
                case 1:
                    funciones.first();
                    continue;
                
                case 2:
                    funciones.second();
                    Console.ReadLine();
                    continue;
                
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    continue;
            }
        }    
        /*
        Console.WriteLine("------------------------");
        funciones.first();
        
        Console.WriteLine("------------------------");
        funciones.eList();
        
        Console.WriteLine("------------------------");
        funciones.Edades();
        
        Console.WriteLine("------------------------");
        funciones.miArrayList();
        
        Console.WriteLine("------------------------");
        funciones.ciclos();
        
        Console.WriteLine("------------------------");
        funciones.juguete();
        
        Console.WriteLine("------------------------");
        funciones.Increment();
        
        Console.WriteLine("----------------------");
        bucles.bucleWhile(); */
    } 
}

/*
Console.WriteLine("welcome to a new storie");
//arrays : for create a list array with five camps free use this sentence
string[] nombres = new string[5];

//define lista
List<string> edades = new List<string>;

// define arraylist
ArrayList edad = new ArrayList;

// you can explored the array with a bucle for

for (int i = 0; i < nombres.Length; i++)
{
    Console.Write($"Ingrese el nombre {i + 1}: ");
    nombres[i] = Console.ReadLine();
}

Console.WriteLine("nombres ingresados: ");

// if you need explored the camps of the array use this sentence
foreach (string nombre in nombres)
{
    Console.WriteLine($"- {nombres}");
}
*/

/*
 * funciones
 *
 * metodos
 *
 * arrays ( entero, string, double )
 *
 * listas <T> es moldeable y adaptable. se le debe enviar el tipo
 *
 * arraylist no lleva tipo pero se le puede hacer lo mismo que las listas.
 *
 * ciclos (for, foriach, do, do while, while)
 *
 * 
 */