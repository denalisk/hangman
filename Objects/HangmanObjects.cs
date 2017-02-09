using System.Collections.Generic;
using System;

namespace HangmanGame.Objects
{
    public class Hangman
    {
        public static void Main()
        {
            Console.WriteLine("working");
            string newWord = RandomWord();
            RandomWordSet(newWord);
            Console.WriteLine(RandomWordGet());
            GuessedWordInitialize(RandomWordGet());
            while (playing)
            {
                char guess = Console.ReadLine();
                string guessResults = CheckLetter(RandomWordGet(), GuessedWordGet(), guess);
            }


        }
        //An array made of the letters of the RandomWord()
        private static string _randomWord;
        private static string _guessedWord;
        public static bool playing = true;

        public static string[] hangmanWords = new string[100]
        {
            "enthusiastic", "hair", "tense", "obeisant", "unsightly", "talk", "squalid", "jellyfish", "ambiguous", "launch", "recognize", "things", "horrible", "clam", "telling", "marked", "harmonious", "juggle", "alert", "action", "lake", "romantic", "heady", "minister", "imaginary", "bang", "free", "practice", "turn", "rural", "old", "reign", "marble", "little", "educate", "appreciate", "brown", "want", "previous", "rest", "dynamite", "examine", "craven", "strong", "few", "rapid", "wilderness", "business", "soft", "basil", "warm", "grotesque", "welcome", "impulse", "heartbreaking", "special", "describe", "wind", "frantic", "truthful", "tame", "great", "gorgeous", "nutritious", "purple", "phobic", "boundary", "embarrassed", "teeth", "cave", "flash", "plan", "company", "addicted", "jar", "shop", "whimsical", "store", "influence", "juicy", "offend", "disgusted", "amount", "energetic", "weary", "box", "rhyme", "naughty", "wonder", "pets", "evasive", "touch", "carpenter", "contain", "believe", "valuable", "modern", "earth", "drab", "pleasant"
        };

        public static string RandomWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 100);
            return hangmanWords[randomIndex];
        }
        public static string CheckLetter(string word, string guessedWord, char guess)
        {
            string checkResults = "";
            for (int index = 0; index < word.Length; index++)
            {
                if (guessedWord[index] == '_')
                {
                    if (word[index] == guess)
                    {
                        checkResults += word[index];
                    }
                    else
                    {
                        checkResults += '_';
                    }

                }
                else
                {
                    checkResults += guessedWord[index];
                }
            };
            return checkResults;
        }

        public static bool CheckWin(string currentGuessState)
        {
            foreach (char letter in currentGuessState)
            {
                if (letter == '_')
                {
                    return false;
                }
            }
        }

        public static string RandomWordGet()
        {
            return _randomWord;
        }
        public static void RandomWordSet(string word)
        {
            _randomWord = word;
        }
        public static string GuessedWordGet()
        {
            return _guessedWord;
        }
        public static void GuessedWordSet(string word)
        {
            _guessedWord = word;
        }
        public static void GuessedWordInitialize(string word)
        {
            string blanks = "";
            foreach (char letter in word)
            {
                blanks += "_"
            };
            return blanks;
        }
    }
}
