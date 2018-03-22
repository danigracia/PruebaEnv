using System;
using System.IO;

namespace ExampleEnvironment
{
    public class Program
    {
        public static void Main()
        {
            Environment.CurrentDirectory = Environment.GetEnvironmentVariable("TEST");
            DirectoryInfo info = new DirectoryInfo(".");

            Console.WriteLine("Directory Info:   " + info.FullName);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
