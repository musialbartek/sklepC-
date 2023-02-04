using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Napoje : Produkt
    {
        public double Pojemność { get; set; } //pojemnosc ml

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Pojemność=");
            Pojemność = double.Parse(Console.ReadLine());
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.Write($"Pojemność {Pojemność}ml.");
        }
    }
}
