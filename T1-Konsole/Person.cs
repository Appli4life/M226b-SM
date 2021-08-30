using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_Konsole
{
    /// <summary>
    /// Abstrakte Klasse Person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Adresse der Person
        /// </summary>
        public Adresse wohnt { get; set; }

        /// <summary>
        /// Name der Person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Email Adresse der Person
        /// </summary>
        public string Email_Adresse { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="email">Eamil</param>
        /// <param name="adresse">Adresse</param>
        public Person(string name, string email, Adresse adresse)
        {
            wohnt = adresse;
            Name = name;
            Email_Adresse = email;
        }

      
    }
}
