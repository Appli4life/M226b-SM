using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    public abstract class GeomFigur
    {
        protected double[] seiten = new double[3];

        protected GeomFigur(double[] s)
        {
            seiten = s;
        }

        public string informationen()
        {
            string result = "Seitenlängen: ";
            foreach (var d in seiten)
            {
                result = result + " " + d;
            }
            return result;
        }
    }
}
