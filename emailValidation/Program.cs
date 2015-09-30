using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace emailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = ".ad_mi?n@codeeval.com"; //test input

            //Regex isValid = new Regex("^.+@.+\\.[a-z]+$");
            //first attempt (70%)

            //Regex isValid = new Regex("^[a-zA-Z0-9!#$%&'*+_/=//?//^{|}~]+@[a-zA-Z0-9]+//.[a-zA-Z]+$");
            //second attempt (40%)

            Regex isValid = new Regex("^[^\\.]\\w+([-+.']\\w+)*[^\\.]@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$", RegexOptions.IgnoreCase);
            //from http://www.mikesdotnetting.com/article/46/c-regular-expressions-cheat-sheet
            //gets 95% on Codeeval 

            //Regex isValid = new Regex("^[^\\.][a-z0-9!#$%&'*+-/='_\\{|\\}~\\?\\^][^\\.]+@[a-z0-9]+\\.[a-z]{2,4}", RegexOptions.IgnoreCase);
            //third attempt (40%)

            if (isValid.IsMatch(line))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
