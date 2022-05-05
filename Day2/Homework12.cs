using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int x = a;

            int sum = 0;
            while (a > 0)
            {
                int digit = a % 10;
                sum = sum + digit * digit * digit;
                a = a / 10;
            }

            if(sum==0)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");
        }
    }
}
