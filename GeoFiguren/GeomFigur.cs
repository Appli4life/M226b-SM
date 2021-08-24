using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{
    // Abstrakte Klasse, aus der man keine Objekte instanziieren kann. Sie ist nur für die Vererbung da.
    public abstract class GeomFigur
    {
        protected double[] seiten = new double[3];

        protected GeomFigur(double[] s)
        {
            seiten = s;
        }

        public override string ToString()
        {
            string result = "Seitenlängen: ";
            foreach (var d in seiten)
            {
                result = result + " " + d;
            }
            return result;
        }

        public virtual double Umfang()
        {
            double r = 0;
            foreach (var item in seiten)
            {
                r += item;
            }

            return r;
        }
        public virtual double Fläche()
        {
            return 1 + 1;
        }

    }
}
