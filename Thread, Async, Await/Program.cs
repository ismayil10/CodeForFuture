using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
       
        Thread thread1 = new Thread(GetNumbers);
        Thread thread2 = new Thread(GetNumbers2);

        thread1.Start();    
        thread2.Start();     

        string result = await GetString();
        Console.WriteLine($"Async method returned: {result}");

        GetNumbers3();

        Console.WriteLine("Main method finished.");
    }

    public static void GetNumbers()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"GetNumbers 1 - {i}");
            Thread.Sleep(200);
        }
    }

    public static void GetNumbers2()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"GetNumbers 2 - {i}");
            Thread.Sleep(300);
        }
    }

    public static void GetNumbers3()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"GetNumbers 3 (Main thread) - {i}");
            Thread.Sleep(400);
        }
    }

    public static async Task<string> GetString()
    {
        Console.WriteLine("Async method started...");
        await Task.Delay(1000); 
        return "APA101";
    }
}
