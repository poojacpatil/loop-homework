using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework3
    {
        // print table of given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i ++)
            {
                Console.WriteLine($"{n}x{i}={n*i}");
            }
            Console.Read();
        }
    }
}
