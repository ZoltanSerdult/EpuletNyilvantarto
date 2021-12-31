using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpuletNyilvantarto
{
    enum TetoTipusa
    {
        cserép,
        zsindely,
        nád
    }
    class Csaladihaz : Epulet , CSV , Kalkulal
    {
        int ottelok;
        bool vanGarazs;
        TetoTipusa tetoanyag;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool VanGarazs { get => vanGarazs; set => vanGarazs = value; }
        internal TetoTipusa Tetoanyag { get => tetoanyag; set => tetoanyag = value; }

        public Csaladihaz(string cim, Anyagok epitesanyag, int alapterulet, DateTime kezdes, DateTime befejezes, int ottelok, bool vanGarazs, TetoTipusa tetoanyag) :base(cim, epitesanyag, alapterulet, kezdes, befejezes)
        {
            Ottelok = ottelok;
            VanGarazs = vanGarazs;
            Tetoanyag = tetoanyag;
        }
        public override string ToString()
        {
            return "Cím: "+Cim + " Alapterülete: " + Alapterulet + " NM. " + Epitesanyag +" Munka kezdése: " + Kezdes.ToString("yyyy,M,d") + " Munka vége: " + Befejezes.ToString("yyyy,M,d") + "Ott élök száma - "+Ottelok +"Van-e garázs - "+ vanGarazs +" Tetötipusa - "+ tetoanyag; 
        }

        public string Kiir()
        {
            return string.Join(";","csaladi", Cim, Alapterulet, Epitesanyag, Kezdes.ToString("yyyy,MM,dd"), Befejezes.ToString("yyyy,MM,dd"), Ottelok, VanGarazs, Tetoanyag);
        }

        public int kalkulator()
        {
            return Alapterulet * ottelok * 10000;
        }
    }
}
