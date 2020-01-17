using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    class PlatnoscKarta : IMetodaPlatnosci
    {
        public void Sposob(Karnet karnet, Klient klient)
        {
            double znizka = 0.7;
            if (klient.CzyStudent==false)
            {
                Console.WriteLine($"{klient.imie} wybrałeś karent {karnet.Nazwa}, cena karnetu: {karnet.Cena}zł Proszę zbliżyć kartę to terminala");
            }
            else
            {
                Console.WriteLine($"{klient.imie} wybrałeś karent {karnet.Nazwa}, cena karnetu: {karnet.Cena*znizka}zł Proszę zbliżyć kartę to terminala");
            }
            
        }
    }
}
