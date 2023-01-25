using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će za definirani niz tipa double pronaći član koji najmanje odstupa od 
prosječne vrijednosti niza. Program mora raditi ispravno za proizvoljni broj članova niza.*/

namespace Pisana_provjera_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] niz = { 0.45, 2.34, 5.67, 1.23, 4.20 };
            double prosjek = niz.Average(), bliskiClan = 0;

            for(int i = 0; i < (niz.Length - 1); i++)
            {
                for(int j = 1; j < niz.Length; j++)
                {
                    if (niz[i] <= prosjek && niz[j] > prosjek) bliskiClan = niz[i];
                    else if(niz[i] > prosjek && niz[j] < prosjek) bliskiClan = niz[j];
                    else bliskiClan = niz[i];
                }

            }

            Console.WriteLine(prosjek);
            Console.WriteLine(bliskiClan);
            Console.ReadKey();
        }
    }
}
