using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_homework
{
    internal class Homework8
    {
        //print even number from 121 to 229 using for loop
        static void Main(string[] args)
        {
            for (int count = 121; count <= 229; count++)
            {
                if( count %2 == 0)
                    Console.WriteLine(count);
            }
            Console.Read();
        }
    }
}
