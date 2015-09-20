using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penultimateWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "some line with text"; // test input

            string[] sentence = line.Split(' '); //split line into a string array

            string penultimateWord = sentence[(sentence.Length - 2)]; //find penultimate word

            Console.WriteLine(penultimateWord); //write penultimate word to console 


        }
    }
}
