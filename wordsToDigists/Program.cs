using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsToDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "zero;two;five;seven;eight;four"; //test input

            string[] splitLine = line.Split(';');

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("zero", 0);
            dict.Add("one", 1);
            dict.Add("two", 2);
            dict.Add("three", 3);
            dict.Add("four", 4);
            dict.Add("five", 5);
            dict.Add("six", 6);
            dict.Add("seven", 7);
            dict.Add("eight", 8);
            dict.Add("nine", 9); 

            foreach(string number in splitLine)
            {
                int value;
                if(dict.TryGetValue(number, out value))
                {
                    Console.Write(value); 
                }
            }

            Console.WriteLine();
        }
    }
}
