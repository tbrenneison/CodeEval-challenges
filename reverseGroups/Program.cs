using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseGroups
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Given a list of numbers and a positive integer k, reverse the elements of the list, k items at a time. 
            If the number of elements is not a multiple of k, then the remaining items in the end should be left as is.
            Each line in this file contains a list of numbers and the number k, separated by a semicolon.
            The list of numbers are comma delimited.
            Print out the new comma separated list of numbers obtained after reversing.
            */

            string line = "1,2,3,4,5;2"; //test input (should output 2,1,4,3,5)

            string[] firstSplit = line.Split(';'); //splits at semicolon
            //"1,2,3,4,5", "2"

            int thisMany = int.Parse(firstSplit[firstSplit.Length - 1]); //reverse this many at at time

            string[] secondSplit = firstSplit[0].Split(','); //12345

          

            


        }
    }
}
