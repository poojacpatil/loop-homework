using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework6
    {
        // print all alphabet from a to z using for loop
        static void Main(string[] args)
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
