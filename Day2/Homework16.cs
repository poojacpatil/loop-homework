using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework16
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sq = num * num;
            int c = 0;
            while (num > 0)
            {
                if (num % 10 != sq % 10)
                {
                 c++;
                 break;
                }
                num = num / 10;
                sq = sq / 10;

            }
            if(c==0)
                Console.WriteLine("Automorphic number");
            else
                Console.WriteLine("Not Automorphic number");

            Console.Read();
        }
    }
}
