using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "JavaScript language 1.8"; //test input

            StringBuilder newCase = new StringBuilder();

            char[] chars = line.ToCharArray(); //convert line to char[]

            foreach(char c in chars) //check if upper/lower case, convert and append to StringBuilder
            {
                if (char.IsUpper(c))
                { newCase.Append(char.ToLower(c)); }
                else if (char.IsLower(c))
                { newCase.Append(char.ToUpper(c)); }
                else
                { newCase.Append(c); }
            }

            Console.WriteLine(newCase.ToString()); //convert StringBuilder to string and write
        }
    }
}
