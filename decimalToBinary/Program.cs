using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Your program should accept as its first argument a path to a filename containing decimal numbers 
            greater or equal to 0, one per line. Ignore all empty lines.  Print the binary representation,
            one per line.*/

            string line = "10"; //test input 

            if (line == null) //if line is empty, ignore it
            { continue; }

            else
            {
                int toInt = Convert.ToInt32(line); //convert to int
                string toBin = Convert.ToString(toInt, 2); //convert into to binary string
                Console.WriteLine(toBin); //print 
            }

        }
    }
}
