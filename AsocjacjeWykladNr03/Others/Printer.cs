using System;
using AsocjacjeWykladNr03.Interfaces;

namespace AsocjacjeWykladNr03.Others
{
    public class Printer: IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}