using System;

namespace AsocjacjeWykladNr03.Models
{
    public class Uzytkownik : Obserwator
    {
        public override string TypeName => "Uzytkownik";
        public string Nazwa { get; set; }
        public string AdresEmail { get; set; }
        public string HashHasla { get; set; }
        public override string ToString()
        {
            return String.Format("{2},\nNAZWA={0},\nEMAIL={1}",
                Nazwa, AdresEmail,base.ToString());
        }

    }
}