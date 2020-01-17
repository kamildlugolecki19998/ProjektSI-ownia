using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    abstract class Karnet 
    {
        public string Nazwa;
        public double Cena;
        
        public int OkresWaznosci;

        public Karnet(string nazwa,double cena, int okreswaznosci)
        {
            Nazwa = nazwa;
            Cena = cena;
            OkresWaznosci = okreswaznosci;

        }

       
    }
}
