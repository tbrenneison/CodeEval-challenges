using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mthToLastElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "e f g h 2";  //test input

            string[] splice = line.Split(' '); //splits line into string array

            string lastIndex = splice[(splice.Length - 1)]; //assigns last value in array to a variable
            int keyNum = Convert.ToInt32(lastIndex); //convers that variable to an int

            if(keyNum <= (splice.Length -1)) //if the index exists, do this:  
                 {
                Console.WriteLine(splice[splice.Length - (keyNum+1)]); //print the nth index from the right 
                 }
            else
                {
                continue;
                }



        }
    }
}
