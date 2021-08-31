using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarenkorbSD
{
    public class Artikel
    {
        public string Name { get; set; }

        public double preis = 23.2;

        public Artikel(string n)
        {
           Name = n;
        }
    }
  
}
