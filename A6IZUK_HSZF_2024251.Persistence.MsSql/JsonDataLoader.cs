using A6IZUK_HSZF_2024251.Model;
using Newtonsoft.Json;
namespace A6IZUK_HSZF_2024251.Persistence.MsSql
{
    // Ez az osztály a JSON formátumú fájlokból való adatok betöltéséért felelős.
    public class JsonDataLoader 
    {
        // Vasútvonalak betöltése egy JSON fájlból.
        // Paraméter:
        // - filePath: A JSON fájl elérési útja, amely tartalmazza a vasútvonalak adatait.
        // Visszatérés: Egy lista a betöltött RailwayLine objektumokról.
        public static List<RailwayLine> LoadRailwayLinesFromJson(string filePath)
        {
            var railwayLines = new List<RailwayLine>();
            try
            {
                // A JSON fájl tartalmának beolvasása szövegként.
                var json = File.ReadAllText(filePath);
                // A JSON szöveg deszerializálása RailwayLine objektumok listájává.
                railwayLines = JsonConvert.DeserializeObject<List<RailwayLine>>(json);
                ;
            }
            catch (Exception ex)
            {
                // Hiba esetén hibaüzenet kiírása a konzolra.
                Console.WriteLine("An error occurred while loading JSON data: " + ex.Message);
            }
            // Visszatérés a betöltött vasútvonalak listájával.
            return railwayLines;
        }
    }
}
