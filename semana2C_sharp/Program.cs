/*
namespace semana2;

public static class Program
{
    public static void Carlota(string[] args)
    {
        var producto1 = new Objets.products
        {
            id = 1,
            name = "bed",
            price = 2000
        };
        
        Console.WriteLine($"Name: {producto1.name}, Cuantity: {producto1.price}");

        var producto2 = new Objets.products
        {
            id = 2,
            name = "stand",
            price = 2000
        };

        var producto3 = new Objets.products
        {
            id = 3,
            name = "shirt",
            price = 2000
        };
        
        List<Objets.products> product = new List<Objets.products>{producto1, producto2, producto3};

        foreach (var p in product)
        {
            Console.WriteLine(p.name, p.price);
        }

        var category1 = new Objets.category { id = 1, name = "libros" };
        var category2 = new Objets.category { id = 2, name = "electrodomesticos" };
        
        var producto4 = new Objets.products { id = 4, name = "100AñosDeSoledad", price = 10000, category = category1 };
        var producto5 = new Objets.products { id = 5, name = "Phone",  price = 20000, category = category2 };
        
        Console.WriteLine($"Name: {producto4.name}, category: {producto4.category.name}");
        
        //-----------------------------------Array----------------------------------
         Console.WriteLine("------------array----------");
        var productos = new Objets.products[2];
        productos[0] = new Objets.products { id = 7, name = "calson", price = 2000, category = category2 };
        productos[1] = new  Objets.products { id = 8, name = "nevecon", price = 3000, category = category2 };

        foreach (var p in productos)
        {
            Console.WriteLine($"Nombre: {p.name} precio: {p.price}");
        }
        //-------------------------------Lista------------------------------------
        
        /* Crear:
         * lista con 3 obgetos nevera labadora estufa.
         *
         * Añadirle
         * se le debe agregar un nuevo obgeto llamado microhondas, computador
         */
        /*
        Console.WriteLine("-----------------List-----------------");
        
        var producto10 = new Objets.products { id = 10, name = "nevera", price = 5000, category = category2 };
        var producto11 = new Objets.products { id = 11, name = "labadora", price = 4000, category = category2 };
        var producto12 = new Objets.products { id = 12, name = "estufa", price = 3000, category = category2 };

        
        List<Objets.products> productoos = new List<Objets.products>{ producto10, producto11, producto12 };
        productoos.Add(new Objets.products { id = 13 , name = "microhondas", price = 3000, category = category2 });

        foreach (var p in productoos)
        {
            Console.WriteLine($"Nombre: {p.name} precio: {p.price}");
        }
        Console.WriteLine("-------------LINQ--------------");
        //Console.WriteLine("-------------Select--------------");
        // LINQ = se divide en operadores como select, order by, group by
        /* 
         * para el select es necesario
         * tener una lista ya creada con
         * la que puedas interactuar,
         * una vez creada la lista se le
         * busca con la sentencia LINQ 
         * para asi comenzar a recorrer
         * con un foreach.
         */
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        //var squaredNumbers = from number in numbers select number * 2;
        /*
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("-------------Order by--------------");
        *//*
        Console.WriteLine("--------------------------------------------------");
    }
}
*/
/*
 * 
 */