using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaalplanSD
{
    public class Saalplan
    {
        public bool IstFrei(Platz p )
        {
            this.reservieren(p);
            Verkauf aVerkauf = new Verkauf();
            aVerkauf.buchen(p);
            return true;
        }

        public void reservieren(Platz p)
        {

        }

    }
}
