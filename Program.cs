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

            

            Pracownik p1 = new Pracownik("Marek", "Nowak", 1);
            Klient k1 = new Klient("Marek", "Jurek",12,1200,true);
            Karnet open = new Karnet("OPEN", 120, 30);
            k1.Zakup(Esposob.Gotowka, open);
            

           


            
           
           
           
            
            Console.ReadKey();
        }
    }
}
