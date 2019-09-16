using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler4_Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            int[] tablicapalindro = new int[10000];
            int ilepalind = 0;

            for(int i=1;i<1000;i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    liczba = i * j;


                    string palind = liczba.ToString();
                    int dlpalind = palind.Length;
                    if (dlpalind % 2 == 0)
                    {
                        int pol = dlpalind / 2;
                                                                     

                        string slowo1 = palind.Substring(0, pol);
                        string slowo2 = palind.Substring(pol , pol);


                        char[] ar = slowo2.ToCharArray();
                        Array.Reverse(ar);

                        string s = new string(ar);

                        //Console.WriteLine("{0}  {1}", slowo1, s);
                        if (slowo1.CompareTo(s) == 0)
                        {
                            //Console.WriteLine("{0}  {1}  {2}", slowo1, slowo2, palind);
                            tablicapalindro[ilepalind] = liczba;
                            ilepalind++;
                        }
                    }
                }
            }


            int dlugosc = 0;

            for (int i=0;i<tablicapalindro.Length;i++)
            {
                if (tablicapalindro[i] != 0)
                {
                   // Console.WriteLine(tablicapalindro[i]);
                    dlugosc++;
                }
            }


            int temp;
            for(int i=0;i<tablicapalindro.Length-1;i++)
            {
                for(int j=0;j< tablicapalindro.Length-1; j++)
                {
                    if(tablicapalindro[j] > tablicapalindro[j+1])
                    {
                        temp = tablicapalindro[j];
                        tablicapalindro[j] = tablicapalindro[j+1];
                        tablicapalindro[j+1] = temp;
                        


                    }

                }
            }

            

            for (int i = 0; i < tablicapalindro.Length-1; i++)
            {
                //if (tablicapalindro[i] != null)
                   Console.WriteLine(tablicapalindro[i]);

            }
           // Console.WriteLine(tablicapalindro.Max());
            Console.ReadLine();
        }
    }
}
