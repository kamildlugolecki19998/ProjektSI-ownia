using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    public enum Esposob{Gotowka,
                         Karta
                       }
    class WybierzSposob
    {
        public IMetodaPlatnosci MetodaPlatnosci(Esposob s, Karnet k)
        {
            IMetodaPlatnosci metoda = null;
            switch (s)
            {
                case Esposob.Gotowka:
                    metoda = new PlatonoscGotowka();
                    break;
                case Esposob.Karta:
                    metoda = new PlatnoscKarta();
                    break;
                default:
                    break;
            }
            return metoda;

        }




    }
}
