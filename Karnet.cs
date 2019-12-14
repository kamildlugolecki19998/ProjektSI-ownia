using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    public enum Typ{ Open, Jednorazowy, PolRoku, brak};

    class Karnet 

    {
        
        public double Cena;
        public int Okres_waznosci;
        public Typ Rodzaj;
       // public string nrKarnteu;


        public Karnet(Typ rodzaj) 
        {
            
          
            Rodzaj = rodzaj;
            OkreslCene();

        }
       private void OkreslCene()
        {
            if ( Rodzaj is Typ.Open)
            {
                Cena = 120;
                Okres_waznosci = 30;

            }
            else if (Rodzaj is Typ.Jednorazowy)
            {
                Cena = 20;
                Okres_waznosci = 1;

            }
            else if (Rodzaj is Typ.PolRoku)
            {
                Cena = 640;
                Okres_waznosci = 180;
            }
            else
            {
               
            }
            
        }
    }
}
