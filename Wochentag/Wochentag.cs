using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wochentag
{
    /// <summary>
    /// Wochentag Klasse
    /// </summary>
    public class Wochentag
    {
        /// <summary>
        /// Tag
        /// </summary>
        private int _t;
        public int T
        {
            get { return _t; }
            set { _t = value; }
        }

        /// <summary>
        /// Monat
        /// </summary>
        private int _m;
        public int M
        {
            get { return _m; }
            set { _m = value; }
        }

        /// <summary>
        /// Jahr
        /// </summary>
        private int _j;
        public int J
        {
            get { return _j; }
            set { _j = value; }
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public Wochentag()
        {

        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="t">Tag</param>
        /// <param name="m">Monat</param>
        /// <param name="j">Jahr</param>
        public Wochentag(int t, int m, int j)
        {
            _j = j;
            _m = m;
            _t = t;
        }

        /// <summary>
        /// Wochentag ausrechnen
        /// </summary>
        /// <returns>Den Wochentag des Datums</returns>
        public string GibWochenTag()
        {
            
            DateTime dv = new DateTime(_j, _m, _t);

            return dv.ToString("dddd");
         

        }
    }
}
