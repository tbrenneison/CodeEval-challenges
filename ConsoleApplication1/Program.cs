using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "6g52M lQw6 s I k,6g52M lQw6 s I k"; //test input

            string[] splitLine = line.Split(',');
     
            string partone = splitLine[0];
            int index = partone.LastIndexOf(splitLine[1]); //look right-left for last index of part two in part one

            if (index == -1)
            { Console.WriteLine("0"); }
            else
            { Console.WriteLine("1"); }





        }
    }
}
