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

            Pracownik p1 = new Pracownik("Marek", "Nowak", 1);
            Klient k2 = new Klient("Kamil", "Kowalski", 123, 2000.00, Karnet.Jednorazowy);
            

        }
    }
}
