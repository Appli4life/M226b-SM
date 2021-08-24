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

        public double QuadratFläche()
        {
            return base.Multiplikation(base.seiten[0], base.seiten[0]);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
