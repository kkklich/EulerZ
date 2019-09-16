using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sie

namespace Euler10_SumaPierwszych
{
    class Program
    {
        static void Main(string[] args)
        {
            bool czypierwsza = true;
            int i = 2;
            int nrliczby = 0;
            long sumaPierwszych = 0;
            //int j = 2;

            for (int j = 2; j < 2000000; j++)
           // while (nrliczby < 10001)
            {
                czypierwsza = true;
                i = 2;
                while (czypierwsza is true && i < j)
                {
                    if (j % i == 0)
                    {
                        czypierwsza = false;
                        break;
                    }


                    ++i;
                }

                if (czypierwsza is true)
                {
                    nrliczby++;
                    Console.WriteLine(" {0}   {1}", nrliczby, i);
                    sumaPierwszych += i;
                }

              
            }

            Console.WriteLine("Suma wynosi: {0}",sumaPierwszych);

            Console.ReadLine();


        }
    }
}
