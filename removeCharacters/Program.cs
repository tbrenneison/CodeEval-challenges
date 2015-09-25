using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            /* THIS DOESN'T ACTUALLY WORK AND GETS A 'PARTIAL' ON CODEEVAL. 
            I HAVE YET TO FIGURE OUT HOW TO REMOVE THE FREAKING CHARACTERS, 
            POSSIBLY BECAUSE I AM AN IDIOT AND POSSIBLY BECAUSE I AM NEW AT THIS.
            I AM UPLOADING IT TO GITHUB ANYWAY SO THAT AFTER I SOLVE IT I CAN
            GO BACK AND LAUGH AT/HARSHLY JUDGE MYSELF. */ 
            


            string line = "hello world, def"; //test input

            string[] splitLine = line.Split(','); //split input into string array 

            string sentence = splitLine[0]; // first part is "sentence"
            string key = splitLine[1].Trim();  //second part is "key" (chars to remove) 
            

            for (int i = 0; i <= sentence.Length -1; i++) //counter for sentence
            {
                for (int m = 0; m <= key.Length -1; m++) //counter for key
                {
                    if (sentence[i] == key[m]) //if character in sentence matches character in key
                    {
                        sentence = sentence.Replace(key[m], '*');   // replaced character with an asterisk
                    } 
                }
            }

            for (int n = 0; n <= sentence.Length - 1; n++) //loops over sentence again
            {
                if (sentence[n] == '*') //if the character is an asterisk it removes it
                { sentence = sentence.Remove(n, 1); }
            }


            Console.WriteLine(sentence.Trim());




        }
    }
}
