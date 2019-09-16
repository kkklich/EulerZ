using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler12_TrianglerNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int iloscdziel=0;

            long tria;
            int i = 0;
            //for (int i = 0; i < 10; i++)
            while(iloscdziel<=500)
            {
                iloscdziel = 0;
                tria = (i * (i + 1)) / 2;
                Console.Write("{0}: {1}  ",i,tria);

                for(long j=tria/2; j>0 ;j--)
                {
                    if(tria%j==0)
                    {
                        //Console.Write(" " + j);
                        iloscdziel++;
                    }
                }
                Console.WriteLine("     Ile dziel: "+iloscdziel);
                
                i++;
            }

            Console.ReadLine();
        }
    }
}
