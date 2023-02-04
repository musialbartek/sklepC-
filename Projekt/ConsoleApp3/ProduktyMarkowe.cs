using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ProduktyMarkowe : Produkt
    {
        public string Marka { get; set; } //marka

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Marka=");
            Marka = Console.ReadLine();
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.Write($"Marka {Marka}.");
        }
    }
}
