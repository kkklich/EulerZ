using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler7_Pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba = 67;


            
            bool czypierwsza = true;
            int i = 2;
            int nrliczby = 0;
            int j = 2;

            //for (int j = 2; j < 10001; j++)
            while(nrliczby<10001)
            {
                czypierwsza = true;
                i = 2;
                while (czypierwsza is true && i < j)
                {
                    if (j % i == 0)
                    {
                        czypierwsza = false;
                    }


                    ++i;
                }

                if (czypierwsza is true)
                {
                    nrliczby++;
                    Console.WriteLine(" {0}   {1}", nrliczby, i);
                    
                }

                j++;
            }

            Console.ReadLine();
        }
    }
}
