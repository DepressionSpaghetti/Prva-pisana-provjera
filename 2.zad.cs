using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Napišite program koji će zatražiti od korisnika da unese dva stringa, te će ih ispisati po 
  abecedi u uzlaznom redoslijedu.*/

namespace Pisana_Provjera_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prviStr, drugiStr;

            Console.WriteLine("Upisite prvi string. ");
            prviStr = Console.ReadLine();
            Console.WriteLine("Upisite drugi string");
            drugiStr = Console.ReadLine();

            Console.WriteLine("\n");
            if(prviStr[0] < drugiStr[0]) Console.WriteLine(prviStr);
            else Console.WriteLine(drugiStr);

            Console.ReadKey();
        }
    }
}
