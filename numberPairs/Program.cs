using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "2,4,5,6,9,11,15;20"; //test input

            string[] splitLine = line.Split(';'); //split string at semicolon into [] "splitLine"
            string[] nums = splitLine[0].Split(','); //split numbers at commas into [] "nums"

            int sum = int.Parse(splitLine[1]); //parse number to add for to int "sum"

            int[] digits = new int[nums.Length]; //new int array "digits"
            for (int i = 0; i <= nums.Length - 1; i++)
                {
                digits[i] = int.Parse(nums[i]); //parse string nums to int and fill int [] "digits"
                }

            StringBuilder answers = new StringBuilder();

            for (int n = 0; n <= digits.Length - 1; n++) //for each number in int [] "digits"
            {
                for (int m = 0; m <= digits.Length - 1; m++) //and the numbers after it
                {
                    if (digits[n] + digits[m] == sum && n < m) //if the nth index and mth index equal the sum and n < m
                    {
                        string answer = (digits[n] + "," + digits[m] + ";"); //
                        answers.Append(answer); //append the answer to the Stringbuilder "answers"
                    }
                    else
                    { }

                }
            }

            string results = answers.ToString(); //conver StringBuilder "answers" to string "results"
            Console.WriteLine(nullorTrim(results)); //write string "results" after trimming, or NULL 

        }

        static string nullorTrim (string stringToTrim)
        {
            if (String.IsNullOrEmpty(stringToTrim))
            {
                string nullString = "NULL";
                return nullString;
            }
            else
            {
                string trimmedString = stringToTrim.TrimEnd(stringToTrim[stringToTrim.Length - 1]);
                return trimmedString;
            }
        }



    }


        }

