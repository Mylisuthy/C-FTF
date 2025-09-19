using RiwiMusic.Models;

namespace RiwiMusic.Services
{
    public static class DataStore
    {
        // Diccionario para conciertos
        public static Dictionary<string, Concert> concerts = new Dictionary<string, Concert>
        {
            { "C001", new Concert { Id = "C001", Name = "Rock Fest", Capacity = 5000, Location = "Bogotá", ventas = 3500, date = "2025-09-20" } },
            { "C002", new Concert { Id = "C002", Name = "Jazz Nights", Capacity = 2000, Location = "Medellín", ventas = 1500, date = "2025-10-01" } },
            { "C003", new Concert { Id = "C003", Name = "Electro Beats", Capacity = 8000, Location = "Cali", ventas = 6000, date = "2025-11-15" } },
            { "C004", new Concert { Id = "C004", Name = "Pop Stars Live", Capacity = 10000, Location = "Bogotá", ventas = 9800, date = "2025-12-05" } },
            { "C005", new Concert { Id = "C005", Name = "Indie Vibes", Capacity = 3500, Location = "Cartagena", ventas = 2500, date = "2025-09-25" } },
            { "C006", new Concert { Id = "C006", Name = "Reggaeton Party", Capacity = 12000, Location = "Medellín", ventas = 11500, date = "2025-10-20" } },
            { "C007", new Concert { Id = "C007", Name = "Metal Attack", Capacity = 4500, Location = "Cali", ventas = 4200, date = "2025-11-10" } },
            { "C008", new Concert { Id = "C008", Name = "Salsa Night", Capacity = 6000, Location = "Barranquilla", ventas = 5800, date = "2025-12-15" } },
            { "C009", new Concert { Id = "C009", Name = "Classical Evening", Capacity = 3000, Location = "Bogotá", ventas = 2900, date = "2025-09-30" } },
            { "C010", new Concert { Id = "C010", Name = "Hip Hop Fest", Capacity = 7000, Location = "Medellín", ventas = 6700, date = "2025-10-25" } }
        };
        
        public static Dictionary<int, Customer> customers = new Dictionary<int, Customer>
        {
            { 1, new Customer { Id = 1, Name = "Juan Pérez", Email = "juanperez@gmail.com", Age = 25, TiketsOugneed = "2" } },
            { 2, new Customer { Id = 2, Name = "María Gómez", Email = "mariagomez@gmail.com", Age = 30, TiketsOugneed = "1" } },
            { 3, new Customer { Id = 3, Name = "Carlos Ruiz", Email = "carlosruiz@hotmail.com", Age = 27, TiketsOugneed = "3" } },
            { 4, new Customer { Id = 4, Name = "Ana Torres", Email = "anatorres@gmail.com", Age = 22, TiketsOugneed = "2" } },
            { 5, new Customer { Id = 5, Name = "Pedro López", Email = "pedrolopez@gmail.com", Age = 35, TiketsOugneed = "4" } },
            { 6, new Customer { Id = 6, Name = "Lucía Castro", Email = "luciacastro@gmail.com", Age = 29, TiketsOugneed = "1" } },
            { 7, new Customer { Id = 7, Name = "Diego Ramírez", Email = "diegoramirez@gmail.com", Age = 31, TiketsOugneed = "5" } },
            { 8, new Customer { Id = 8, Name = "Valentina Ríos", Email = "valentinar@gmail.com", Age = 26, TiketsOugneed = "2" } },
            { 9, new Customer { Id = 9, Name = "Miguel Ángel", Email = "miguelangel@gmail.com", Age = 28, TiketsOugneed = "3" } },
            { 10, new Customer { Id = 10, Name = "Laura Martínez", Email = "lauram@gmail.com", Age = 24, TiketsOugneed = "1" } }
        };

        // Diccionario para tiquetes
        public static Dictionary<int, Tiket> tikets = new Dictionary<int, Tiket>
        {
            { 1001, new Tiket { IdTiket = 1001, IdCustomer = 1, IdConcert = "C001", InfTiket = "VIP, Asiento A1" } },
            { 1002, new Tiket { IdTiket = 1002, IdCustomer = 2, IdConcert = "C002", InfTiket = "General, Asiento B5" } },
            { 1003, new Tiket { IdTiket = 1003, IdCustomer = 3, IdConcert = "C003", InfTiket = "VIP, Asiento C2" } },
            { 1004, new Tiket { IdTiket = 1004, IdCustomer = 4, IdConcert = "C004", InfTiket = "Platino, Asiento D10" } },
            { 1005, new Tiket { IdTiket = 1005, IdCustomer = 5, IdConcert = "C005", InfTiket = "General, Asiento E8" } },
            { 1006, new Tiket { IdTiket = 1006, IdCustomer = 6, IdConcert = "C006", InfTiket = "VIP, Asiento F1" } },
            { 1007, new Tiket { IdTiket = 1007, IdCustomer = 7, IdConcert = "C007", InfTiket = "General, Asiento G3" } },
            { 1008, new Tiket { IdTiket = 1008, IdCustomer = 8, IdConcert = "C008", InfTiket = "Platino, Asiento H6" } },
            { 1009, new Tiket { IdTiket = 1009, IdCustomer = 9, IdConcert = "C009", InfTiket = "General, Asiento I4" } },
            { 1010, new Tiket { IdTiket = 1010, IdCustomer = 10, IdConcert = "C010", InfTiket = "VIP, Asiento J2" } }
        };
    }
}
