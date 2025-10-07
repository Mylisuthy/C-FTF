using System.Text.Json;
using System.Text.Json.Serialization;

namespace  RefuerzoC;

public class Program
{
    static async Task Main(string[] args)
    {
        // I play pokemon go every day
        
        
        Console.WriteLine("que pokemon deseas buscar");
        var Pokemon = int.Parse(Console.ReadLine());
        await Pokemons(Pokemon);
        Console.WriteLine("----------------------------------------------");
        await LlamadoApiClima();
        
        
        // rick
        
        
        Console.WriteLine("cual pj le busco bro, dime el numero del 1 al 80");
        var Mortys = int.Parse(Console.ReadLine());
        
        if (Mortys < 1 || Mortys > 81)
        {
            Console.WriteLine("man la id es desde 1 a 80");
        }
        else
        {
            await morty(Mortys);
        }
        
        
        // School
        
        Console.WriteLine("por favor dime el nombre de la ciudad");
        var busqueda = Console.ReadLine();
        await Univercitys(busqueda);
    }

    static async Task Univercitys(string busqueda)
    {
        try
        {
            var UrlApi = $"http://universities.hipolabs.com/search?country={busqueda}";

            var Education = new HttpClient();
        
            Console.WriteLine("toy buscando");

            var jsonData = await Education.GetStringAsync(UrlApi);
            
            var data = JsonSerializer.Deserialize<List<sufrimiento>>(jsonData);
            var LimitFind = data.Take(5).ToList();

            foreach (var d in LimitFind)
            {
                Console.WriteLine($@"
Universidad {d.name}
Pais: {d.country}
Sitios web: {d.webpages[0]}
");
            }
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Error al conectar con la api: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("error sin manejar: " + e.Message);
        }
    }
    
    
    //muestra chistes
    static async Task LlamadoApiClima()
    {
        try
        {
            string api = "https://official-joke-api.appspot.com/random_joke";
            HttpClient client = new HttpClient();

            Console.WriteLine("Buscando un chiste");

            string respuesta = await client.GetStringAsync(api);
            
            // como deserializar

            JsonDocument json = JsonDocument.Parse(respuesta);

            string setup = json.RootElement.GetProperty("setup").GetString();
            string puchline = json.RootElement.GetProperty("punchline").GetString();
            Console.WriteLine("Lee tu chiste");
            Console.WriteLine("setip: " + setup);
            Console.WriteLine("punchis: " + puchline);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"error al conectar con la api {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"error no controlado {e.Message}");
        }
    }
    // muestra pokemon
    static async Task Pokemons(int id)
    {
        try
        {
            string api = $"https://pokeapi.co/api/v2/pokemon/{id}";
            HttpClient client = new HttpClient();
            
            Console.WriteLine("buscando Pokemons");
            string respuesta = await client.GetStringAsync(api);
            Console.WriteLine("aqui esta el mensaje");
            //Console.WriteLine(respuesta);
            
            JsonDocument json = JsonDocument.Parse(respuesta);
            
            
            string setup = json.RootElement.GetProperty("name").GetString();
            string Ab = json.RootElement.GetProperty("ability").GetString();
            Console.WriteLine("name: " + setup);
            Console.WriteLine("ability" + Ab);
            
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine($"error al conectar con la api {e.Message}");
        }
    }
    // rick and morty api
    static async Task morty(int Mortys)
    {
        try
        {
            string Url = $"https://rickandmortyapi.com/api/character/{Mortys}";

            HttpClient molti = new HttpClient();
        
            Console.WriteLine("investigando");
            string results = await molti.GetStringAsync(Url);
            Console.WriteLine("aqui esta tu bastardo");
            //Console.WriteLine(results);
        
            var propiedades = JsonSerializer.Deserialize<data>(results);
        
            Console.WriteLine("Como se llama: " + propiedades.name);
            Console.WriteLine("en que estado se encuentra: " + propiedades.status);
            Console.WriteLine("de que especie es: " + propiedades.species);
        
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("manco: " + e);
        }
    }
}

internal class sufrimiento
{
    public string name { get; set; }
    public string country { get; set; }
    [JsonPropertyName("web_pages")]
    public List<string> webpages { get; set; }
}

internal class data
{
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
}
