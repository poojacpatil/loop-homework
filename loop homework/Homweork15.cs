using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homweork15
    {
        static void Main(string[] args)
        {
            //accept base and index from user and calculate power.
            Console.WriteLine("Enter the number");
            int index = Convert.ToInt32(Console.ReadLine());
            int bse = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 1; i <= bse; i++)
            {
                result = result * index;
            }
            Console.WriteLine(result);
        }
    }
}
