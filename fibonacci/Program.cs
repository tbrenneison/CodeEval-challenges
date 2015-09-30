using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "0"; //test input
            if (line == "0")
            { Console.WriteLine("0"); }
            else
            {
                int i = (int.Parse(line) - 1); //parse to int and subtract one 
                Console.WriteLine(Fib(i));
            }
            
        }//end of main method

        static int Fib (int i)
        {
            if(i <= 1)
            { return 1;  }
            else
            { return Fib(i - 1) + Fib(i - 2); }
        }//end of fibonacci method
    }
}
