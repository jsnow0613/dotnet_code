using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            System.Console.WriteLine($"a is {a},b is {b}");
        }
    }
}
