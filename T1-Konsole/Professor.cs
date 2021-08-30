using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Konsole
{
    /// <summary>
    /// Klasse Professor
    /// </summary>
    public class Professor : Person
    {
        /// <summary>
        /// AHV Nummer
        /// </summary>
        public string AHV_Nummer { get; set; }

        /// <summary>
        /// Salär
        /// </summary>
        public double Salär { get; set; }

        /// <summary>
        /// Kurse
        /// </summary>
        public List<Kurs> betruet = new List<Kurs>();

       /// <summary>
       /// Ctor
       /// </summary>
       /// <param name="name">Name</param>
       /// <param name="email">Email</param>
       /// <param name="salär">Salär</param>
       /// <param name="AHVnr">AHV</param>
       /// <param name="adresse">Adresse</param>
       /// <param name="k">Kurs</param>
        public Professor(string name, string email, double salär, string AHVnr, Adresse adresse, Kurs k)
            :base(name,email,adresse)
        {
            AHV_Nummer = AHVnr;
            Salär = salär;
            betruet.Add(k);
        }

        /// <summary>
        /// Override
        /// </summary>
        /// <returns>Infos</returns>
        public override string ToString()
        {
            return $"{Name},{Email_Adresse},{betruet[0].Kursname}, {AHV_Nummer}, {base.wohnt.PLZ}, {base.wohnt.Land}";
        }
    }
}
