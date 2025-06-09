using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var progress = new Progress<int>(percent =>
        {
            Console.WriteLine($"Progress: {percent}%");
        });

        await LongOperationAsync(progress);

        Console.WriteLine("Operation completed!");
    }

    static async Task LongOperationAsync(IProgress<int> progress)
    {
        int totalSteps = 5;

        for (int i = 1; i <= totalSteps; i++)
        {
           
            await Task.Delay(1000); 
            

            int percent = (i * 100) / totalSteps;
            progress.Report(percent);
        }
    }
}
