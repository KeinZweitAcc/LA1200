namespace Lernatelier_Vokabeln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool antwort = (false);
            int maxScore = 0;
            int highscore = 0;
            bool wiederholung = true;
            bool abfragen = true;
            int anzahlWörter = 0;
            string dateipfad = @"words.txt";

            do
            {
                try
                {

                    Console.Write("Möchten Sie neue Wörter eintragen oder die vorhandenen Wörter abfragen? [e/a] ");
                    abfragen = Console.ReadLine() == "a";
                    wiederholung = false;

                }
                catch
                {

                    Console.WriteLine("Dies ist eine Ungültige Eingabe!");

                }

            } while (wiederholung);

            if (abfragen)
            {
                string rohdatei = File.ReadAllText(dateipfad);
                string[] line = rohdatei.Split("\r\n");
                anzahlWörter = line.Length;
                string[] wörterDeutsch = new string[anzahlWörter];
                string[] wörterFremdsprache = new string[anzahlWörter];

                
                for (int i = 0; i < line.Length - 1; i++)
                {

                    string[] word = line[i].Split(',');
                    wörterDeutsch[i] = word[0];
                    wörterFremdsprache[i] = word[1];

                }

                

                for (int i = 0; i < line.Length - 1; i++)
                {
                    antwort = false;
                    maxScore++;
                    do
                    {

                        Console.WriteLine("Übersetzen sie bitte {0}", wörterDeutsch[i]);
                        string eingabe = Console.ReadLine();
                        if (eingabe == wörterFremdsprache[i])
                        {
                            Console.WriteLine("Dies ist Korrekt.");
                            highscore++;
                            antwort = false;
                        }
                        else
                        {
                            Console.WriteLine("Dies ist leider nicht korrekt.");
                            antwort = true;
                            while (antwort == true)
                            {
                                Console.Write("Probieren sie es nochmal: ");
                                eingabe = Console.ReadLine();
                                if (eingabe == wörterFremdsprache[i])
                                {

                                    Console.WriteLine("Dies ist Korrekt.");
                                    antwort = false;
                                }
                                else
                                {
                                    Console.WriteLine("Dies ist leider inkorrekt, probieren sie es nochmal.");
                                    antwort = true;
                                }
                            }

                        }

                    } while (antwort == true);
                }
                Console.WriteLine("Sie haben {0} von maximal {1} Punkte erreicht", highscore, maxScore);


            }
            else
            {
                
                do
                {
                    try
                    {

                        Console.Write("Wie viele wörter möchten sie eingeben? ");
                        anzahlWörter = Convert.ToInt32(Console.ReadLine());
                        wiederholung = false;


                    }
                    catch
                    {

                        Console.WriteLine("Dies ist eine Ungültige eingabe; Bitte geben sie nur ganze Zahlen ein!");

                    }

                } while (wiederholung);

                
                int[] anzahlWörterArray = new int[anzahlWörter];
                string[] wörterDeutsch = new string[anzahlWörter];
                string[] wörterFremdsprache = new string[anzahlWörter];
                wiederholung = true;

                
                do
                {
                    try
                    {

                        for (int i = 0; i < anzahlWörter; i++)
                        {
                            Console.WriteLine("Geben sie das deutsche Wort ein");
                            wörterDeutsch[i] = (Console.ReadLine());
                            Console.WriteLine("Geben sie die Übersetzung ein");
                            wörterFremdsprache[i] = (Console.ReadLine());
                        }
                        wiederholung = false;


                    }
                    catch
                    {

                        Console.WriteLine("Dies ist eine Ungültige Eingabe!");

                    }

                } while (wiederholung);


                string ausgabeText = "";


                for (int i = 0; i < anzahlWörter; i++)
                {

                    ausgabeText += $"{wörterDeutsch[i]},{wörterFremdsprache[i]}\r\n";

                }

                File.WriteAllText(dateipfad, ausgabeText);
            }

        }
    }
}