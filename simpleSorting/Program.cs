using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "70.920 -38.797 14.354 99.323 90.374 7.581"; //test input

            string[] nums = line.Split(' '); //split the line into a string array

            decimal[] decArray = new decimal[nums.Length]; //create a new decimal array
            for (int i = 0; i < nums.Length; i++)
                {
                decArray[i] = decimal.Parse(nums[i]); //parse the values from the string array into decimals and put into decimal array 
                 }

            Array.Sort(decArray); //sort the array
            
            foreach(decimal dec in decArray)
            {
                Console.Write(dec); //print out every value in the decimal array
                Console.Write(" "); //with a trailing space for readability 
            }

            Console.WriteLine();
        }
    }
}
