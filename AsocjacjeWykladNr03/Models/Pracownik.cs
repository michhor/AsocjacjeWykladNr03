namespace AsocjacjeWykladNr03.Models
{
    public class Pracownik : Uzytkownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public Adres AdresP { get; set; }
    }
}