namespace condicion;
/*
 * el programa me debe pedir: nombre, edad , dia de la semana y si tiene tarjeta de descuento
 * se valida la edad para verificar: si es niño, adolecente, adulto.
 * si la edad es 5 años (niño) se le da el 25%
 * si la edad es 12 (adolecente) se le da el 15%
 * si es adulto mayor a 12 años (adulto) se le da 0%
 *
 * luego se valida si el dia es miercoles se le da 25% de descuento.
 * si tiene tarjeta 25%
 * si es miercoles y tiene tarjeta 50%
 *
 * se quema el valor de la boleta para el cine
 *
 * la validacion de la edad se debe hacer con un terniario
 */
public class cine
{
    static void Main(string[] args)
    {
        Console.WriteLine("dinos tu nombre");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("dinos tu edad");
        int edad = int.Parse(Console.ReadLine());
        
        Console.WriteLine("ingresa el dia de la semana");
        string semana = Console.ReadLine();
        
        Console.WriteLine("tienes cupon si/no");
        bool tieneCupon = Convert.ToBoolean(Console.ReadLine());

        double precioCine = 20000;
        double porcentaje = 0;

        porcentaje += (semana == "miercoles") ? 0.25 : 0.0;
        
        porcentaje += (tieneCupon) ? 0.25 : 0.0;
        
        porcentaje += (edad  <= 5) ? 0.25:
                (edad >= 6 && edad <= 12) ? 0.15 : 0.0;
        
        double totalPorcentaje = precioCine * (1 - porcentaje);
        
        Console.WriteLine($"tu nombre es: {nombre}");
        Console.WriteLine($"tu edad es: {edad}");
        
    }
}
/*
// se definen variables
        string nombre, diaSemana;
        int edad;
        bool tieneTarjeta;
        const double precioBoleta = 10000;
        double descuentoEdad, descuentoEspecial, descuentoFinal, precioFinal;

        // --- peticion de inputs ---
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el día de la semana: ");
        diaSemana = Console.ReadLine().Trim().ToLower(); // facilita la lectura con minusculas

        Console.Write("¿Tiene tarjeta de descuento? (S/N): ");
        string respuestaTarjeta = Console.ReadLine().Trim().ToUpper();
        tieneTarjeta = (respuestaTarjeta == "S"); // respuesta booleana

        Console.WriteLine("\n--- Procesando descuento ---");

        // --- CLASIFICAR POR EDAD CON TERNARIO ---
        // Se asigna el porcentaje de descuento según la edad
        descuentoEdad = (edad <= 5) ? 0.25 :
                        (edad <= 12) ? 0.15 : 0.0;

        // También obtenemos el tipo de cliente para mostrarlo
        string tipoCliente = (edad <= 5) ? "Niño" :
                             (edad <= 12) ? "Adolescente" : "Adulto";

        // --- VALIDAR DESCUENTO POR DÍA Y TARJETA ---
        bool esMiercoles = (diaSemana == "miércoles" || diaSemana == "miercoles");

        // Regla especial: si es miércoles y tiene tarjeta → 50% fijo
        if (esMiercoles && tieneTarjeta)
        {
            descuentoEspecial = 0.50;
        }
        else if (esMiercoles)
        {
            descuentoEspecial = 0.25;
        }
        else if (tieneTarjeta)
        {
            descuentoEspecial = 0.25;
        }
        else
        {
            descuentoEspecial = 0.0;
        }

        // --- CALCULAR DESCUENTO FINAL ---
        // El descuento total es la suma del descuento por edad y el especial
        descuentoFinal = descuentoEdad + descuentoEspecial;

        // El máximo descuento posible es 100%
        if (descuentoFinal > 1.0)
            descuentoFinal = 1.0;

        // --- CALCULAR PRECIO FINAL ---
        precioFinal = precioBoleta - (precioBoleta * descuentoFinal);

        // --- SALIDA DE RESULTADOS ---
        Console.WriteLine("\n--- RESULTADO ---");
        Console.WriteLine($"Cliente: {nombre}");
        Console.WriteLine($"Tipo de cliente: {tipoCliente}");
        Console.WriteLine($"Descuento aplicado: {descuentoFinal * 100}%");
        Console.WriteLine($"Precio final a pagar: ${precioFinal:F2}");
 */       