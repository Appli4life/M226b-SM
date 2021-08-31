using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarenkorbSD
{
    public class Warenkorb
    {
        public List<Artikel> liste = new List<Artikel>();
        public Bestellung b = new Bestellung();

        public int gesamtzahl = 0;

        public double ZurKasse()
        {
            
            
            foreach (var item in liste)
            {
                gesamtzahl =  b.Artikelhinzufügen(item, 5);
            }

            b.BerechneRabatt();
           return b.SchliesseVerkauf();
        }

        public Warenkorb(Artikel a)
        {
            this.liste.Add(a);
        }
    }
}
