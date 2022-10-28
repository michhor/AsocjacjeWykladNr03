namespace AsocjacjeWykladNr03.Models
{
    public class Obserwator
    {
        public int Id { get; set; }

        public Obserwator()
        {
            
        }

        public Obserwator(int id)
        {
            Id = id;
        }
    }

    public class Uzytkownik : Obserwator
    {
        public string Nazwa { get; set; }
        public string AdresEmail { get; set; }
        public string HashHasla { get; set; }

        public Uzytkownik()
        {
            
        }
        public Uzytkownik(int id, string nazwa,string adres,string hash):base(id)
        {
            Nazwa = nazwa;
            AdresEmail = adres;
            HashHasla = hash;
        }
    }

    public class Pracownik : Uzytkownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public Adres AdresP { get; set; }
        //nie ma sensu pisać konstruktora z parametrami
    }


}