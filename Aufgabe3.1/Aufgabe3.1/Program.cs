using System;

namespace Aufgabe3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var option= OptionAuswählen();
            OptionAuswerten(option);
        }

        private static char OptionAuswählen()
        {
            Console.WriteLine("Wassoll getan werden");
            Console.WriteLine("Geben sie bitte den entsprechenden Buchstaben ein");
            Console.WriteLine("a) alle ganzen Zahlen von 0 bis 99 ausgeben");
            Console.WriteLine("b) alle geraden Zahlen von 0 bis 99 ausgeben");
            Console.WriteLine("c) alle zwischen 0 und 99 ausgeben die sowohl durch 3 als auch durch 5 teilba sind");
            Console.WriteLine("d) alle Primzahlen von 0 bis n ausgeben und zählen");
            Console.WriteLine("e) Konvertierung vom Dezimalsystem in das Dualsystem (nur Zahlen von 0-999)");
            var eingabe =Convert.ToChar(Console.ReadLine().ToLower());
            return (eingabe);
        }

        private static void OptionAuswerten(char option)
        {
            switch (option)
            {
                case 'a':
                    AlleZahlen();
                    break;
                case 'b':
                    GanzeZahlen();
                    break;
                case 'c':
                    DurchDreiUndFünf();
                    break;
                case 'd':
                   var grenze= GrenzeEingeben();
                    PrimzahlenBestimmen(grenze);
                    break;
                case 'e':
                    var eingabe = Eingabeholen();
                    var dualzahl = Zahlensystemkonvertierung(eingabe);
                    Ausgabe(dualzahl);
                    break;
                default: break;

            }
        }
        private static void AlleZahlen()
        {
            // triviale Lösung:
            /*var zahl = 0;
            while (zahl<100)
            {
                Console.WriteLine(zahl);
                zahl++;
            }*/

            //etwas übersichtlichere Ausgabe:
            var zahl = 0;
            while (zahl < 100)
            {
                Console.Write(zahl+ "       ");
                zahl++;
                Console.Write(zahl + "       ");
                zahl++;
                Console.Write(zahl + "       ");
                zahl++;
                Console.Write(zahl + "       ");
                zahl++;
                Console.Write(zahl + "       ");
                zahl++;
                Console.WriteLine();
            }
        }
        private static void GanzeZahlen()
        {
            var zahl = 0;
            while (zahl<100)
            {
                if (zahl % 2 == 0)
                {
                    Console.WriteLine(zahl);
                    zahl = zahl + 2;
                }
            }
        }
        private static void DurchDreiUndFünf()
        {
            var zahl = 0;
            while (zahl < 100)
            {
                if (zahl % 3 == 0 && zahl % 5 == 0)
                {
                    Console.WriteLine(zahl);
                }
                zahl++;
            }
        }

        private static int GrenzeEingeben()
        {
            Console.WriteLine("Geben Sie die obere Grenze an");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void PrimzahlenBestimmen(int grenze)
        {
            var zahl = 0;
            var nummer = 0;
            var teiler = 2;
            var primzahl = true;
            while(zahl<grenze)
            {
                while (teiler<7 && primzahl==true)
                {
                    if (zahl % teiler== 0 && zahl>teiler)
                    {
                        primzahl = false;
                    }
                    else
                    {
                        primzahl = true;
                    }
                    teiler++;
                } 
                if (primzahl==true)
                {
                    Console.WriteLine(zahl);
                    nummer++;
                }
                zahl++;
                teiler = 2;
                primzahl = true;
            }
            Console.WriteLine();
            Console.WriteLine("Anzahl der Primzahlen: {0}", nummer);
        }

        private static int Eingabeholen()
        {
            var prüf = false;
            var eingabe = 0;
            Console.WriteLine("Geben Sie eine Zahl zwischen 0 und 999 ein");
            while( prüf== false)
            {
                eingabe= Convert.ToInt32(Console.ReadLine());
                prüf = EingabePrüfen(eingabe);
            }
            return eingabe;
        }

        private static bool EingabePrüfen(int eingabe)
        {
            if (eingabe >= 0 && eingabe<1000)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
                return false;
            }
        }
        private static string Zahlensystemkonvertierung(int dezimal)
        {
            var dual= Convert.ToString(dezimal, 2);
            return dual;
        }

        private static void Ausgabe (string wert)
        {
            Console.WriteLine(wert);
        }
    }
}
