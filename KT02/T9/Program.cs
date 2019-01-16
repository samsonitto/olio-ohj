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
            Random random = new Random((int)DateTime.Now.Ticks); // määritetään satunnainen 

            string[] wordBank = { "Weed", "Mushroom", "Ecstasy", "Cocane", "LSD", "Alcohol" }; // sanapankki

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];  // valitaan sana sanapankista
            string wordToGuessUppercase = wordToGuess.ToUpper(); // vaihdetaan isoiksi kirjaimiksi

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length); // pelaajalle näkyvän sanan pituus
            for (int i = 0; i < wordToGuess.Length; i++) // tulostetaan "_" sanan pituuden verran
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>(); // lista oikeista arvauksista
            List<char> incorrectGuesses = new List<char>(); // lista vääristä arvauksista

            int lives = 5; // arvausten määrä
            bool won = false;
            int lettersRevealed = 0; // kirjainlaskuri

            string input;
            char guess;

            while (!won && lives > 0) // peli jatkuu niin kauan kun et ole voittanut "won" ja arvausten "lives määrä on isompi kuin 0"
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess)) // jos correctGuesses listassa on jo syöttämäsi kirjain
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess)) // jos incorrectGuesses listassa on jo syöttämäsi kirjain
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess)) // jos sana sisältää syöttämäsi kirjain
                {
                    correctGuesses.Add(guess); // lisästään kirjain correctGuesses listaan

                    for (int i = 0; i < wordToGuess.Length; i++) // tarkistetaan mikä sanan kirjain vastaa arvauskirjainta
                    {
                        if (wordToGuessUppercase[i] == guess) // jos arvattavan kirjain vastaa arvauskirjainta
                        {
                            displayToPlayer[i] = wordToGuess[i]; // laitetaan kirjain pelaajalle nakyvään sanaan, oikeaan paikkaan
                            lettersRevealed++; // näkyvillä olevien kirjainten laskuri
                        }
                    }

                    if (lettersRevealed == wordToGuess.Length) // jos näkyvillä olevien kirjainten laskuri on yhtä pitkä kuin arvattava sana, pelaaja voittaa
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess); // väärä arvaus lisätään incorrectGuesses listaan

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess); 
                    lives--; // yritys laskuri pienentyy yhdellä
                }

                Console.WriteLine(displayToPlayer.ToString()); // tulostetaan sanan tämän hetkesessä tilanteessa
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
