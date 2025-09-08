/* Objetivo de este codigo:
    el objetivo general es la creacion de una aplicacion con la que se pueda elegir como quiere que se le prepare el desayuno
    caso a resolver => un coder llega a una cafeteria (donde se demoran 2 horas en prepararlo) y quiere comprar su desayuno.
    que debe hacer el programa:
    1) pedir el nombre del estudiante
    2) preguntar cuantos huevos quiere
    3) preguntar el precio de cada huevo
    4) calcular el costo total de los huevos
    5) preguntar si quiere cafe
    6) si quiere cafe sumar el precio total del cafe al total de la venta
    7) mostrar un resumen del desayuno: 
        -nombre del estudiante
        -cantidad de huevos y su costo
        -precio del cafe si aplica
        -total a pagar
*/
namespace desayuno;

public class pedido_desayuno
{
    static void Main(string[] args)
    {
        Console.WriteLine("como te llamas");
        string nombre = Console.ReadLine();

        Console.WriteLine("Cuantos huevos deseas");
        int cantidadHuevos = int.Parse(Console.ReadLine());

        console.WriteLine("cuanto cuesta cada huevo?:")
        double precioHuevo = double.Parse(Console.ReadLine());

        double totalHuevo = cantidadHuevos - precioHuevo;

        Console.WriteLine("Deseas cafe? true/false");
        bool quiereCafe = bool.Parse(Console.ReadLine());

        double precioCafe = 2000;
        double total = totalHuevo;

        if (quiereCafe)
        {
            total += precioCafe;
        }

        Console.WriteLine("resumen del desayuno:");
        Console.WreiteLine($"cantidad De huevos {cantidadHuevos}");
        Console.WriteLine($"precio huevo {precioHuevo}");

    }
}
