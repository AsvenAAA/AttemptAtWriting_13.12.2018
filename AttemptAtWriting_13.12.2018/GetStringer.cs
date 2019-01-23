using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AttemptAtWriting_13._12._2018
{
    class GetStringer
    {
        private string inputExpression;
        private double mainVariable;
        //private const string patternOper = @"[0-9]";
        //private const string patternNumb = @"[-+*/]";

        public string InputExpression
        {
            get { return inputExpression; }
            set
            {
                if (inputExpression == null)
                    Console.WriteLine("Please enter an expression or close the programm (q)");
                inputExpression = value.Replace('.', ',');
            }
        }
        public double MainVarieble
        {
            get { return mainVariable; }
            set
            {
                if (mainVariable < (-1.7 * Math.Pow(10, 324)) || mainVariable < (1.7 * Math.Pow(10, 324))
                  || mainVariable < (-5 * Math.Pow(10, -324)) || mainVariable < (5 * Math.Pow(10, -324)))
                    Console.WriteLine("You entered a number outside the range");
                else mainVariable = value;
            }
        }

        //public string[] DistinguishNumbers()
        //{
        //    //string pattern = @"[-+*/]";
        //    string[] numbers = Regex.Split(InputExpression, patternNumb);
        //    return numbers;
        //}

        //public string[] DistinguishOperators()
        //{
        //    //string pattern = @"[0-9]";
        //    string[] operators = Regex.Split(InputExpression, patternOper);
        //    return operators;
        //}

        public void DivisionSt(/*string[] numbers, string[] operators*/)
        {
            string pattern = @"[-+*/]";
            
            string[] numbers = Regex.Split(InputExpression, pattern);
            double x = double.Parse(numbers[0]);
            string[] operators = Regex.Split(InputExpression, @"[0-9]");

            int lengthRealoperators = numbers.Length - 1;
            int len = operators.Length;

            string[] realoperators = new string[lengthRealoperators];

            for (int i = 0, j = 0; i < len & j < lengthRealoperators; i++)
            {
                if (operators[i] == "+" ||
                    operators[i] == "-" ||
                    operators[i] == "*" ||
                    operators[i] == "/")
                {
                    realoperators[j] = operators[i];
                    j++;
                }
            }
            //int x = int.Parse(DistinguishNumbers()[0]);

            for (int i = 1, j = 0; i < 5 & j < 4; i++, j++)
            {
                string expression = $@"{x}{realoperators[j]}{numbers[i]}";
                string[] splitter = Regex.Split(expression, pattern);

                foreach (Match match in Regex.Matches(expression, pattern))
                {
                    switch (match.Value)
                    {
                        case "+":
                            x += double.Parse(numbers[i]);
                            break;
                        case "-":
                            x -= double.Parse(numbers[i]);
                            break;
                        case "*":
                            x *= double.Parse(numbers[i]);
                            break;
                        case "/":
                            x /= double.Parse(numbers[i]);
                            break;
                    }
                }
            }
            Console.WriteLine(x);

        }
    }
}