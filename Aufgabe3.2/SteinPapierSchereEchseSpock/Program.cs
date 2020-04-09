using System;

namespace SteinPapierSchereEchseSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            var eingabe = EingabeHolen();
            var pcwahl = PCWahl();
            var sieger = SiegerBestimmen(eingabe, pcwahl);
            Ausgabe(sieger);
        }
        private static int EingabeHolen()
        {
            Console.WriteLine("Wählen Sie aus");
            Console.WriteLine("1 - Schere");
            Console.WriteLine("2 - Stein");
            Console.WriteLine("3 - Papier");
            Console.WriteLine("4 - Echse");
            Console.WriteLine("5 - Spock");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static int PCWahl()
        {
            Random zufall = new Random(DateTime.Now.Millisecond);
            var wahl = zufall.Next(1,6);
            return wahl;
        }

        private static string SiegerBestimmen(int spieler, int pc)
        {
            switch (spieler)
            {
                case 1:
                    switch (pc)
                    {
                        case 2:
                            return "Verloren! Stein schleift Schere!";
                        case 3:
                            return "Gewonnen! Schere schneidet Papier";
                        case 4:
                            return "Gewonnen! Schere köpft Echse";
                        case 5:
                            return "Verloren! Spock zertrümmert Schere";
                        default: break;
                    }
                    break;
                case 2:
                    {
                        switch (pc)
                        {
                            case 1:
                                return "Gewonnen! Stein schleift Schere!";
                            case 3:
                                return "Verloren! Papier bedeckt Stein!";
                            case 4:
                                return "Gewonnen! Stein zerquetscht Echse!";
                            case 5:
                                return "Verloren! Spock verdampft Stein!";
                            default: break;
                        }
                        break;
                    }
                case 3:
                    {
                        switch (pc)
                        {
                            case 1:
                                return "Verloren! Schere scneidet Papier";
                            case 2:
                                return "Gewonnen! Papier bedeckt Stein";
                            case 4:
                                return "Verloren! Echse frisst Papier";
                            case 5:
                                return "Gewonnen! Papier wiederlegt Spock";
                            default: break;
                        }
                        break;
                    }
                case 4:
                    {
                        switch (pc)
                        {
                            case 1:
                                return "Verloren! Schere köpft Echse";
                            case 2:
                                return "Verloren! Stein zerquetscht Echse";
                            case 3:
                                return "Gewonnen! Echse frisst Papier";
                            case 5:
                                return "Gewonnen! Echse vergiften Spock";
                            default: break;
                        }
                        break;  
                    }
                case 5:
                    {
                        switch (pc)
                        {
                            case 1:
                                return "Gewonnen! Spock zertrümmert Schere";
                            case 2:
                                return "Gewonnen! Spock verdampft Stein";
                            case 3:
                                return "Verloren! Papier wiederlegt Spock";
                            case 4:
                                return "Verloren Echse vergiftet Spock";
                            default: break;
                        }
                        break;
                    }
                default: break;
            }
            return "Unentschieden!"; 


        }

        private static void Ausgabe(string sieger)
        {
            Console.WriteLine(sieger);
        }

    }
}
