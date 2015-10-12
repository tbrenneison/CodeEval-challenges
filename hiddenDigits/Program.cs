using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiddenDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            In this challenge you're given a random string containing hidden and visible digits. 
            The digits are hidden behind lower case latin letters as follows: 0 is behind 'a', 1 is behind ' b ' etc., 9 is behind 'j'. 
            Any other symbol in the string means nothing and has to be ignored. 
            So the challenge is to find all visible and hidden digits in the string and print them out in order of their appearance.
            */

            string line = "(ABW>'yy^'M{X-K}q,"; //test input

            string alphabet = "abcdefghij";

            int[] numbers = new int[alphabet.Length];

            for (int i = 0; i <= alphabet.Length-1; i++) //put numbers 0-25 in an array
            {
                numbers[i] = i; 
            }

            StringBuilder result = new StringBuilder(); 

            foreach (char c in line) //for each character in "line"
            {
                if(char.IsLower(c)) //if it's a lowercase letter
                    {
                    if (alphabet.IndexOf(c) != -1) //if it's in the abbreviated alphabet 
                         {
                        int index = alphabet.IndexOf(c); //find the hidden digit 
                        result.Append(index);
                         }
                    }
                else if(char.IsDigit(c)) //if it's a digit
                {
                    if(c <= '9') //and is less than nine 
                    {
                        result.Append(c); 
                    }
                }

            }

            string hiddenDigits = result.ToString(); 

            if(hiddenDigits.Length == 0) //if the string is empty (no digits)
            {
                Console.WriteLine("NONE");
            }
            else //otherwise write them out
            {
                Console.WriteLine(hiddenDigits);
            }


        }
    }
}
