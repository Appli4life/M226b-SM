using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguren
{

    class Program
    {
        static void Main(string[] args)
        {
            Rechteck r = new Rechteck(new double[] { 10.0, 20.0 });
            Console.WriteLine($"Rechteckfläche={r.RechteckFläche()}");
            Console.WriteLine(r.informationen());

            Dreieck d = new Dreieck(new double[] { 10.0, 20.0, 30.0 });
            Console.WriteLine($"Dreieckumfang={d.Umfang()}");
            Console.WriteLine(d.informationen());

            Quadrat q = new Quadrat(new double[] { 10.0});
            Console.WriteLine($"Quadratfläche={q.QuadratFläche()}");
            Console.WriteLine(q.informationen());

            Console.ReadKey();
        }
    }
}
