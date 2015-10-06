using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pangrams2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Your program should accept as its first argument a path to a filename. 
            This file will contain several text strings, one per line. 
            Print out all the letters each string is missing in lowercase, alphabetical order.
            */

            string line = "A slow yellow fox crawls under the proactive dog";

            line = line.ToLower();

            char[] letters = {' ','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            List<char> missingLetters = new List<char>(); 

            foreach(char let in letters) //for each letter in the alphabet
            {
                if (line.Contains(let)) //see if the letter is in string "line"
                {
                    continue;
                }
                else //and if it's not, add it to the list "missingLetters"
                {
                    missingLetters.Add(let);
                }
            }
            missingLetters.Sort(); //alphabetize the missing letters 

            int missingLettersCount = missingLetters.Count(); 
            
            if(missingLettersCount > 0) //if there are missing letters 
            {
                foreach(char letter in missingLetters) //print all the missing letters
                {
                    Console.Write(letter);
                }
            }
            else
            {
                Console.Write("NULL");  //otherwise write NULL 
            }

            Console.WriteLine(); //new line

        }
    }
}
