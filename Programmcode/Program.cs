namespace LA_1200
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool lmao = false;
            int highscore = 0;
            int maxScore = 0;

            Console.Write("Wie viele Wörter wollen sie abfragen? ");
            int anzahlWörter = Convert.ToInt32(Console.ReadLine());
            string[] wörter = new string[anzahlWörter];
            string[] wörterLösungen = new string[anzahlWörter];

            for (int i = 0; i < wörter.Length; i++)
            {
                Console.Write("Was ist das Deutsche Wort? ");
                wörter[i] = (Console.ReadLine());
                Console.WriteLine("Was ist die Englishe übersetzung davon?");
                wörterLösungen[i] = (Console.ReadLine());

            }


            for (int x = 0; x < wörter.Length; x++)
            {
                maxScore++;
                do
                {

                    Console.WriteLine("Übersetzen sie bitte {0}", wörter[x]);
                    string eingabe = Console.ReadLine();
                    if (eingabe == wörterLösungen[x])
                    {
                        Console.WriteLine("Dies ist Korrekt.");
                        highscore++;
                        lmao = false;
                    }
                    else
                    {
                        Console.WriteLine("Dies ist leider nicht korrekt.");
                        lmao = true;
                        while (lmao == true) 
                        {
                            Console.Write("Probieren sie es nochmal: ");
                            eingabe = Console.ReadLine();
                            if (eingabe == wörterLösungen[x])
                            {
                                
                                Console.WriteLine("Dies ist Korrekt.");
                                lmao = false;
                            }else
                            {
                                Console.WriteLine("Dies ist leider inkorrekt, probieren sie es nochmal.");
                                lmao = true;
                            }
                        }

                    }

                } while (lmao == true);
            }
            Console.WriteLine("Sie haben {0} von maximal {1} Punkte erreicht", highscore, maxScore);
        }
    }
}