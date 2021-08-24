using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace GeoFiguren
{

    class Program
    {
        static void Main(string[] args)
        {
            List < GeomFigur > geomfiguren = new List<GeomFigur>();

            Rechteck r = new Rechteck(new double[] { 10.0, 20.0 });
            //Console.WriteLine($"Rechteckfläche: {r.RechteckFläche()}");
            //Console.WriteLine(r);
            geomfiguren.Add(r);

            Dreieck d = new Dreieck(new double[] { 10.0, 20.0, 30.0 });
            //Console.WriteLine($"Dreieckumfang: {d.Umfang()}");
            //Console.WriteLine(d);
            geomfiguren.Add(d);

            Quadrat q = new Quadrat(new double[] { 10.0 });
            //Console.WriteLine($"Quadratfläche: {q.QuadratFläche()}");
            //Console.WriteLine(q);
            geomfiguren.Add(q);

            foreach (var geofig in geomfiguren)
            {
                Console.WriteLine(geofig);
                Console.WriteLine($"Umfang = {geofig.Umfang()}");
                Console.WriteLine($"Fläche = {geofig.Fläche()}");
            }
            

            Console.ReadLine();
        }
    }
}
