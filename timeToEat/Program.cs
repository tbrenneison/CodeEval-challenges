using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeToEat
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "05:33:44 21:25:41";

            string[] times = line.Split(' '); //split the timestamps into a string array

            Array.Sort(times); //sort the array largest-smallest
            Array.Reverse(times); //reverse the array 

            for(int i = 0; i <= times.Length-1; i++)
            {
                Console.Write(times[i] + " "); 
            }

            Console.WriteLine();


        }
    }
}
