using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sq = a * a;

            int sum = 0;
            while (sq > 0)
            {
                int d = sq % 10;
                sum = sum + d;
                sq = sq / 10;
            }
            if(sum==0)
                Console.WriteLine("Neon number");
            else
                Console.WriteLine("Not Neon number");

            Console.Read();
        }
    }
}
