using System;
using System.Media;

namespace RandomGenerator
{
    public class SpielManager
    {
        private Generate _numberGenerator;
        private int _highscore;

        public SpielManager()
        {
            _numberGenerator = new Generate();
            _highscore = int.MaxValue;
        }

        public void StarteSpiel()
        {
            bool playAgain = true;

            Console.WriteLine("Willkommen beim Zahlenraten-Spiel!");

            while (playAgain)
            {
                int NumberRandom = _numberGenerator.GeneriereRandomNummer();
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

                    if (guessedNumber < NumberRandom)
                    {
                        Console.WriteLine("Die geratene Zahl ist niedriger als die Geheimzahl.");
                    }
                    else if (guessedNumber > NumberRandom)
                    {
                        Console.WriteLine("Die geratene Zahl ist größer als die Geheimzahl.");
                    }
                    else
                    {
                        Console.WriteLine($"Glückwunsch! Du hast die Geheimzahl {NumberRandom} erraten.");
                        Console.WriteLine($"Anzahl der Versuche: {numberOfAttempts}");

                        if (numberOfAttempts < _highscore)
                        {
                            _highscore = numberOfAttempts;
                            Console.WriteLine("Neuer Highscore: " + _highscore);
                        }

                        break;
                    }
                }

                Console.Write("Möchten Sie nochmal spielen? (ja/nein): ");
                string playAgainInput = Console.ReadLine();
                playAgain = (playAgainInput.ToLower() == "ja");
            }
        }

        private void PlayErrorSound()
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
