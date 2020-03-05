using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIListBoxTipusfeladatokVeletlenSzamok.repository
{
    class Adattar
    {
        List<double> adattar;

        public void feltoltesVeletlenValosSzamokkal(int veletlenSzamokSzama)
        {
            Random rnd = new Random();
            for (int i = 0; i < veletlenSzamokSzama; i++)
            {
                adattar.Add((double)rnd.Next(-20000, 20001) / 1000);
            }
        }
    }
}
