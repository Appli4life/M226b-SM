using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    public class Quadrat : Rechteck
    {
        // Ctor der den Array zu der Basisklasse Rechteck weitergibt, welche wiederrum das Array an seine Basisklasse GeomFigur weitergibt
        public Quadrat(double[] s)
            : base(s)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override double Umfang()
        {
            return seiten[0] * 4;
        }
        public override double Fläche()
        {
            return Math.Pow(seiten[0], 2);
        }
    }
}
