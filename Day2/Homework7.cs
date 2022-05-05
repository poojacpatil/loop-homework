using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework7
    {
        static void Main(string[] args)
        {
            // print all palindrome number from 100 to 500
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int  rev = 0;
            for (int i=100; i <= 500; i++)
            {
                int d = a % 10;
                rev = rev * 10 + d;
                a = a / 10;

            }
            Console.WriteLine(" palindrom number");
        }
    }
}
