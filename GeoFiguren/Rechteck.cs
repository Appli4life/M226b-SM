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
        protected double Multiplikation(double a, double b)
        {
            return a * b;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override double Umfang()
        {
            double a = seiten.Sum();
            return a * 2;
        }

        public override double Fläche()
        {
            return seiten[0] * seiten[1];
        }
    }
}
