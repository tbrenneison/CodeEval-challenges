using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeeval_rightmostChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello CodeEval,E"; //test input

            string[] sentence = line.Split(','); //split the string into the sentence and character

            string character = (sentence[1]); //convert the character to a string "character"
            string words = sentence[0]; // convert the string to a string "words"

            char[] char2 = character.ToCharArray(); //convert the string "character" to a char array "char2"
            char[] words2 = words.ToCharArray(); //convert the string "words" to a char array "words2"

            if (Convert.ToBoolean(Array.LastIndexOf(words2, char2[0])) == true) //if the last instance exists
                 {
                Console.WriteLine(Array.LastIndexOf(words2, char2[0]));
                 }
            else if (Convert.ToBoolean(Array.LastIndexOf(words2, char2[0])) == false) //if it doesn't
                {
                Console.WriteLine("-1");
                }
            else //or nothingness 
                { }



                           



        }
    }
}
