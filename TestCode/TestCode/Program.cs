using System.Collections.Specialized;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            int a = Interlocked.Exchange(ref test, 1);
            int b = Interlocked.Exchange(ref test, 1);
            Console.WriteLine($"{a} - {test}");
        }
    }
}