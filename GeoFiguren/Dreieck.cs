using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    public class Dreieck : GeomFigur
    {
        public Dreieck(double[] s)
            : base(s)
        {

        }


        public override string ToString()
        {
            return base.ToString();
        }
        public override double Fläche()
        {
          return (seiten[0] *  Math.Sqrt((seiten[0] * seiten[0]) + (seiten[1]*seiten[1]))) / 2;
        }
    }
}
