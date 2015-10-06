using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "A slow yellow fox crawls under the proactive dog"; //test input

            List<char> alphabet = new List<char>() { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            line.ToLower();

            List<char> missingChars = new List<char>(); //list for missing chars

            foreach (char c in alphabet)
            {
                if(line.IndexOf(c) >= 0) //if character exists in string "line"
                {
                    continue;
                }
                else
                {
                    missingChars.Add(c);
                }
            }

            char[] convertMissingChars = missingChars.ToArray(); //because CodeEval doesn't like list.Count() for some reason

            if(convertMissingChars.Length == 0) //if not missing chars
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Array.Sort(convertMissingChars); //alphabetical order
                foreach(char c in convertMissingChars) //print missing chars
                {
                    Console.Write(c);
                }
                Console.Write("\r\n"); //new line

            }
        } //end of main method
    }
}
