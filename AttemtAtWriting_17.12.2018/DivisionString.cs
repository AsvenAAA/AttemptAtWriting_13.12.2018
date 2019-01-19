using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AttemtAtWriting_17._12._2018
{
    class DivisionString
    {
        private string inputExpression;
        private double result;

        public string InputExpression
        {
            get { return inputExpression; }
            set
            {
                if (inputExpression == null)
                    Console.WriteLine("Please enter an expression or close the programm (q)");
                inputExpression = value;
            }
        }
        public double ResultAllExpression
        {
            get { return result; }
            set
            {
                if (result < (-1.7 * Math.Pow(10, 324)) || result < (1.7 * Math.Pow(10, 324))
                  || result < (-5 * Math.Pow(10, -324)) || result < (5 * Math.Pow(10, -324)))
                    Console.WriteLine("You entered a number outside the range");
                else result = value;
            }
        }

        public string[] DistinguishNumbers()
        {
            string pattern = @"[-+*/]";
            string[] numbers = Regex.Split(InputExpression, pattern);
            return numbers;
        }

        public string[] DistinguishOperators()
        {
            string pattern = @"[0-9]";
            string[] operators = Regex.Split(InputExpression, pattern);
            return operators;
        }

        public void DivisionSt(string[] numbers, string[] operators)
        {
            string pattern = @"[-+*/]";
            int x = int.Parse(numbers[0]);

            for (int i = 1, j = 0; i < 5 & j < 4; i++, j++)
            {
                string expression = $@"{x}{operators[j]}{numbers[i]}";
                string[] splitter = Regex.Split(expression, pattern);


                foreach (Match match in Regex.Matches(expression, pattern))
                {
                    switch (match.Value)
                    {
                        case "+":
                            x += int.Parse(numbers[i]);
                            break;
                        case "-":
                            x -= int.Parse(numbers[i]);
                            break;
                        case "*":
                            x *= int.Parse(numbers[i]);
                            break;
                        case "/":
                            x /= int.Parse(numbers[i]);
                            break;
                    }
                }
            }
            Console.WriteLine(x);
        }
    }
}
