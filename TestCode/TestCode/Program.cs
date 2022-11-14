using System.Collections.Specialized;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"{Environment.TickCount64}");
                
                Thread.Sleep(1000); 
            }
            
        }
    }
}