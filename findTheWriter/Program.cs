using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findTheWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53"; //test input

            string[] firstSplit = line.Split('|'); //splits letters and key into string array

            string trimThis = firstSplit[1];
            string numsTrimmed = trimThis.Trim(); // remove leading space from integers 

            string[] nums = numsTrimmed.Split(' '); //splits integers into seperate string array
            
            int[] numKey = new int[nums.Length]; //new int array
            for(int i = 0; i < nums.Length; i++)  //converts key into integers and places in int array 
                 {
                numKey[i] = Convert.ToInt32(nums[i]);
                 } 

            string findWriter = firstSplit[0]; // the mess of letters is a variable now 
          
            foreach(int keyNum in numKey)  //writes the character at the index of each value in numKey to the console
                 {
                Console.Write(findWriter[keyNum-1]);
                 }

            Console.WriteLine(); //make a new line
           

        }
    }
}
