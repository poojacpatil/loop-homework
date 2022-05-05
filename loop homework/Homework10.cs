using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework10
    {
        static void Main(string[] args)
        {
            //count number of digit in any number
            Console.WriteLine("Enter the number");
             int num =Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                int r = num % 10;
                Console.WriteLine(r);
                num = num / 10;
            }
            Console.WriteLine("No of the digit="+count);

            Console.Read();
        }
    }
}
