namespace Class_poo.Models;

public class Taza
{
    public string Color { get; set; }
    public string Tamaño { get; set; }
    public string Material { get; set; }
    public int Capacidad { get; set; }
    public int CantidadActual { get; set; }

    public Taza(string color, string material, int capacidad)
    {
        Color = color;
        Material = material;
        Capacidad = capacidad;
        CantidadActual = 0;

    }

    public void llenar(int Cantidad)
    {
        if (CantidadActual + Cantidad > Capacidad)
        {
            CantidadActual = Cantidad;
            Console.WriteLine("la taza esta llena");
        }
        else
        {
            CantidadActual += Cantidad;
            Console.WriteLine($"se agrego {Cantidad} a la taza");
        }
    }

    public void beber(int Cantidad)
    {
        if (Cantidad > CantidadActual)
        {
            Console.WriteLine("No hay suficiente liquido");            
        }
        else
        {
            CantidadActual -= Cantidad;
            Console.WriteLine($"la taza {Color} de material {Material} tiene una capacidad de: {Capacidad}ml y tiene{CantidadActual} de ml");
        }
    }

    public void vaciar()
    {
        if (CantidadActual > 0)
        {
            Console.WriteLine("aun hay cafe en la tasa");
        }
        else
        {
            Console.WriteLine("no hay cafe en la tasa");
        }
    }
}