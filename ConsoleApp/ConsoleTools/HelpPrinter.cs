using System;

namespace ConsoleApp.ConsoleTools
{
    public class HelpPrinter
    {
        public void Print()
        {
            Console.WriteLine("Usage dotnet run -- [-p [problem]]");
            Console.WriteLine("My Project Euler solutions.");
            Console.WriteLine("If problem is omitted, all problems will run.");
            Console.WriteLine();
            Console.WriteLine("-p    --problem   the problem to run");
            Console.WriteLine("-s    --slow      just run problems marked as slow");
            Console.WriteLine("-c    --comment   just run problems that has a comment");
            Console.WriteLine();
            Console.WriteLine("-h    --help      display this help text");
            Console.WriteLine("");
        }
    }
}