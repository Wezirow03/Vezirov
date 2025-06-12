using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string result = GetPageContent("https://example.com");
        Console.WriteLine(result);
    }

    static string GetPageContent(string url)
    {
        HttpClient client = new HttpClient();
        return client.GetStringAsync(url).Result;
    }




  /*  static async Task Main(string[] args)
    {
        string result = await GetPageContentAsync("https://example.com");
        Console.WriteLine(result);
    }

    static async Task<string> GetPageContentAsync(string url)
    {
        HttpClient client = new HttpClient();
        return await client.GetStringAsync(url);
    }*/
}
