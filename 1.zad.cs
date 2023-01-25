using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napišite program u kojem ćete zatražiti od korisnika da unese niz znakova te će svaki razmak zamijeniti znakom '_'.

namespace Pisana_provjera_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string upis;

            Console.WriteLine("Upiši niz znakova. ");
            upis = Console.ReadLine();
            char[] niz = new char[upis.Length];

            for(int i = 0; i < upis.Length; i++)
            {
                niz[i] = upis[i];
            }

            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == ' ') { niz[i] = '_'; }
            }

            Console.WriteLine(niz);

            Console.ReadKey();
        }
    }
}
