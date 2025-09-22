
namespace Class_poo.Models;

public class TazaCafe : Taza
{
    public string TipoCafe { get; set; }
    public bool TieneEspuma { get; set; }
    public TazaCafe(string color, string material, int capacidad, string tipoCafe, bool tieneEspuma) : base(color, material, capacidad)
    {
        TipoCafe = tipoCafe;
        TieneEspuma = tieneEspuma;
    }

    public void Cafe(int capacidad)
    {
        if (Capacidad < 100)
        {
            TipoCafe = "spress";
            Console.WriteLine($"aqui tienes tu cafe {TipoCafe}");
        }
        else
        {
            TipoCafe = "Mocka";
        }
    }
    
    
}