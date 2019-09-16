using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler6_Kwadraty
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumakwadratow=0;
            int kwadratsum=0;

            for(int i=1;i<=100;i++)
            {
                sumakwadratow += i * i;
                

                kwadratsum += i;

            }

            kwadratsum = kwadratsum * kwadratsum;

            Console.WriteLine(sumakwadratow);
            Console.WriteLine(kwadratsum);
            int roznica = kwadratsum - sumakwadratow;

            Console.WriteLine(roznica);

            Console.ReadLine();
        }
    }
}
