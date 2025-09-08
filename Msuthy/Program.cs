namespace person;

public class info
{
    static void Main(string[] args)
    {
        // datos numericos
        byte age = 25;
        short numeroPequeño = 300;
        int numero = 1000;
        long grande = 1000000000000000;

        double flotanteGrande = 12345.78;
        float flotante = 12.12;

        // datos de texto
        string palabra = "Mylisuthy";
        char caracter = 'a';

        //datos booleanos
        bool isActive = true or false;
        bool active = true;
        bool inactive = false;

        DateTime fecha = DateTime.Now;
        TimeSpan des = fecha.Subtract(DateTime.Now);

        // GUid identificador unico
        Guid idunico = Guid.NewGuid();
    }
};

public class tags
{   
    static void Main(string[] args)
    {
        char letra = 'A';
        char simbolo = '@';
        char nomero = '7';

        string named = "Msuthy";
        string saludo = "Hola" + named;

        Console.WreiteLine(saludo)

        Console.WreiteLine("letra"+letra);
        Console.WreiteLine("simbolo"+simbolo);
        Console.WreiteLine("numero"+nomero);
    }
};

public class eartDistance
{
    static void Main(string[] args)
    {
        long DistanciaSol = 149597870700;
        Console.WreiteLine("la distancia al sol es: " + DistanciaSol);
    }
};

public class ciudades
{
    static void Main()
    {
        string nombre = "Msuthy";
        string ciudad = "medallo";

        Console.WriteLine($"hola {nombre}, bienvenido a {ciudad}");
    }
}

