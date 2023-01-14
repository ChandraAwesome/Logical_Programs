using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumeber
    {
        public static void Perfect()
        {
            Random random= new Random();
            long N = random.Next(1,50);
            Console.WriteLine(N);
            int sum = 0;
            //
            int i = 1;
            while(i<N)
            {
                if(N%i==0)
                {
                    sum=sum+ i;
                }
                i++;
                //Console.WriteLine(i);
            } if(sum == N)
            {
                Console.WriteLine(N + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(N+" is not a Perfect Number");
            }
        }
    }
}
