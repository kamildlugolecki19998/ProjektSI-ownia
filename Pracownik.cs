using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Pracownik:Osoba
    {
        public int NrPracownika;
        public Pracownik(string imie,string nazwisko,int NrPracownika) :base(imie,nazwisko)
        {
            this.NrPracownika = NrPracownika;
        }
    }
}
