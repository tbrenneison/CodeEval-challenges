using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "496"; //test input

            int[] nums = new int [(line.Length)]; //new int array

            
            for(int i = 0; i <= (line.Length - 1); i++) //populate the int array
            {
                nums[i] = int.Parse(line[i].ToString()); //parse each char to string to int
            }

            int sum = 0; //new int sum starts at zero
            for (int n = 0; n <= line.Length - 1; n++)
            {
                sum += nums[n]; //sum is itself plus nums[n]
            }

            Console.WriteLine(sum);
            


        }
    }
}
