using System;

namespace Hello
{
    class Program
    {

        // Adding `--` to the end of a dotnet command, anything after will be added as an argument, and will be stored in the first parameter of the `Main` method
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                try
                {
                    var generator = new FibonacciGenerator();
                    foreach (var digit in generator.Generate(Int32.Parse(args[0])))
                    {
                        Console.WriteLine(digit);
                    }
                    
                }
                catch (System.Exception)
                {
                    Console.WriteLine("The parameter supplied is not of Number type.");
                }
                
            }
            else
            {
                Console.WriteLine("No parameters have been supplied, please add `-- <NUMBER>` to the end of the command");
            }
        }
    }
}