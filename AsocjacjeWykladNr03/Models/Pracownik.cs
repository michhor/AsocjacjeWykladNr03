using System;

namespace AsocjacjeWykladNr03.Models
{
    public class Pracownik : Uzytkownik
    {
        public override string TypeName => nameof(Pracownik);
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public Adres AdresP { get; set; }

        public override string ToString()
        {
            return String.Format("{2},\nImie={0},\nNazwisko={1}",
                Imie, Nazwisko, base.ToString());
        }

    }
}