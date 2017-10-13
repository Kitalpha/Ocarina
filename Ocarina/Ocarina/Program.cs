using Microsoft.Extensions.DependencyInjection;
using System;

namespace Ocarina
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .BuildServiceProvider();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
