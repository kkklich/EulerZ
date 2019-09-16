using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler9_Kwadraty
{
    class Program
    {
        static void Main(string[] args)
        {

            int ilosc = 2;
          
            int j=0,kwadrat=0,potega;


            /*while (suma < 1000)
            {
                suma = 0;
                kwadrat = 0;
                for (int i = j; i < j + ilosc; i++)
                {
                    kwadrat += (int)Math.Pow(i, ilosc);
                    suma += i;
                    potega = (int)Math.Pow(i + 1, ilosc);
                    if (potega == kwadrat)
                    {
                        int iloczyn = (i - 2) * (i - 1) * i;
                       // Console.WriteLine("{0} {1}   kw:{2}    {3}  To ten jest super", i - 1, i, kwadrat, potega);


                    }
                

               // Console.WriteLine("{0} {1}   kw:{2}    ", i - 1, i, kwadrat);
            }
                j++;
                //Console.WriteLine("  kwaww: {0}",kwadrat);
            }
            */
            ilosc = 2;
            int ile = 0;

            int sum=0,i=0,k=0,a=0;
            int p = 10;

            while (sum < 1000)
            {
                for (i = 1; i < p; i++)

                //while(sum<10)
                {
                    //i++;
                    //while (sum < 10)
                    for (k = 1; k < p; k++)
                    {
                        //k++;
                        kwadrat = (int)Math.Pow(i, ilosc);

                        kwadrat += (int)Math.Pow(k, ilosc);
                        //while (sum < 10)
                        for (a = 1; a < p; a++)
                        {
                            // a++;
                            int poteg = (int)Math.Pow(a, ilosc);
                            if (kwadrat == poteg)
                            {
                                sum = i + k + a;
                                if (sum == 1000)
                                {
                                    long ilocz = i * k * a;
                                    Console.WriteLine("  a{0}  b{1}  c{2}     ^2{3}  sum{4}  iloczyn {5}", i, k, a, poteg, sum, ilocz);
                                    goto znaleznione;
                                }
                            }

                        }
                        //  Console.WriteLine("{0}:   {1}  {2} kw: {3}",ile, i, k, kwadrat);
                        ile++;
                    }
                }
                p = p * 10;
            }

        znaleznione:
            Console.WriteLine("ok");

            Console.ReadLine();
        }
    }
}
