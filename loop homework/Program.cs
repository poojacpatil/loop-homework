using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find the sum of all even numbers between 1 to n.
            int count, num, sum = 0;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            for (count = 1; count <= num; count++)
            {
                if (count % 2 == 0)
                    sum = sum + count;
            }
            Console.WriteLine("sum of all even number="+sum);

            Console.Read();
        }
    }
}
