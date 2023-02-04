using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Żywność : Produkt
    {
        public double Waga { get; set; } //waga kg

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Waga=");
            Waga = double.Parse(Console.ReadLine());
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.Write($"Waga {Waga}kg.");
        }
    }
}
