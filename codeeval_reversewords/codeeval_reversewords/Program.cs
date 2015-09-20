using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeeval_reversewords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "World Hello"; //test line (actual program takes input from a file) 

            string[] sentence = line.Split(' '); //splits the line into an array 

            if (sentence.Length == 0) //if the array is empty, continue with next line 
            {
                continue;
            }

            else // else do this 
            {

                Array.Reverse(sentence); //reverse the array 

                Console.WriteLine(); // make a new line 

                foreach (string w in sentence) //for each word in the array 
                {
                    string u = w;
                    string v = sentence[(sentence.Length - 1)];

                    Console.Write(w);  //write each word 
                    if (u == v)  //but if the word is the last in the array don't make a space
                    {
                        continue;
                    }
                    Console.Write(" "); //put a space between the words 
                }
            }
        }
    }
}
