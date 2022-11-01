namespace LA_1200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


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
            }
            catch
            {
                Console.WriteLine("Ungültige Eingabe");
            }
        }
    }
}