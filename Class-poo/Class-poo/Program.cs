using Class_poo.Models;

namespace Class_poo;

public class Program
{
    public static void Main()
    {
        Taza taza = new Taza("negro", "ceramica", 500);
    
        taza.llenar(500);
        taza.beber(250);
        taza.vaciar();

        TazaCafe tazaCafe = new TazaCafe(taza);
        tazaCafe.Cafe(90);
    }
}