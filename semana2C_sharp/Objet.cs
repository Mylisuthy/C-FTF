namespace semana2;

public class Objets
{
    public class products()
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        
        public category category { get; set; }
    }

    public class category()
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}