using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deltaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "14:31:45 14:46:56"; //test input

            string[] times = line.Split(' '); //split times into string array

            TimeSpan tSpan = (((DateTime.Parse(times[0]) - (DateTime.Parse(times[1]))).Duration())); //calculate time span

            Console.WriteLine(tSpan);



        }
    }
}
