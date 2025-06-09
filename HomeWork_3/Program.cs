using System;
using System.IO;
using System.Threading.Tasks;

class ConfigLoader
{
    private string _configData;

    private ConfigLoader() { }

    
    public static async Task<ConfigLoader> CreateAsync(string filePath)
    {
        var instance = new ConfigLoader();
        await instance.LoadConfigAsync(filePath);
        return instance;
    }

    private async Task LoadConfigAsync(string filePath)
    {
        
        _configData = await File.ReadAllTextAsync(filePath);
    }

    public string GetConfig()
    {
        if (_configData == null)
            throw new InvalidOperationException("Config not loaded yet.");
        return _configData;
    }
}
class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            ConfigLoader loader = await ConfigLoader.CreateAsync("config.txt");

            string config = loader.GetConfig();
            Console.WriteLine(config);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

