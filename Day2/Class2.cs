using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int  sum = 0;
        
            while(n>0)
            {
                int num = n;
                n = n % 10;
                if (n % 2 != 0)
                {
                    int fact = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        fact = (fact * i);
                    }
                   sum = sum + fact;
                }

                n = num / 10;
                }
            Console.WriteLine("sum of odd digit factorial="+sum);
            Console.Read();
            }
        }
    }

