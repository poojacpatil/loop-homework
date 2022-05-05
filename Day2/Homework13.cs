using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework13
    {
        static void Main(string[] args)
        {
            int num, a, rem,  f = 1;
            Console.WriteLine("Enter the number");
             num= Convert.ToInt32(Console.ReadLine());
            a = num;
            int sum = 0;
            for(int i=0;i<=num;i++)
            {
                rem = a % 10;
                f = 1;
                for (int j = 1; j <= rem; j++)
                {
                    f = f * i;
                }
                sum = sum + f;
                a = a % 10;
            }
            if(sum==num)
                Console.WriteLine("Krishnamurty number");
            else
                Console.WriteLine("Not");
               
        }
    }
}
