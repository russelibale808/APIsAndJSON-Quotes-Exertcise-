using System;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON_Quotes_Exertcise_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {

                var client = new HttpClient();
                var kanyeURL = "https://api.kanye.rest/";
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                Console.WriteLine($"Kanye {kanyeQuote}");
                Console.WriteLine();

                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace("[", "").Replace("]", "").Trim();

                Console.WriteLine($"Ron Swanson {ronQuote}");
                Console.WriteLine();
            }
        }
    }
}