using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Klient :Osoba
        
    {
        
        public Karnet Karnet;
        int NrKlienta;
        protected double StanKonta;
        
        
       
        public Klient(string imie,string nazwisko,int NrKlienta,double StanKonta, Karnet karnet) :base(imie, nazwisko)
        {
            this.NrKlienta = NrKlienta;
            this.StanKonta = StanKonta;
            this.Karnet = karnet;
            
        }
        

        

    }
}
