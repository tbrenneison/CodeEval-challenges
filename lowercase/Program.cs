using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "HELLO CODEEVAL"; //test input

            string[] words = line.Split(' '); //split string into string array

            StringBuilder lowerCase = new StringBuilder(); //new StringBuilder object

            foreach (string w in words) //for each word in string [] words
            {
                lowerCase.Append(w.ToLower() + " "); //make lowercase and append to lowerCase SB object
            }

            Console.WriteLine(lowerCase.ToString().Trim()); //case lowerCase SB oject to string and trim 
        }
    }
}