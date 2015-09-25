using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Given a number n and two integers p1,p2 determine if the bits in position p1 and p2 
            are the same or not. Positions p1 and p2 are 1 based.  The first argument will be a path 
            to a filename containing a comma separated list of 3 integers, one list per line.
            Print to stdout, 'true'(lowercase) if the bits are the same, else 'false'(lowercase).
            */

            string line = "125,1,2"; //test input

            string[] splitLine = line.Split(','); //split line into string[] "splitLine"
            int[] ints = new int[splitLine.Length]; //new empty int[] "ints"

            for(int i = 0; i <= splitLine.Length -1; i++)
                 {
                ints[i] = Convert.ToInt32(splitLine[i]); //convert strings to ints and fill int[] "ints"
                 }

            string binary = Convert.ToString(ints[0],2); //convert int[0] to binary string

            char[] binaryToReverse = binary.ToCharArray(); //convert binary string to char array

            Array.Reverse(binaryToReverse); //reverse char array to read right-left 

            string reversedBinary = new string(binaryToReverse); //new string "reversedBinary"

            int positionOne = ints[1] - 1; //because positions are 1-based, not 0-based 
            int positionTwo = ints[2] - 1;
            
            if(reversedBinary[positionOne] == reversedBinary[positionTwo])
                 { Console.WriteLine("true"); }

            else
                 { Console.WriteLine("false"); } 

           

        }
    }
}
