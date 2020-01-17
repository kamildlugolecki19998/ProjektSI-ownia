using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Silownia :  IObserwujacy
    {




        public string nazwa;
        List<IObserwowany> Klienci = new List<IObserwowany>();

        public Silownia(string nazwa)
        {
            this.nazwa = nazwa;
        }
        

        public void CzyMaKarnet(IObserwowany obserwowany)
        {
            if (obserwowany.CzyMaKarnet())
            {
                Klienci.Add(obserwowany);
            }
            else
            {
                Klienci.Remove(obserwowany);
            }
        }

        

        public void SprawdzKarnet(IObserwowany obserwowany)
        {
            
            
            if (!Klienci.Contains(obserwowany))
            {
                Console.WriteLine($"{obserwowany.Imie()} Nie posiadasz karnetu zapraszamy do zakupu");
                
               

            }
            else
            {
                Console.WriteLine($"Miełgo treningu {obserwowany.Imie()}");
                
                
            }

         }
       public void WypiszKlientow()
        {
            Console.WriteLine($"Liata klientów Siłowni {nazwa}");
            foreach (var item in Klienci)
            {
                Console.WriteLine(item.Imie());
            }
        }
          
        


    }
}
