// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum;

            Console.Write("input a:");
            x = int.Parse(Console.ReadLine());
            Console.Write("input b:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            sum = x + y;

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine();
            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
