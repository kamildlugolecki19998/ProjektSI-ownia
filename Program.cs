using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Program
    {
        static void Main(string[] args)
        {
            Silownia Silownia = new Silownia();
            Karnet Open = new Karnet(Typ.Open);
            Karnet Brak = new Karnet(Typ.brak);
            Karnet Pol_Roku = new Karnet(Typ.PolRoku);
            Karnet Jednorazowy = new Karnet(Typ.Jednorazowy);
            Pracownik p1 = new Pracownik("Marek", "Nowak", 1);
            Klient k2 = new Klient("Kamil", "Kowalski", 123, 2000.00, Open);
            
            Console.WriteLine(k2.Karnet.Rodzaj);
            Console.Write(k2.Karnet.Cena);
            Console.WriteLine();
            p1.Sprawdz_Czy_Klient_Posiada_Karnet(k2);
            Console.ReadKey();
        }
    }
}
