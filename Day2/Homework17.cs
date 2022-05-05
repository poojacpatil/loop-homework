using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework17
    {
        static void Main(string[] args)
        {
            // print odd numbers from 521 to 229 using while loop
            int j = 521;
            while (j >= 229)
            {
                if (j % 2 != 0)
                    Console.WriteLine(j);
                j++;
            }
            Console.Read();
        }
    }
}
