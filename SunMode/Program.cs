using System;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace ChuckAPI
{
    class Program
    {
        private static string url = "https://api.sunrise-sunset.org/json?lat=59.4370&lng=24.7536&date=2020-10-13";
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();

                SunMode sunMode = JsonConvert.DeserializeObject<SunMode>(response);
                Console.WriteLine($"Sunrise: {sunMode.Results.Sunrise}.");
                Console.WriteLine($"Sunset: {sunMode.Results.SunSet}. ");
                Console.WriteLine($"Status: {sunMode.Status}. ");
            }
        }
    }
}
