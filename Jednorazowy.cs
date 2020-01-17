using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Jednorazowy : Karnet
    {
        
        public Jednorazowy(string nazwa,double cena , int okreswaznosci) : base(nazwa,cena, okreswaznosci)
        {
        }
    }
}
