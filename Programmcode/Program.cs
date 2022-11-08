using System.Runtime.CompilerServices;

namespace Lernatelier_Vokabeln
{
    internal class Program
    {
        static void Main(string[] args)
        { bool antwort = (false);
            int highscore = 0;
           bool wiederholung=false;
            do
            {
                try
                {

                    Console.WriteLine("Wie viele wörter möchten sie eingeben");
                    int anzahlWörter = Convert.ToInt32(Console.ReadLine());
                    int[] anzahlWörterArray = new int[anzahlWörter];
                    string[] wörterDeutsch = new string[anzahlWörter];
                    string[] wörterFremdsprache = new string[anzahlWörter];

                    for (int i = 0; i < wörterDeutsch.Length; i++)
                    {
                        Console.WriteLine("Geben sie das deutsche Wort ein");
                        wörterDeutsch[i] = (Console.ReadLine());
                        Console.WriteLine("Geben sie die Übersetzung ein");
                        wörterFremdsprache[i] = (Console.ReadLine());
                    }


                    for (int x = 0; x < wörterDeutsch.Length; x++)
                    {

                        do
                        {
                            Console.WriteLine("Übersetzen sie bitte {0}", wörterDeutsch[x]);
                            string eingabe = Console.ReadLine();
                            if (eingabe == wörterFremdsprache[x])
                            {

                                Console.WriteLine("Dies ist Korrekt");
                                highscore++;

                            }
                            else
                            {
                                Console.WriteLine("Leider ist dies inkorrekt.Versuche es nochmals.");
                                antwort = true;

                            }
                        } while (antwort == true);
                    }

                }
                catch
                {

                    Console.WriteLine("Dies ist eine Ungültige eingabe.Bitte geben sie nur ganze Zahlen ein.");
                    wiederholung =true;
                 }

            } while (wiederholung =true);

            Console.WriteLine("Sie haben eine totale Punktzahl von" + highscore + "Punkten erreicht");
        } 
    }
}