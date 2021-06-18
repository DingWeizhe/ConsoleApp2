using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.gosu.bar/status");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            Console.ReadLine();
        }
    }
}
