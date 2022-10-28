using AsocjacjeWykladNr03.Interfaces;
using System;
using System.IO;

namespace AsocjacjeWykladNr03.Others
{
    public class Kindle: IPrint
    {
        public void Print(string author)
        {
            Console.WriteLine("Podaj nazwe pliku do wczytania");
            string fileName = Console.ReadLine();
            try
            {
                Console.WriteLine(File.ReadAllText(fileName));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd drukowania!{ex}");
            }

            Console.WriteLine($"Autor {author}");
            
        }
    }
}