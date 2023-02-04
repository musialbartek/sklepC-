using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Elektronika : ProduktyMarkowe
    {
        public double Moc { get; set; } //kw

        public override void Czytaj()
        {
            base.Czytaj();
            Console.Write("Moc=");
            Moc = double.Parse(Console.ReadLine());
        }

        public override void Wyswietl()
        {
            base.Wyswietl();
            Console.Write($"Moc {Moc}kw.");
        }
    }
}
