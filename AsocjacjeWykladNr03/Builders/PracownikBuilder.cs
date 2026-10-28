using AsocjacjeWykladNr03.Models;

namespace AsocjacjeWykladNr03.Builders
{
    public class PracownikBuilder
    {
        private readonly Pracownik _root = new Pracownik();

        private PracownikBuilder()
        {
            
        }

        public PracownikBuilder SetId(string id)
        {
            _root.Id = id;
            return this;
        }

        public PracownikBuilder SetName(string name)
        {
            _root.Nazwa = name;
            return this;
        }

        //todo: dodać dla pozostałych

        public Pracownik Build() {
            // opcjonalnie nowy obiekt root, ale pole nie może mieć wtedy readonly
            // var newObject = _root;
            // _root = new Pracownik();
            return _root;
        }

        //property
        public Pracownik BuildP => _root;
        


        public static PracownikBuilder Create()
        {
            return new PracownikBuilder();
        }
        public static PracownikBuilder CreateA() => new PracownikBuilder();

        //property
        public static PracownikBuilder CreateP => new PracownikBuilder();

    }
}