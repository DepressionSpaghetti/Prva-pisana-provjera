using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Definirajte klasu NebeskoTijelo sa sljedećim varijablama članicama:
    • varijable tipa double
    BrzinaOkoOsi 
    BrzinaOkoSunca 
    Definirajte klase Planet i Satelit izvedene iz klase NebeskoTijelo, te im definirajte sljedeće 
    konstruktore:
    Planet(double, double) 
    Satelit(double, double) 
    koji će dodijeliti vrijednosti proslijeđenih argumenata naslijeđenim varijablama članicama
    Definirajte dva objekta Zemlja i Mjesec tipova Planet i Satelit.*/

namespace Pisana_provjera_5
{

    class NebeskoTijelo
    {
        public double BrzinaOkoOsi, BrzinaOkoSunca;

        public NebeskoTijelo(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double BrzinaOkoOsi, double BrzinaOkoSunca) : base(BrzinaOkoOsi, BrzinaOkoSunca)
        { 
            BrzinaOkoOsi = BrzinaOkoOsi;
            BrzinaOkoSunca = BrzinaOkoSunca;
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double BrzinaOkoOsi, double BrzinaOkoSunca) : base(BrzinaOkoOsi, BrzinaOkoSunca)
        {
            BrzinaOkoOsi = BrzinaOkoOsi;
            BrzinaOkoSunca = BrzinaOkoSunca;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(1234.56, 12453.65);
            Satelit Mjesec = new Satelit(1425.53, 12453.65);
        }
    }
}
