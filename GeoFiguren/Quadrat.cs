using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    public class Quadrat :Rechteck
    {
        public Quadrat(double[]s)
            :base(s)
        {

        }

        public double QuadratFläche()
        {
            return base.Multiplikation(base.seiten[0], base.seiten[0]);
        }
    }
}
