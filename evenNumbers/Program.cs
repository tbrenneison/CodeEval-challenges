using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "701"; //test input

            int num = Convert.ToInt32(line); //convert string to integer

            if(num % 2 == 0)
            { Console.WriteLine("1"); }
            else
            { Console.WriteLine("0"); }
        }
    }
}
