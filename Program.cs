using System;

namespace Kontoverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k1 = new Konto();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Account management:\n----------------");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1) Deposit money");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2) Cash out money");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("3) Check account balance");
                Console.WriteLine("4) Quit");
                Console.Write("Please select: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {

                    Console.WriteLine("Deposit money, what amount?");
                    decimal betrag = Convert.ToDecimal(Console.ReadLine());
                    k1.GeldEinzahlen(betrag);
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Paying out money, what amount? ");
                    decimal betrag = Convert.ToDecimal(Console.ReadLine());
                    k1.GeldAuszahlen(betrag);
                }
                else if (eingabe == "3")
                {
                    k1.KontostandAnzeigen();
                    Console.WriteLine("Please press button ...");
                    Console.ReadKey();
                }
                else if (eingabe == "4")
                {
                    return;
                }else
                {
                    Console.WriteLine("Incorrect input");
                }
            } while (true);
            

        }
    }


}
