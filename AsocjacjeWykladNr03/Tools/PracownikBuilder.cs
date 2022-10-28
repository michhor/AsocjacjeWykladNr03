using AsocjacjeWykladNr03.Models;

namespace AsocjacjeWykladNr03.Tools
{
    public class PracownikBuilder
    {
        protected readonly Pracownik root = new Pracownik();

        public PracownikBuilder SetId(int i)
        {
            root.Id = i;
            return this;
        }

        public PracownikBuilder SetName(string name)
        {
            root.Nazwa = name;
            return this;
        }
        //todo: dodać pozostałe metody

        public Pracownik Build()
        {
            return root;
        }
    }
}