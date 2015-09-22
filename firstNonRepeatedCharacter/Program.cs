using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNonRepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "octopus"; //test input

            for(int i = 0; i <= line.Length-1; i++)
                {
                if(line.LastIndexOf(line[i]) == line.IndexOf(line[i]))
                    {
                    Console.WriteLine(line[i]);
                    break;
                     }
                else
                { continue; }
                 }
        }
    }
}
