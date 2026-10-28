using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsocjacjeWykladNr03.Builders;
using AsocjacjeWykladNr03.Models;

namespace AsocjacjeWykladNr03.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Obserwator obSimple = new Obserwator("C26740D8-8525-4473-9DBF-B46C2D6C69B2");

            Uzytkownik uzytkownikSimple = new Uzytkownik
            {
                Id = "C26740D8-8525-4473-9DBF-B46C2D6C69B3",
                Nazwa = "Kowalski",
                AdresEmail = "kowalski11123221@wp.pl",
                HashHasla = "vfqe1vx3g435g234btv43tb24tb24tb2"
            };

            //przy pomocy buildera i metod
            Pracownik newModernWorker = PracownikBuilder.Create()
                .SetId("2342134")
                .SetName("Kowalski")
                // itd....
                .Build();

            //przy pomocy builder i właściwości
            Pracownik newModernPropertyWorker = PracownikBuilder.CreateP
                .SetId("35r14t234f32")
                .SetName("Kowalski-Nowak")
                // itd....
                .BuildP;

        }
    }
}
