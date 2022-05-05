using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a= Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= a; i++)
            {
                int digit = a % 10;
                sum = sum * digit;
                a = a / 10;
            }
            Console.WriteLine(sum);

            Console.Read();
        }
    }
}
