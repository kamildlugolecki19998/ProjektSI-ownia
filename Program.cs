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

            

            Silownia Fitnes = new Silownia("JustGym");

            Karnet PolRoku = new PolRoku("Karent Półroczny", 550, 180);
            Karnet Jednorazowy = new Jednorazowy("Jednorazowy", 15,1);
            Karnet Open = new Open("OPEN", 120, 30);
            Klient k1 = new Klient("Marek", "Jurek", true);
            Klient k2 = new Klient("Bartek", "Ćwiek");
            Klient k3 = new Klient("Kamil", "Długołęcki", true);
            k1.Zakup(Esposob.Gotowka, Open,Fitnes);
            k2.Zakup(Esposob.Karta, Jednorazowy,Fitnes);
            Fitnes.SprawdzKarnet(k3);
            k3.Zakup(Esposob.Karta, PolRoku, Fitnes);
            Fitnes.SprawdzKarnet(k3);
            Fitnes.SprawdzKarnet(k1);
            
            
            Fitnes.SprawdzKarnet(k2);
            Fitnes.WypiszKlientow();
            k2.Rezygnacja_z_Siłowni(Fitnes);
            Fitnes.WypiszKlientow();
            
           
           
            
           

            
            

           


            
           
           
           
            
            Console.ReadKey();
        }
    }
}
