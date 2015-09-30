using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowestUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /* There is a game where each player picks a number from 1 to 9, writes it on a paper and gives to a guide. 
            A player wins if his number is the lowest unique. We may have 10-20 players in our game.
            You're a guide and you're given a set of numbers from players for the round of game. 
            Print a winner's position or 0 in case there is no winner. */

            string line = "3 3 9 1 6 5 8 1 5 3"; //test input

            string[] nums = line.Split(' ');
            int[] numbers = new int[nums.Length];

            for(int i = 0; i <= nums.Length -1; i++)
                {
                numbers[i] = int.Parse(nums[i]); 
                }
            
            
        }//end of main menthod
    }
}
