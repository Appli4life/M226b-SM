using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    public class Rechteck : GeomFigur
    {
        public Rechteck(double[] s)
            :base(s)
        {

        }

        public double RechteckFläche()
        {
            return this.Multiplikation(base.seiten[0], base.seiten[1]);
        }

        protected double Multiplikation(double a, double b)
        {
            return a * b;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
