using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarenkorbSD
{
    public class Kunde
    {
        public double summe = 0.0;
        public Warenkorb wk = new Warenkorb(new Artikel("Schokolade"));

        public Kunde()
        {

            summe = wk.ZurKasse();

           
           
        }

    }
}
