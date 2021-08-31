using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaalplanSD
{
    public class Bestellung
    {
        public void kaufen(Platz p)
        {
            Saalplan aSaalplan = new Saalplan();
            aSaalplan.IstFrei(p);
        }

        public void erstelleRechnung(Platz p)
        {
            p.bestätigen(true);
        }
    }
}
