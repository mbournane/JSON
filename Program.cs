using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using Newtonsoft.Json;

namespace Meteo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WildSchoul_Formation\S05\Quests\JSON";
            string filename = "weather.json";
            string pathAndFile = Path.Combine(path, filename);
            string jsonFile = File.ReadAllText(pathAndFile);

            WeatherInfo wr = JsonConvert.DeserializeObject<WeatherInfo>(jsonFile);

            Console.WriteLine("Name: "+wr.Name);
            Console.WriteLine("Main: " + wr.Main);
            Console.WriteLine("Code: " + wr.Code);
            Console.WriteLine("Base: " + wr.Base);
            Console.ReadLine();
        }
    }
}
