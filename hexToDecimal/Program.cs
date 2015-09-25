using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "9f"; //test input

            long decimalValue = Convert.ToInt64(line, 16); //convert from hex to decimal value 

            Console.WriteLine(decimalValue); //print

            

        }
    }
}
