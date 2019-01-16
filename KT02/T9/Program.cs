using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random((int)DateTime.Now.Ticks); // m��ritet��n satunnainen 

            string[] wordBank = { "Weed", "Mushroom", "Ecstasy", "Cocane", "LSD", "Alcohol" }; // sanapankki

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];  // valitaan sana sanapankista
            string wordToGuessUppercase = wordToGuess.ToUpper(); // vaihdetaan isoiksi kirjaimiksi

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); // pelaajalle n�kyv�n sanan pituus
            for (int i = 0; i < wordToGuess.Length; i++) // tulostetaan "_" sanan pituuden verran
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>(); // lista oikeista arvauksista
            List<char> incorrectGuesses = new List<char>(); // lista v��rist� arvauksista

            int lives = 5; // arvausten m��r�
            bool won = false;
            int lettersRevealed = 0; // kirjainlaskuri

            string input;
            char guess;

            while (!won && lives > 0) // peli jatkuu niin kauan kun et ole voittanut "won" ja arvausten "lives m��r� on isompi kuin 0"
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess)) // jos correctGuesses listassa on jo sy�tt�m�si kirjain
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess)) // jos incorrectGuesses listassa on jo sy�tt�m�si kirjain
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess)) // jos sana sis�lt�� sy�tt�m�si kirjain
                {
                    correctGuesses.Add(guess); // lis�st��n kirjain correctGuesses listaan

                    for (int i = 0; i < wordToGuess.Length; i++) // tarkistetaan mik� sanan kirjain vastaa arvauskirjainta
                    {
                        if (wordToGuessUppercase[i] == guess) // jos arvattavan kirjain vastaa arvauskirjainta
                        {
                            displayToPlayer[i] = wordToGuess[i]; // laitetaan kirjain pelaajalle nakyv��n sanaan, oikeaan paikkaan
                            lettersRevealed++; // n�kyvill� olevien kirjainten laskuri
                        }
                    }

                    if (lettersRevealed == wordToGuess.Length) // jos n�kyvill� olevien kirjainten laskuri on yht� pitk� kuin arvattava sana, pelaaja voittaa
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess); // v��r� arvaus lis�t��n incorrectGuesses listaan

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess); 
                    lives--; // yritys laskuri pienentyy yhdell�
                }

                Console.WriteLine(displayToPlayer.ToString()); // tulostetaan sanan t�m�n hetkesess� tilanteessa
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", wordToGuess);

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
