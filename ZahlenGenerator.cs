using System;
using System.Media;

namespace LA_1300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Random random = new Random();//Code von stackoverflow
                int Highscore = int.MaxValue;  // Initialisierung mit maximal möglichem Wert
            
                bool playAgain = true;

            Console.WriteLine("Willkommen beim Zahlenraten-Spiel!");

            while (playAgain)
            {
                int secretNumber = random.Next(1, 101);
                int numberOfAttempts = 0;

                while (true)
                {
                    Console.Write("Rate eine Zahl zwischen 1 und 100: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int guessedNumber))
                    {
                        PlayErrorSound();
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl ein.");
                        continue;
                    }

                    numberOfAttempts++;

                    if (guessedNumber < secretNumber)
                    {
                        Console.WriteLine("Die geratene Zahl ist niedriger als die Geheimzahl.");
                    }
                    else if (guessedNumber > secretNumber)
                    {
                        Console.WriteLine("Die geratene Zahl ist größer als die Geheimzahl.");
                    }
                    else
                    {
                        Console.WriteLine($"Glückwunsch! Du hast die Geheimzahl {secretNumber} erraten.");
                        Console.WriteLine($"Anzahl der Versuche: {numberOfAttempts}");

                        if (numberOfAttempts < Highscore)
                        {
                            Highscore = numberOfAttempts;
                            Console.WriteLine("Neuer Highscore: " + Highscore);
                        }

                        break;
                    }
                }

                Console.Write("Möchten Sie nochmal spielen? (ja/nein): ");
                string playAgainInput = Console.ReadLine();
                playAgain = (playAgainInput.ToLower() == "ja");
            }
        }

        static void PlayErrorSound()//Sound von: https://www.soundjay.com/failure-sound-effect.html#google_vignette
                                    //Code von ChatGPT
        {
            string soundPath = @"C:\Users\filip\OneDrive\Desktop\LA-1300\fail-trombone-03.wav";

            try
            {
                SoundPlayer player = new SoundPlayer(soundPath);
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Abspielen des Sounds: " + ex.Message);
            }
        }
    }
}
