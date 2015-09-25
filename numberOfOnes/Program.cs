using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program which determines the number of 1 bits in the internal representation of a
            given integer. The first argument is a path to a file. The file contains integers, one per line.
            Print to stdout the number of ones in the binary form of each number.
            */

            string line = "10"; //test input

            int parsed = int.Parse(line); //parse string "line" to int

            string binary = Convert.ToString(parsed, 2); //converts int to binary string

            StringBuilder counter = new StringBuilder(); 

            foreach(char one in binary)
            {
                if(one == '1')
                { counter.Append("1"); }
            }

            Console.WriteLine(counter.ToString().Length);

        } //end of main method 
    }
}
