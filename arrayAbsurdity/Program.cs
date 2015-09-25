using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAbsurdity
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "5;0,1,2,3,0";
            string[] stringNums = line.Split(';'); //splits array at semicolon
            int arraySize = int.Parse(stringNums[0]); //the size of the array 

            string theseNums = stringNums[1];
            string[] nums = theseNums.Split(','); //splits array at comma 

            int[] searchTheseNums = new int[nums.Length]; //new int array 
            for(int i = 0; i <= nums.Length -1; i++)
                {
                searchTheseNums[i] = int.Parse(nums[i]); //parses nums to search to ints and fills int array
                }

            Array.Sort(searchTheseNums); //sorts the array in numerical order

            for(int i = 0; i <= searchTheseNums.Length-1; i++)
            {
                if (searchTheseNums[i] == searchTheseNums[i + 1]) //if an index and the next index are the same
                {
                    Console.WriteLine(searchTheseNums[i]); //print the value
                    break; //exit the loop
                }
                else { }
            }




        }
    }
}
