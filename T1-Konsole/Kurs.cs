using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Konsole
{
    /// <summary>
    /// Klasse Kurs
    /// </summary>
    public class Kurs
    {
        /// <summary>
        /// Name des Kurs
        /// </summary>
        public string Kursname { get; set; }

        /// <summary>
        /// ID des Kurs
        /// </summary>
        public string Identifikationsnummer { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="id">Identifikationsnummer</param>
        public Kurs(string id)
        {
            Identifikationsnummer = id;
        }

    }
}
