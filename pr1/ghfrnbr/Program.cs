using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghfrnbr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            var x = double.Parse(Console.ReadLine());
            var y = 7.0 * Math.Pow(x, 2) + 3.0 * x + 6.0;
            Console.WriteLine($"y: {y}");
            Console.ReadKey();
        }
    }
}
