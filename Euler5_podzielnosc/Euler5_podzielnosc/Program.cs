using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler5_podzielnosc
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba =2530;

            bool podzielne = false;



            //       for(int i=1;i<liczba;i++)


            int i = 1;

            while (podzielne is false)
            {
                podzielne = true;
                int j = 1;
                
                while(podzielne is true && j <= 20)
                {

                    if (i % j == 0 )
                    {
                        podzielne = true;
                    }
                    else
                    {
                        podzielne = false;
                        
                    }
                    
                    ++j;

                   

                }

                

                if (podzielne == true)
                {
                    Console.WriteLine("Liczba {0} jest podzielna przez 10 liczb", i);
                }
                ++i;
            }

            

            Console.ReadLine();
        }
    }
}
