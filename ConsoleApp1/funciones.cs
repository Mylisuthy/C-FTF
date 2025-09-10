using System.Collections;

namespace shihiro;

public class funciones
{
    /*
     * una funcion contiene la logica de negocio de tu aplicacion es decir aqui va lo que tu estancias para
     * el funcionamiento de la aplicacion.
     *
     * ¿que es un metodo?: es un bloque de codigo que cumple una funcionalidad que se puede inbocar desde cualquier
     * parte del codigo.
     */

    public static void Increment()
    {
        int[] numbers = new int[50];
        for (int numero = 0; numero <= numbers.Length; numero += 3)
        {
            int numeros = numero++;
            if (numeros % 3 == 0){ Console.WriteLine($"numero in par: {numeros}");}
            else if (numeros % 1 == 0) { Console.WriteLine($"numero par: {numeros}");}
            
        }
    }
    
    public static void juguete()
    {
        string[] juguetes = new string[10];
        for (int i = 0; i < juguetes.Length; i++)
        {
            Console.Write($"Ingrese el juguete {i + 1}: ");
            juguetes[i] = Console.ReadLine();
        }
    }

    public static void ciclos()
    {
        //recorrer notas
        int[] notas = { 10, 20, 30, 40, 50 };
        
        for (int i = 0; i< notas.Length; i++)
        {
            Console.WriteLine($"las notas son: {notas[i]}");
        }
    }

    public static void miArrayList()
    {
        ArrayList name = new ArrayList();
        name.Add(1000);
        name.Add("holamama");
        name.Add(2.3);
        name.Add(true);
        
        foreach (var nombre in name)
        {
            Console.WriteLine(nombre);
        }    
    }

    public static void Edades()
    {
        List<int> edades = new List<int> { 10, 20, 30, 40, 50 };
        
        edades.Add(60);
        
        foreach (int edad in edades)
        {
            Console.WriteLine(edad);
        }

    }
    
    public static void eList()
    {
        List<string> carnes = new List<string> { "lomo", "pechuga", "pescado" };
        
        carnes.Add("solomo");
        
        carnes.Remove("lomo");
        
        foreach (string carne in carnes)
        {
            Console.WriteLine(carne);
        }
        
        //Console.WriteLine(carne);
    }

    public static void first()
    {
        int suma = sumar(5,5);
        Console.WriteLine($"la suma de esos numeros es {suma}");
        
    }
    
    public static void second()
    {
        Console.WriteLine("que numeros vas a restar");
        Console.WriteLine("principal");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("resta");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        
        int resultado =  numero1 - numero2;
        Console.WriteLine(resultado);
    }
    
    
    // metodos
    /*
    public static double dividir(double numero, double divisor)
    {
        
    }*/

    public static int sumar(int a, int b)
    {
        
        return a + b;
    }
    
    public static int restar(int a, int b)
    {
        
        return a - b;
    }

    public static double multiplicar(double a, double b)
    {
        return a * b;
    }
    
}