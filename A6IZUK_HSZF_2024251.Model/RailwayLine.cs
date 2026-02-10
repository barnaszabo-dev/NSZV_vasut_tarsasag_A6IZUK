using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace A6IZUK_HSZF_2024251.Model
{
    // Ez az osztály egy vasútvonal adatait reprezentálja,
    // beleértve a vonal számát, nevét és a hozzá tartozó szolgáltatásokat.
    public class RailwayLine
    {
        // A vasútvonal azonosító száma.
        public string LineNumber { get; set; }

        // A vasútvonal neve (pl. "BP-Keleti->Szolnok").
        public string LineName { get; set; }

        // A vasútvonalhoz tartozó járatok listája. A JSON-ban "Service" néven található.
        [JsonProperty("Service")]
        [JsonConverter(typeof(SingleOrArrayConverter<Service>))]
        public List<Service> Services { get; set; } = new List<Service>();
    }

    // Egyedi JSON konverter, amely kezeli, ha a JSON-ban a lista egy elemként vagy tömbként jelenik meg.
    public class SingleOrArrayConverter<T> : JsonConverter
    {
        // Meghatározza, hogy ez a konverter alkalmazható-e a megadott típusra.
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(List<T>));
        }


        // JSON-ból való olvasás (deszerializáció) során használatos.
        // Ha a JSON-ban egy elem található, azt listává alakítja; ha tömb van, azt egyszerűen listává konvertálja.
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<List<T>>();
            }
            return new List<T> { token.ToObject<T>() };
        }

        // JSON-ba írás (szerializáció) során használatos.
        // Ha a lista egyetlen elemet tartalmaz, azt objektumként írja ki; ha több elemet, akkor tömbként.
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var items = value as List<T>;
            if (items == null)
            {
                writer.WriteNull();
                return;
            }

            // Ha egyetlen elem van, objektumként írjuk ki; ha több, akkor tömbként
            if (items.Count == 1)
            {
                serializer.Serialize(writer, items[0]);
            }
            else
            {
                serializer.Serialize(writer, items);
            }
        }
    }
}
