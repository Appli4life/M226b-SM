using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaalplanSD
{
    public class Verkauf
    {
        public void buchen(Platz p)
        {
            Bestellung aBestellung = new Bestellung();
            aBestellung.erstelleRechnung(p);
        }

    }
}
