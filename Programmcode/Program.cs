using System.IO;

namespace Lernatelier_Vokabeln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAnswer = false;
            int maxScore = 0;
            int highscore = 0;
            bool isRepeat = true;
            string testOrInput = "a";
            int wordCount = 0;
            string filepath = @"words.txt";



            testOrInput = AskUserForTestOrInput(isRepeat, testOrInput);

            if (testOrInput == "a")
            {
                string file = File.ReadAllText(filepath);
                string[] line = file.Split("\r\n");
                wordCount = line.Length;
                string[] wordsGerman = new string[wordCount];
                string[] wordsForeignLanguage = new string[wordCount];

                
                for (int i = 0; i < line.Length - 1; i++)
                {

                    string[] word = line[i].Split(',');
                    wordsGerman[i] = word[0];
                    wordsForeignLanguage[i] = word[1];

                }

                maxScore = wordCount;
                highscore = TestUserForWords(wordsGerman, wordsForeignLanguage, highscore, wordCount);

                Console.WriteLine("Sie haben {0} von maximal {1} Punkte erreicht", highscore, maxScore);


            }
            else 
            {

                wordCount = AskUserForWordCount(wordCount, isRepeat);


                string[] wordsGerman = new string[wordCount];
                string[] wordsForeignLanguage = new string[wordCount];
                isRepeat = true;


                do
                {
                    try
                    {

                        for (int i = 0; i < wordCount; i++)
                        {
                            Console.WriteLine("Geben sie das deutsche Wort ein");
                            wordsGerman[i] = (Console.ReadLine());
                            Console.WriteLine("Geben sie die Übersetzung ein");
                            wordsForeignLanguage[i] = (Console.ReadLine());
                        }
                        isRepeat = false;


                    }
                    catch
                    {

                        Console.WriteLine("Dies ist eine Ungültige Eingabe!");

                    }

                } while (isRepeat);


                WriteWordsToAFile(wordsGerman, wordsForeignLanguage, wordCount, filepath);

            }

        }
        static string AskUserForTestOrInput(bool isRepeat, string testOrInput)
        {
            do
            {
                try
                {

                    Console.Write("Möchten Sie neue Wörter eintragen oder die vorhandenen Wörter abfragen? [e/a] ");
                    testOrInput = Console.ReadLine();
                    if (testOrInput == "a")
                    {

                    }
                    else if (testOrInput != "e")
                    {
                        throw new Exception();
                    }
                    isRepeat = false;

                }
                catch
                {

                    Console.WriteLine("Dies ist eine Ungültige Eingabe!");

                }

            } while (isRepeat);

            return testOrInput;
        }
        static int AskUserForWordCount(int wordCount, bool isRepeat)
        {

            do
            {
                try
                {

                    Console.Write("Wie viele wörter möchten sie eingeben? ");
                    wordCount = Convert.ToInt32(Console.ReadLine());
                    isRepeat = false;


                }
                catch
                {

                    Console.WriteLine("Dies ist eine Ungültige eingabe; Bitte geben sie nur ganze Zahlen ein!");

                }

            } while (isRepeat);

            return wordCount;
        }
        static int TestUserForWords(string[] wordsGerman, string[] wordsForeignLanguage, int highscore, int wordCount)
        {

            for (int i = 0; i < wordCount - 1; i++)
            {
                bool isAnswer = false;
                do
                {

                    Console.WriteLine("Übersetzen sie bitte {0}", wordsGerman[i]);
                    string input = Console.ReadLine();
                    if (input == wordsForeignLanguage[i])
                    {
                        Console.WriteLine("Dies ist Korrekt.");
                        highscore++;
                        isAnswer = false;
                    }
                    else
                    {
                        Console.WriteLine("Dies ist leider nicht korrekt.");
                        isAnswer = true;
                        while (isAnswer == true)
                        {
                            Console.Write("Probieren sie es nochmal: ");
                            input = Console.ReadLine();
                            if (input == wordsForeignLanguage[i])
                            {

                                Console.WriteLine("Dies ist Korrekt.");
                                isAnswer = false;
                            }
                            else
                            {
                                Console.WriteLine("Dies ist leider inkorrekt, probieren sie es nochmal.");
                                isAnswer = true;
                            }
                        }

                    }

                } while (isAnswer == true);
            }

            return highscore;

        }
        static void WriteWordsToAFile(string[] wordsGerman, string[] wordsForeignLanguage, int wordCount, string filepath)
        {

            string outputText = "";


            for (int i = 0; i < wordCount; i++)
            {

                outputText += $"{wordsGerman[i]},{wordsForeignLanguage[i]}\r\n";

            }

            File.WriteAllText(filepath, outputText);

        }


    }
}