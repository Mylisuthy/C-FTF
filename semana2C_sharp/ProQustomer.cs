using Objeto.Models;

namespace Class2;

public static class ProQustomer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------");

        var productos = new List<Product>
        {
            new Product { id = 1, name = "shampoo", price = 20000 },
            new Product { id = 2, name = "crema dental", price = 12000 },
            new Product { id = 3, name = "canela Rama", price = 10000 },
            new Product { id = 4, name = "sanahoria", price = 1000 },
            new Product { id = 5, name = "desodorante", price = 1000 }
        };

        var customers = new List<Customer>
        {
            new Customer { id = 1, name = "cami", email = "camilo@gmail.com" },
            new Customer { id = 2, name = "elcejas", email = "ñaño@gmail.com" },
            new Customer { id = 3, name = "Kevin", email = "lapulga2025@gmail.com" },
            new Customer { id = 4, name = "mailo", email = "" }
        };


        var orders = new List<Orders>
        {
            new Orders { id = 1, CustomerId = 1, ProductId = 1, Quantity = 5 },
            new Orders { id = 2, CustomerId = 2, ProductId = 2, Quantity = 4 }
        };


        // LINQ
        // retornemos los productos con precui menor a 1000

        var query = from Product in productos where Product.price <= 1000 select Product;

        foreach (var order in query)
        {
            Console.WriteLine(order.name);
        }

        var queryLamda = productos.Where(p => p.price < 1000);

        Console.WriteLine("---------------------------------------------------2");
        // filtrar productos con precio mayor a 1500 e inprimirlos

        var queryMayor = productos.Where(p => p.price > 1500);

        foreach (var orderss in queryMayor)
        {
            Console.WriteLine(orderss.id);
        }

        Console.WriteLine("---------------------------------------------------3");
        // selecconar los nombres de los productos
        // var quetyName = from Product in productos select Product.name;
        var queryName = productos.Select(p => p.name);

        foreach (var critike in queryName)
        {
            Console.WriteLine(critike);
        }

        Console.WriteLine("---------------------------------------------------4");
        // ordenar productos por precio asendente
        var desendentQuery = productos.Select(p => p.price);
        foreach (var desendent in desendentQuery)
        {
            Console.WriteLine(desendent);
        }

        Console.WriteLine("------------------------------------5");
        // verificacion
        bool verificar = productos.All(p => p.price > 400);
        Console.WriteLine($"todos los productos mayores: {verificar}");

        Console.WriteLine("------------------------------------6");
        //verificar que todos los clientes tengan correo electronico
        bool correo = customers.All(c => c.email != "" && c.email != null);
        Console.WriteLine($"todos tienen correo? {correo}");

        Console.WriteLine("-------------------------------------7");
        // verificar si una id existe
        var ids = productos.Select(p => p.id);
        bool existe = ids.Contains(1);
        Console.WriteLine($" existe esta id? {existe}");

        Console.WriteLine("-------------------------------------8");
        //verificar si un cliente existe
        var idc = customers.Select(c => c.id);
        bool existeCliente = customers.Exists(c => c.id != 1);
        bool existeC = idc.Contains(3);
        Console.WriteLine($" existe esta id? {existeC}");
        Console.WriteLine($"existe Cliente 1? {existeCliente}");

        Console.WriteLine("--------------------------------9");
        // mostrar la orden con el nombre del cliente y el producto asignado a ese cliente
        var orden = from o in orders
            join c in customers on o.id equals c.id
            join p in productos on o.id equals p.id
            select new { o.id, c.name, p.price };

        foreach (var i in orden)
        {
            Console.WriteLine($"{i.id} - {i.name} - {i.price}");
        }
        
        // lamda lol
        Console.Write("ingresa el Numero: ");
        int idBuscado = int.Parse(Console.ReadLine());

        var resultado = customers
            .Join(orders,
                c => c.id,          
                o => o.CustomerId,  
                (c, o) => new { c.name, o.id }
            )
            .Join(productos,
                co => co.id,        
                p => p.id,       
                (co, p) => new { co.id, co.name, Producto = p.name }
            )
            .FirstOrDefault(r => r.id == idBuscado);
        

        Console.WriteLine(
            resultado != null 
                ? $"Pedido: {resultado.id} Nombre: {resultado.name} Producto: {resultado.Producto}" 
                : "Pedido no encontrado."
        );
    }
}