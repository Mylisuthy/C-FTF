/*namespace condicion;

public class parInpar
{
    static void Main(string[] args)
    {
        // par o in par
        Console.WriteLine("Dime tu numero");
        int num = Convert.ToInt32(Console.ReadLine());

        string resultado = (num % 2 == 0) ? "es par" : "es in par";
        Console.WriteLine(resultado);

        if (num % 2 == 0)
        {
            Console.WriteLine("El resultado es par");
        }Console.WriteLine("El resultado es in par");
    }
}

public class edad
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime tu edad");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 18)
        {
            Console.WriteLine("Eres nayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
    }
}

public class resultado
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dime tu calificacion");
        int calificacion = int.Parse(Console.ReadLine());
        
        string mensaje;
        
        // usando alternarios
        string resultado = calificacion >= 90 ? "excelente" :
            calificacion >= 70 ? "bueno" :
            calificacion >= 60 ? "recuperar" :
            "reprobado";
        
        // usando condicionales
        if (calificacion >= 90 && calificacion <= 100) {mensaje = "Exelente";}
        else if (calificacion >= 70 && calificacion <= 90) {mensaje = "Bueno";}
        else if (calificacion >= 60 && calificacion <= 70) {mensaje = "Debes recuperar";}
        else if (calificacion < 60) {mensaje = "perdiste";}
        else if (calificacion < 0 || calificacion > 100) {mensaje = "numero erroneo";}
        else mensaje = "numero erroneo";
        
        // usando el caso
        switch (calificacion)
        {
            case >= 90:
                mensaje = "La calificacion es Exelente";
                break;
            case >= 70:
                mensaje ="La calificacion es aprobatoria";
                break;
            case >= 60:
                mensaje = "La debes recuperar";
                break;
            case < 60:
                mensaje = "la calificacion es reprobatoria";
                break;
        }
        
        Console.WriteLine(resultado);
        Console.WriteLine($"obtubiste una calificacion de {calificacion} este es el veredicto {mensaje}");
    }
}*/