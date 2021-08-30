using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto markus = new Konto(5000);
            Console.WriteLine("Willkomen bei der PflugerBank");


            Console.WriteLine("Was möchten sie tun geben sie 1 an um einzuzahlen, 2 um auszuzahlen 3 um zu beenden!");
        Nochmals:

            try
            {

                switch (Convert.ToInt32(Console.ReadLine()))
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Geben sie ein wie viel sie einzahlen möchten");
                        markus.Bankkonto(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(markus.Bankkonto(0));
                        break;
                    case 2:
                        Console.WriteLine("Geben sie ein wie viel sie auszahlen möchten");
                        markus.Bankkonto(- Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine(markus.Bankkonto(0));
                        break;
                    case 3:
                        goto Stop;
                    default:
                        Console.WriteLine("Bitte geben sie eine gültige Zahl zwischen 1 - 3 ein!");
                        goto Nochmals;
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Bitte geben sie Korrekte Daten ein!");
                goto Nochmals;

            }
            catch(Exception ex)
            {

            }



        Stop:
            Console.WriteLine("Drücken sie eine Taste zum Beenden");
            Console.ReadKey();
        }
    }
}
