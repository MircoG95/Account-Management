using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    class Konto
    {

        private decimal kontostand;

        public void GeldEinzahlen(decimal betrag)
        {
            kontostand = kontostand + betrag;
        }

        public void GeldAuszahlen(decimal betrag)
        {
            kontostand -= betrag;
        }

        public decimal KontostandAnzeigen()
        {
            if (kontostand < 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Account balance: {kontostand:f2}");
            Console.ForegroundColor = ConsoleColor.White;
            return kontostand;
        }
    }
}
