using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this challenge you need to find the longest word in a sentence. 
            //If the sentence has more than one word of the same length you should pick the first one.

            string line = "some line with text"; //test input

            string[] words = line.Split(' ');

            string longestWord = "";  //longest word variable

            for(int i = 0; i <=words.Length -1; i++)
            {
                if(words[i].Length > longestWord.Length) //if longer than the previous value, overwrite
                 {
                longestWord = words[i];
                 }
            }


            Console.WriteLine(longestWord); 
        }
    }
}
