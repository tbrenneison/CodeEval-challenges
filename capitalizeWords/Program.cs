using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "javaScript language"; //test input

            string[] words = line.Split(' ');  //split the string into a string array

            foreach (string w in words) //for each word
            {
                char[] a = w.ToCharArray(); //make word a char array

                for (int i = 0; i <= w.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(char.ToUpper(a[i])); //make the character at index 0 uppercase
                    }
                    else
                    { Console.Write(a[i]); }

                }
                Console.Write(" "); //space between words
            }

            Console.WriteLine();



        }

    }
}
