using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "3 5 10"; //test input

             
            string[] nums = line.Split(' '); //splits line into string array
            
            int x = int.Parse(nums[0]); //convert to int 
            int y = int.Parse(nums[1]);
            int n = int.Parse(nums[2]);

            
            for(int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    if (i % x == 0 && i % y == 0)
                    {
                        Console.Write("FB");
                    }
                    else if (i % x == 0)
                    {
                        Console.Write("F");
                    }
                    else if (i % y == 0)
                    {
                        Console.Write("B");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                Console.Write(" ");
                }
                else
                {
                    if (i % x == 0 && i % y == 0)
                    {
                        Console.Write("FB");
                    }
                    else if (i % x == 0)
                    {
                        Console.Write("F");
                    }
                    else if (i % y == 0)
                    {
                        Console.Write("B");
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
            } //end of for loop
            


        }
    }
}
