using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_silownia
{
    interface IObserwowany
    {
        void Rejestracja_na_Silowni(IObserwujacy obserwujacy);
        void Rezygnacja_z_Siłowni(IObserwujacy obserwujacy);
        string Imie();
        bool CzyMaKarnet();


    }
}
