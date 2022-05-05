using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework14
    {
        static void Main(string[] args)
        {
            //1!+2!+3!......+n! find s
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1, sum = 0;
            for (int i = 1; i <= n; i ++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);

            Console.Read();
        }
    }
}
