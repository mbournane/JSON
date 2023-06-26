
using System.ComponentModel;
using System.Xml.Linq;

namespace Meteo
{
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

        public override string ToString()
        {
            return $"id :{id}\n" +
                    $"main: {main}\n" +
                    $"description: {description} \n" +
                    $"icon: {icon}\n";
                    
        }
    }
}
