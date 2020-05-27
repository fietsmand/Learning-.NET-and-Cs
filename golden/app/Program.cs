using Library;
using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The Answer Is {new Thing().Get(19, 23)}");
        }
    }
}
