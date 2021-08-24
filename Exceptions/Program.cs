using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int zahl = 0;
                int zahl2 = 0;
                Console.Write("Bitte eine Zahl eingeben: ");

                try
                {
                    zahl = Convert.ToInt32(Console.ReadLine());

                    if(zahl == 13)
                    {
                        throw new Exception("Bitte nicht 13!");
                    }

                    zahl2 = 200 / zahl;

                    Console.WriteLine($"Zahl: {zahl}, Zahl2: {zahl2}");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine($"Fehler: Falscher Datentyp!");

                }
                catch(OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Fehler: Zu Lange oder zu kurze Zahl!");
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine($"Fehler: {e.Message}");
                }
                Console.WriteLine();


            } while (true);
        }
    }
}
