using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Kosmetyki : ProduktyMarkowe
    {
        public enum RodzajKosmetykow { Perfum, Dezodorant, Krem, Szampon, Odzywka }

        public RodzajKosmetykow Typ { get; set; }

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Typ(0-Perfum, 1-Dezodorant, 2-Krem, 3-Szampon, 4-Odżywka)=");
            Typ = (RodzajKosmetykow)int.Parse(Console.ReadLine());  
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.Write($"Typ {Typ:}.");
        }
    }
}
