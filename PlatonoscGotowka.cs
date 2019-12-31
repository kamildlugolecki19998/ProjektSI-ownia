using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class PlatonoscGotowka : IMetodaPlatnosci
    {
        public void Sposob(Karnet karnet, Klient klient)
        {
            double znizka = 0.7;
            if (klient.CzyStudent == false)
            {
                Console.WriteLine($"Wybrałeś karnet {karnet.Nazwa} sposób płatności gotówka, cena karnetu: {karnet.Cena}zł");
            }
            else
            {
                Console.WriteLine($"Wybrałeś karnet {karnet.Nazwa} sposób płatności gotówka, cena karnetu: {karnet.Cena * znizka}zł");
            }
            
        }
    }
}
