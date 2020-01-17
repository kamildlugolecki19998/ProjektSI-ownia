using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
   abstract class AOsoba
       
    {
        public string imie;
       public string nazwisko;
       protected AOsoba(string imie,string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
}
