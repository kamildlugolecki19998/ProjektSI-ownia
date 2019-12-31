using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Klient :Osoba
        
    {
       
       
        int NrKlienta;
        public decimal StanKonta;
       public bool CzyStudent = false;




        public Klient(string imie, string nazwisko, int NrKlienta, decimal StanKonta) :base(imie, nazwisko)
        {
            this.NrKlienta = NrKlienta;
            this.StanKonta = StanKonta;
            
            
        }
        public Klient(string imie, string nazwisko, int NrKlienta, decimal StanKonta, bool czystudent) : base(imie, nazwisko)

        {
            this.NrKlienta = NrKlienta;
            this.StanKonta = StanKonta;
            CzyStudent = czystudent;
        }

        IMetodaPlatnosci metoda = null;
        public void Zakup(Esposob s, Karnet k)
        {
            WybierzSposob wb = new WybierzSposob();
            this.metoda = wb.MetodaPlatnosci(s, k);
            this.metoda.Sposob(k,klient:this);
                
        }

    }
}
