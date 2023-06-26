
using Newtonsoft.Json;

namespace Meteo
{
    public class WeatherInfo
    {
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public string Code { get; set; }
        [JsonProperty("coord")]
        public Coordonnees Coord { get; set; }
        public Weather weather { get; set; }

        [JsonProperty("base")]
        public string Base {get; set;}

        [JsonProperty("main")]
        public Main Main { get; set;}
        public int Visibility{ get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                    //$"Name: {Name}\n" +
                    $"Code: {Code} \n" +
                    $"visibility: {Visibility}\n";
                    
        }


    }
}
