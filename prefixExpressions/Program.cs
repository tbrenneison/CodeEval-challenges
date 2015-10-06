using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prefixExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Your program should read this file and insert it into any data structure you like. 
            Traverse this data structure and evaluate the prefix expression. 
            Each token is delimited by a whitespace. 
            You may assume that sum ‘+’, multiplication ‘*’ and division ‘/’ are the only valid operators 
                appearing in the test data.
            */

            //**THINK ABOUT DATA TYPES??? ARE INTEGERS INTEGERS??? melllllllll... 
            //you need to use doubles because of division haaaaaaa I get it now

            string line = "* + 2 3 4"; //test input
            string[] splitLine = line.Split(' ');
            Array.Reverse(splitLine); //make postfix hurr durr

            Stack<double> values = new Stack<double>();

            foreach (string token in splitLine)
            {
                double n;
                if (double.TryParse(token, out n)) //if token is a numerical value
                {
                    values.Push(n);
                }
                else //if an operator
                {
                    double a = values.Pop();
                    double b = values.Pop();
                    double result;
                    switch (token) //do some math 
                    {
                        case "+":
                            result = a + b;
                            values.Push(result);
                            break;
                        case "*":
                            result = a * b;
                            values.Push(result);
                            break;
                        case "/":
                            if (b != 0) //diving by zero not a good life idea 
                            {
                                result = a / b;
                                values.Push(result);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(values.Peek());


        }//end of main method

        
    }
}
