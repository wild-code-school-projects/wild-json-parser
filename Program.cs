using Newtonsoft.Json;

namespace JsonParser
{
    internal class Wind
    {
        public double Speed { get; set; }

        public double Deg { get; set; }
    }

    internal class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    internal class WeatherInfo
    {
        public long Dt { get; set; }
        public string Base { get; set; }
        public int Visibility { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public List<Weather> Weather { get; set; }
        public Wind Wind { get; set; }

        public S_Coord Coord;
        public S_Main Main;
        public S_Clouds Clouds;
        public S_Sys Sys;

        public struct S_Coord
        {
            public double Lon { get; set; }
            public double Lat { get; set; }
        }

        public struct S_Main
        {
            public double Temp { get; set; }
            public int Pressure { get; set; }
            public int Humidity { get; set; }
            public double TempMin { get; set; }
            public double TempMax { get; set; }
        }

        public struct S_Clouds
        {
            public int All { get; set; }
        }

        public struct S_Sys
        {
            public int Type { get; set; }
            public int Id { get; set; }
            public double Message { get; set; }
            public string Country { get; set; }
            public long Sunrise { get; set; }
            public long Sunset { get; set; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\weather.json";
            
            if (!File.Exists(path))
            {
                Console.WriteLine("path not found.");
            }

            WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(File.ReadAllText(path));
            Console.WriteLine("path found and object json get deserialized into wind object.");
        }

   
    }
}
