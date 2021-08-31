namespace T1_Konsole
{
    /// <summary>
    /// Klasse Adresse
    /// </summary>
    public class Adresse
    {
        /// <summary>
        /// Strasse
        /// </summary>
        public string Strasse { get; set; }

        /// <summary>
        /// Hausnummer
        /// </summary>
        public string Hausnr { get; set; }

        /// <summary>
        /// Postleitzahl
        /// </summary>
        public string PLZ { get; set; }

        /// <summary>
        /// Ort
        /// </summary>
        public string Ort { get; set; }

        /// <summary>
        /// Land
        /// </summary>
        public string Land { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="str">Strasse</param>
        /// <param name="hn">Hausnummer</param>
        /// <param name="plz">PLZ</param>
        /// <param name="ort">Ort</param>
        /// <param name="land">Land</param>
        public Adresse(string str, string hn, string plz, string ort, string land)
        {
            Strasse = str;
            Hausnr = hn;
            PLZ = plz;
            Ort = ort;
            Land = land;
        }
    }
}
