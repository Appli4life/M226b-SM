using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaalplanSD
{
    public class Platz
    {
        public Platz()
        {
            Bestellung aBestellung = new Bestellung();
            aBestellung.kaufen(this);
        }
        public void bestätigen(bool)
        {

        }

    }
}
