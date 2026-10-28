namespace AsocjacjeWykladNr03.Models
{
    public class Uzytkownik : Obserwator
    {
        public string Nazwa { get; set; }
        public string AdresEmail { get; set; }
        public string HashHasla { get; set; }
    }
}