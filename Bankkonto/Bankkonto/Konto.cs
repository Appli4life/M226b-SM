using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    internal class Konto : IBankkonto
    {
        /// <summary>
        /// Privates Feld
        /// </summary>

        private double _bankkonto;

        /// <summary>
        /// Von der Schnittstelle übernohmene Funktion um auf das Feld Bankkonto zugreifen
        /// </summary>
        /// <returns></returns>



        /// <summary>
        /// Ctor
        /// </summary>
        public Konto()
        {

        }

        public double Bankkonto(double a)
        {
            _bankkonto += a;
            return _bankkonto;
        }



        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="a">Für Kontostand</param>

        public Konto(double b)
        {
            _bankkonto = b;
        }
    }
}
