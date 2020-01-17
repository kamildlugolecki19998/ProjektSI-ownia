using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class Klient : AOsoba, IObserwowany
        
    {
       
       
        
        
       public bool CzyStudent = false;
       public bool CzyKarnet = false;
       Silownia silownia;



        public Klient(string imie, string nazwisko) :base(imie, nazwisko)
        {
           
          
            
            
        }
        public Klient(string imie, string nazwisko,  bool czystudent) : base(imie, nazwisko)

        {
           
           
            CzyStudent = czystudent;

        }
        

        IMetodaPlatnosci metoda = null;
        public void Zakup(Esposob s, Karnet k, IObserwujacy obserwujacy)
        {
            WybierzSposob wb = new WybierzSposob();
            this.metoda = wb.MetodaPlatnosci(s, k);
            this.metoda.Sposob(k,klient : this);
            this.CzyKarnet = true;
            Rejestracja_na_Silowni(obserwujacy);

            


        }
        

       

      
        public bool CzyMaKarnet()
        {
            return this.CzyKarnet;
        }

        public void Rejestracja_na_Silowni(IObserwujacy obserwujacy)
        {
            
            
            
            Console.WriteLine($"{imie} zacząłeś chodzic na silownie");
            obserwujacy.CzyMaKarnet(obserwowany: this);
        }
        public void Rezygnacja_z_Siłowni(IObserwujacy obserwujacy)
        {
                this.CzyKarnet = false;
                Console.WriteLine($"{imie} zrezygnowłeś z siłowni");
                obserwujacy.CzyMaKarnet(obserwowany: this);


            
            
           
        }
        public void NotifyObservators(IObserwujacy obserwujacy)
        {
            
        }

        

        string IObserwowany.Imie()
        {
            return imie;
        }
    }
}
