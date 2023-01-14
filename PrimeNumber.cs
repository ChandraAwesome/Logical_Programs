using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static void Prime()
        {
            Random random= new Random();
            int N = random.Next();
            //Console.WriteLine(N);
            int p = 0;
            //
            int m = N / 2;
            if(N==0 || N==1)
            {
                Console.WriteLine(N+"It is not a Prime Number");
            }
            else
            {

                for(int i=2; i<=N; i++)
                {
                    if(N%i==0)
                    {
                        Console.WriteLine(N+"It is not a Prime Number");
                        p = 1;
                    }
                    break;
                }
            }if(p==0)
            {
                Console.WriteLine(N + "It is a Prime Number");
            }
            
        }
    }
}
