using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarenkorbSD
{
    public class Bestellung
    {
        public double gesamtpreis = 0.0;
        public List<Artikel> liste = new List<Artikel>();

        public int Artikelhinzufügen(Artikel artikel, int menge)
        {
            liste.Add(artikel);

            return liste.Count();
        }

        public void BerechneRabatt()
        {
            foreach (var item in this.liste)
            {
                item.preis -= 2;
            }
        }

        public double SchliesseVerkauf()
        {
            double summe = 0.0;
            foreach (var item in this.liste)
            {
                summe += item.preis;
            }

            return summe;
        }

        public string Bezahle()
        {
            Zahlung z = new Zahlung();
            string ergebnis = z.Return();

            return ergebnis;
        }
    }
}
