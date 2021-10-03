using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiProgrammingTest
{
    public class Program
    {
        private static string _path = @"./code_city.json";
        public static void Main(string[] args)
        {
            var cityFromFile = GetCityJsonFromFile();
            DeserializeJsonFile(cityFromFile);

        }

        public static string GetCityJsonFromFile()
        {
            string cityJsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                cityJsonFromFile = reader.ReadToEnd();
            }
            return cityJsonFromFile;
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void DeserializeJsonFile(string cityFromFile)
        {
        
            var city = JsonConvert.DeserializeObject<List<Models.City>>(cityFromFile);

            Console.WriteLine(city);
        }

        
    }
}
