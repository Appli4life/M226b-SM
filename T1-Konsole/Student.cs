using System.Collections.Generic;

namespace T1_Konsole
{
    /// <summary>
    /// Klasse Student
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Legi NR
        /// </summary>
        public string Legi_Nummer { get; set; }

        /// <summary>
        /// Studiensemester
        /// </summary>
        public int Studiensemester { get; set; }


        /// <summary>
        /// Kurse
        /// </summary>
        public List<Kurs> besucht = new List<Kurs>();

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Email</param>
        /// <param name="Leginr">Legi Nr</param>
        /// <param name="adresse">Adresse</param>
        /// <param name="studiensemester">Studiensemester</param>
        public Student(string name, string email, string Leginr, Adresse adresse, int studiensemester)
            :base(name,email,adresse)
        {
            Legi_Nummer = Leginr;
            Studiensemester = studiensemester;
        }

        /// <summary>
        /// Override
        /// </summary>
        /// <returns>Infos</returns>
        public override string ToString()
        {
            return $"{Name},{Email_Adresse},{besucht[0].Kursname}, {Studiensemester}, {base.wohnt.PLZ}, {base.wohnt.Land}";
        }
    }
}
