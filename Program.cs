using System;

namespace ExampleEnvironment
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("TESTVAR = " + Environment.GetEnvironmentVariable("TESTVAR", EnvironmentVariableTarget.User));
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
