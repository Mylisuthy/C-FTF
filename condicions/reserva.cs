namespace condicion;
/* reservar vuelos
 * datos necesarios: nombre, edad, mes, dia
 * precio del tikete por defecto = 1.200.000
 * meses con descuento: octubre, enero, marzo = 30%
 * dias con descuento: lunes, martes, jueves = 10%
 *
 * si el nombre del cliente es andres = imprimes un " bienvenido y 30% extra
 */
public class reserva
{
    static void Main(string[] args)
    {
        Console.WriteLine("bienvenido a la aerolinea Mamasit@");
        
        Console.WriteLine("para poder hacer tu reserva por favor dinos tu nombre");
        string name = Console.ReadLine().Trim().ToLower();
        
        Console.WriteLine("ahora necesitamos saber tu edad");
        int edad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("que dia de mes vas a reservar?");
        string mes = Console.ReadLine().Trim().ToLower();
        
        Console.WriteLine("que dia es la reserva");
        string dia = Console.ReadLine().Trim().ToLower();
        
        double precioTikete = 1200000;
        double descuento = 0;
        string saludo = "bienvenido cliente vip";

        descuento += (mes == "octubre" || mes == "enero" || mes == "marzo") ? 0.30 : 0.0;

        descuento += (dia == "lunes" || dia == "martes" || dia == "jueves") ? 0.10 : 0.0;

        descuento += (name == "andres") ? 0.30 : 0.0;
        
        if

    }
}