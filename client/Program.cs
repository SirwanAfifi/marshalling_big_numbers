using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace client
{
    public class APIResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("count")]
        public long Count { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "http://localhost:3000/api";
            using (var client = new HttpClient())
            {
                var content = await client.GetStringAsync(url);
                var result = JsonSerializer.Deserialize<APIResponse>(content);
                Console.WriteLine(result.Count);
            }
        }
    }
}
