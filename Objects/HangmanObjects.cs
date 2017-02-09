using System.Collections.Generic;
using System;

namespace HangmanGame.Objects
{
    public class Hangman
    {
        public static void Main()
        {
            Console.WriteLine("working");
            Console.WriteLine(RandomWord());

        }

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
    }
}
