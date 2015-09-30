using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestLines_2ndattempt
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder allLines = new StringBuilder(); //new StringBuilder allLines

            using (StreamReader reader = File.OpenText(args[0])) 
                while (!reader.EndOfStream) 
                {
                    string line = reader.ReadLine(); 
                    if (null == line)
                    { continue; } //breaks loop if string is null 
                    allLines.Append(line + '*'); //append line to StringBuilder "allLines" with asterisk for splitting later
                }

            string capturedLines = allLines.ToString();

            string[] lineArray = capturedLines.Split('*');

            int num = int.Parse(lineArray[0]); //parses first entry to int 

            Array.Sort(lineArray, (x1, x2) => x1.Length.CompareTo(x2.Length)); //sorts the array shortest - longest

            //print out n longest lines
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(lineArray[lineArray.Length - i]);
            }

        }//end of main method


    }
}
