using RiwiMusic.Models;

namespace RiwiMusic.Services
{
    public static class DataStore
    {
        // Diccionario para conciertos
        public static Dictionary<int, Concert> concerts = new Dictionary<int, Concert>
        {
            { 1, new Concert { Id = 1, Name = "Rock Fest", Capacity = 5000, Location = "Bogotá", ventas = 3500, date = "2025-09-20" } },
            { 2, new Concert { Id = 2, Name = "Jazz Nights", Capacity = 2000, Location = "Medellín", ventas = 1500, date = "2025-10-01" } },
            { 3, new Concert { Id = 3, Name = "Electro Beats", Capacity = 8000, Location = "Cali", ventas = 6000, date = "2025-11-15" } },
            { 4, new Concert { Id = 4, Name = "Pop Stars Live", Capacity = 10000, Location = "Bogotá", ventas = 9800, date = "2025-12-05" } },
            { 5, new Concert { Id = 5, Name = "Indie Vibes", Capacity = 3500, Location = "Cartagena", ventas = 2500, date = "2025-09-25" } },
            { 6, new Concert { Id = 6, Name = "Reggaeton Party", Capacity = 12000, Location = "Medellín", ventas = 11500, date = "2025-10-20" } },
            { 7, new Concert { Id = 7, Name = "Metal Attack", Capacity = 4500, Location = "Cali", ventas = 4200, date = "2025-11-10" } },
            { 8, new Concert { Id = 8, Name = "Salsa Night", Capacity = 6000, Location = "Barranquilla", ventas = 5800, date = "2025-12-15" } },
            { 9, new Concert { Id = 9, Name = "Classical Evening", Capacity = 3000, Location = "Bogotá", ventas = 2900, date = "2025-09-30" } },
            { 10, new Concert { Id = 10, Name = "Hip Hop Fest", Capacity = 7000, Location = "Medellín", ventas = 6700, date = "2025-10-25" } }
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
            { 1001, new Tiket { IdTiket = 1001, IdCustomer = 1, IdConcert = 1, InfTiket = "VIP, Asiento A1" } },
            { 1002, new Tiket { IdTiket = 1002, IdCustomer = 2, IdConcert = 2, InfTiket = "General, Asiento B5" } },
            { 1003, new Tiket { IdTiket = 1003, IdCustomer = 3, IdConcert = 3, InfTiket = "VIP, Asiento C2" } },
            { 1004, new Tiket { IdTiket = 1004, IdCustomer = 4, IdConcert = 4, InfTiket = "Platino, Asiento D10" } },
            { 1005, new Tiket { IdTiket = 1005, IdCustomer = 5, IdConcert = 5, InfTiket = "General, Asiento E8" } },
            { 1006, new Tiket { IdTiket = 1006, IdCustomer = 6, IdConcert = 6, InfTiket = "VIP, Asiento F1" } },
            { 1007, new Tiket { IdTiket = 1007, IdCustomer = 7, IdConcert = 7, InfTiket = "General, Asiento G3" } },
            { 1008, new Tiket { IdTiket = 1008, IdCustomer = 8, IdConcert = 8, InfTiket = "Platino, Asiento H6" } },
            { 1009, new Tiket { IdTiket = 1009, IdCustomer = 9, IdConcert = 9, InfTiket = "General, Asiento I4" } },
            { 1010, new Tiket { IdTiket = 1010, IdCustomer = 10, IdConcert = 10, InfTiket = "VIP, Asiento J2" } }
        };
    }
}
