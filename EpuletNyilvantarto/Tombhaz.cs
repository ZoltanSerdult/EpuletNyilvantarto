using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpuletNyilvantarto
{
    enum Fenntartas
    {
        egyéni,
        szövetkezet,
        társasház
    }
    class Tombhaz : Epulet , CSV , Kalkulal
    {
        readonly int lakasok;
        Fenntartas fenntartasTipus;
        readonly bool vaneLift;

        public int Lakasok => lakasok;

        internal Fenntartas FenntartasTipus { get => fenntartasTipus; set => fenntartasTipus = value; }

        public bool VaneLift => vaneLift;

        public Tombhaz(string cim, Anyagok epitesanyag, int alapterulet, DateTime kezdes, DateTime befejezes, int lakasok, bool vaneLift, Fenntartas fenntartasTipus) : base(cim, epitesanyag, alapterulet, kezdes, befejezes)
        {
            this.lakasok = lakasok;
            this.vaneLift = vaneLift;
            FenntartasTipus = fenntartasTipus;
        }

        public string Kiir()
        {
            return string.Join(";", "tomb", Cim, Alapterulet, Epitesanyag, Kezdes.ToString("yyyy,MM,dd"), Befejezes.ToString("yyyy,MM,dd"), lakasok ,vaneLift, fenntartasTipus);
        }

        public int kalkulator()
        {
            return Alapterulet * lakasok * 8000 + (vaneLift?100000:0);
        }
    }
}
