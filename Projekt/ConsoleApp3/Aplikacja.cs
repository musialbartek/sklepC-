using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Aplikacja
    {
        Katalog k = new Katalog();
        public void Dodaj()
        {
            Produkt p = null;
            Console.WriteLine("(0-Żywność, 1-Napoje, 2-Elektronika, 3-Kosmetyki)");

            int wybor = int.Parse(Console.ReadLine());
            switch(wybor)
            {
                case 0: p = new Żywność(); break;
                case 1: p = new Napoje(); break;
                case 2: p = new Elektronika(); break;
                case 3: p = new Kosmetyki(); break;
            }
            if(p != null)
            {
                p.Czytaj();
                k.Dodaj(p);
            }
        }

        public void Wyswietl()
        {

            k.Wyswietl();

        }

        public void Menu()
        {
            bool koniec = false;

            while(!koniec)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("--------");
                Console.WriteLine("1. Dodaj");
                Console.WriteLine("2. Wyświetl");
                Console.WriteLine("0. Koniec");
                Console.WriteLine();

                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                int wybor = int.Parse(Console.ReadLine());
                switch (wybor)
                {
                    case 1: Dodaj(); break; 
                    case 2: Wyswietl(); break;
                    case 0: koniec = true; break;
                }
            }
        }

    }
}
