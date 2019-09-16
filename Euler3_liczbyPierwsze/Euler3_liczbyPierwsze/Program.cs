using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler3_liczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        { 
            long liczbaz = 600851475143;
            
            long k = 2;
            long n = liczbaz;


            while(n>1)
            {

                while(n%k==0)
                {
                    Console.WriteLine(k);
                    n = n / k;

                }
                ++k;
            }


            Console.ReadLine();

        }
    }
}
