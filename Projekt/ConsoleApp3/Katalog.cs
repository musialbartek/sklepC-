using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Katalog
    {
        List<Produkt> produkty = new List<Produkt>();

        public Katalog()
        {
            produkty = new List<Produkt>();
        }

        public void Dodaj(Produkt p)
        {
            produkty.Add(p);
        }
        public void Wyswietl()
        {
            Console.WriteLine("Produkty:");
            Console.WriteLine("----------");
            foreach(Produkt p in produkty)
            {
                p.Wyswietl();
                Console.WriteLine("------------");
            }
        }

    }
}
