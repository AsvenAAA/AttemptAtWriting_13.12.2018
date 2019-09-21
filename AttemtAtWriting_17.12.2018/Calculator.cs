using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttemtAtWriting_17._12._2018
{
    class Calculator
    {
        //private string inputExpression;
        //private double result;

        //public string InExp
        //{
        //    get { return inputExpression; }
        //    set
        //    {
        //        if (inputExpression == null)
        //            Console.WriteLine("Please enter an expression or close the programm (q)");
        //        inputExpression = value;
        //    }
        //}
        //public double ResultAllExpression
        //{
        //    get { return result; }
        //    set
        //    {
        //        if (result < (-1.7 * Math.Pow(10, 324)) || result < (1.7 * Math.Pow(10, 324)) 
        //          || result < (-5 * Math.Pow(10, -324)) || result < (5 * Math.Pow(10, -324)))
        //                Console.WriteLine("You entered a number outside the range");
        //        else result = value;
        //    }
        //}

        public Calculator() { }

        #region Hello
        static void Hello(string greeting = "Hello my friend!", string representation = "I'am a calculator :D", string skills = "I can add, substruction, multiply and divide!!!")
        {
            Console.WriteLine(greeting);
            Console.WriteLine(representation);
            Console.WriteLine(skills);
        }
        #endregion

        #region Add

        static double Add(double x, double y)
        {
            double res = x + y;
            return res;
        }

        //static decimal add( decimal x,  decimal y)
        //{
        //    decimal res = x + y;
        //    return res;
        //}
        #endregion

        #region Substruction

        static double Sub( double x,  double y)
        {
            double res = x - y;
            return res;
        }
        //static decimal Sub( decimal x,  decimal y)
        //{
        //    decimal res = x - y;
        //    return res;
        //}
        #endregion

        #region Multiplication

        static double Mult( double x,  double y)
        {
            double res = x * y;
            return res;
        }
        //static decimal Mult( decimal x,  decimal y)
        //{
        //    decimal res = x * y;
        //    return res;
        //}
        #endregion

        #region Division

        static double Div( double x,  double y)
        {
            double res = x / y;
            return res;
        }
        //static decimal Div( decimal x,  decimal y)
        //{
        //    try
        //    {
        //        decimal res = x / y;
        //        return res;
        //    }
        //    catch (DivideByZeroException exception)
        //    {
        //        return double.PositiveInfinity;     //Должен возвращать decimal, бесконечность не выдаст
        //    }
        //}
        #endregion


        public void DivisionIntoArgumentsAndOperators()
        {
            string pattern = @"[-+*/]";
            string[] numbers = Regex.Split(InExp, pattern);
            //string firstNumber = numbers[0];
            //string secondNumber = numbers[1];
            //double fNumber = double.Parse(numbers[0]);
            //double sNumber = double.Parse(numbers[1]);
            int x = int.Parse(numbers[0]);
            string[] operators = new string[] { "+", "/", "*", "-" };

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




            //Cогласно документации MSDN https://docs.microsoft.com/ru-ru/dotnet/standard/base-types/best-practices 
            //так делать не эффективно 
            //так как при каждом вызове метода будет заново создаватьс объект Regex с одним и тем же шаблоном. 
            //А это значит, что при каждом вызове метода шаблон регулярного выражения будет перекомпилироваться
            //Regex search = new Regex(@"[- + * /]", RegexOptions.IgnorePatternWhitespace);
            // MatchCollection matches = search.Matches(inp);

            //foreach (Match match in Regex.Matches(InExp, pattern))
            //{
            //    switch (match.Value)
            //    {
            //        case  "+":
            //            Console.WriteLine(Add(fNumber, sNumber));
            //            break;
            //        case "-":
            //            Console.WriteLine(Sub(fNumber, sNumber));
            //            break;
            //        case "*":
            //            Console.WriteLine(Mult(fNumber, sNumber));
            //            break;
            //        case "/":
            //            Console.WriteLine(Div(fNumber, sNumber));
            //            break;
            //    }
            //}
        }
    }
}
