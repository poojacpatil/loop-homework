using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework4
    {
        static void Main(string[] args)
        {
            //1221
            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = a;
            int rev = 0;
            while (a > 0)
            {
                int d = a % 10;
                rev = rev * 10 + d;
                a = a / 10;
            }
            if(rev==n)
                Console.WriteLine("palindrome");
             else
                Console.WriteLine("Not palindrome");
        }
    }
}
