using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler2_FIB
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0,fib=1,fib2;
            int i = 0,summa=0;
            while (suma < 4000000)
            {
                if (i == 0)
                {
                    suma = 1;
                    
                }
                else
                {
                    fib2 = suma;
                    suma += fib;

                    fib = fib2;

                    if(suma%2==0)
                    summa += suma;

                }
                Console.WriteLine("nr {0},   {1}   suma {2}",i,suma,summa);
                i++;
            }

            Console.ReadLine();

        }
    }
}
