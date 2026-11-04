using System;

namespace AsocjacjeWykladNr03.Models
{
    public class Obserwator
    {
        public virtual string TypeName => "Obserwator";     
        public string Id { get; set; }

        public Obserwator()
        {
            
        }

        public Obserwator(string id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return String.Format("{1}:\nID={0}", Id, TypeName);
        }

    }
}