using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int a = num % 10;
                sum = sum + a;
                num = num / 10;
            }
            Console.WriteLine("Addition of digit is:{0},sum");
            if(num / sum==0)
                Console.WriteLine("Harshad niven number");
            else
                Console.WriteLine("Not Harshad niven number");
        }
    }
}
