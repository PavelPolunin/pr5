using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X"); 
            double x = Convert.ToInt32(Console.ReadLine());
            double y = 5 * Math.Sin(x) - 7 * Math.Cos(x);
            Console.WriteLine("Result: " + y);
            Console.ReadKey();
        }
    }
}
