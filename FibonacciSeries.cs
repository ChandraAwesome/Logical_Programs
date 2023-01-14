using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static void Fibonac()
        {
            Random random = new Random();
            int count = random.Next(1, 50);
            Console.WriteLine("count is :"+count);
            //
            int a = 0, b = 1, c;
            Console.WriteLine(a+" "+b);
            //
            for(int i=0; i<=count; i++)
            {
                c = a + b;
                a = b;
                b=c;
                Console.WriteLine(" "+c);
            }
        }
    }
}
