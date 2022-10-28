﻿using AsocjacjeWykladNr03.Interfaces;
using AsocjacjeWykladNr03.Models;
using AsocjacjeWykladNr03.Others;
using AsocjacjeWykladNr03.Tools;
using System.Collections.Generic;

namespace AsocjacjeWykladNr03.Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uzytkownik uzytkowniStandard = new Uzytkownik(0,"ninja","ninjna@gmail.com","13451561313451fwef24r");

            Uzytkownik uzytkownikInit = new Uzytkownik()
            {
                Id = 1,
                AdresEmail = "innyninja@gmail.com",
                HashHasla = "43g24tg2be4t",
                Nazwa = "ninjaLepszy"
            };

            //wersja z inicjalizatorem
            Pracownik pracownik = new Pracownik()
            {
                Id = 1,
                AdresEmail = "innyninja@gmail.com",
                HashHasla = "43g24tg2be4t",
                Nazwa = "ninjaLepszy",
                AdresP = new Adres()
                {
                    Tekst = "Konstantynów 1 H"
                },
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Pesel = "123456789"
            };

            //za pomocą builder
            PracownikBuilder pracownikBuilder = new PracownikBuilder();
            Pracownik pracownikZbudowany = pracownikBuilder
                .SetId(2)
                .SetName("lis")
                //todo: dodać pozostałe
                .Build();

            Pracownik pracownikNajlepszy = new PracownikBuilder()
                .SetId(3)
                .SetName("dzik")
                //todo: dodać pozostałe
                .Build();



            List<IPrint> textDistributor = new List<IPrint>();
            string wiadomosc = "7:30, prawdziwe dotnetowe treści!";
            textDistributor.Add(new Printer());
            textDistributor.Add(new Kindle());

            foreach (var print in textDistributor)
            {
                print.Print(wiadomosc);
            }
        }
    }
}
