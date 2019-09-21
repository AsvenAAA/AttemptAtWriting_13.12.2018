using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OverloraParse
{
    //class Testing
    //{
    //    public double yearGain;
    //    public int bonus;
    //    public string workerName;

    //    public Testing(double yG = 502000, int b = 0, string wN = "Edward")
    //    {
    //        if (yG <= 502000 & wN == "Edward")
    //        {
    //            b += 50;
    //            yG = yG / 100 * b + yG;
    //        }
    //        else
    //        {
    //            yG = yG / 100 * b + yG;
    //        }
    //        yearGain = yG;
    //        bonus = b;
    //        workerName = wN;
    //    }

        //public Testing()
        //{
        //    yearGain = 502000;
        //    bonus = 0;
        //    workerName = "Edward";
        //}

        //public Testing(double yG)
        //: this(yG, 0, "") { }

        //public Testing(int b)
        //: this(0, b, "") { }

        //public Testing(string wN)
        //: this(0, 0, wN) { }

        //public Testing(double yG, int b, string wN)
        //{

        //    if (yG <= 502000 & wN == "Edward")
        //    {
        //        b += 50;
        //        yG = yG / 100 * b + yG;
        //    }
        //    else
        //    {
        //        yG = yG / 100 * b + yG;
        //    }
        //    yearGain = yG;
        //    bonus = b;
        //    workerName = wN;
        //}

        //void MyGain()
        //{
        //    Console.WriteLine($"The name is {workerName}, his gain is {yearGain}");
        //}

   class Test
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            a = a.Replace('.', ',');

            string pattern = @"[-+*/]";
            string[] numbers = Regex.Split(a, pattern);
            string[] operators = Regex.Split(a, @"[0-9]");

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

            double x = double.Parse(numbers[0]);

            for (int i = 1, j = 0; i < numbers.Length & j < realoperators.Length ; i ++, j ++)
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
            Console.ReadKey();
        }


        #region Hello
        static void Hello(string greeting = "Hello my friend!", string representation = "I'am a calculator :D", string skills = "I can add, substruction, multiply and divide!!!")
        {
            Console.WriteLine(greeting);
            Console.WriteLine(representation);
            Console.WriteLine(skills);
        }
        #endregion

        #region Add

        //static double Add(double number)
        //{
        //    double res = x + y;
        //    return res;
        //}

        //static decimal add( decimal x,  decimal y)
        //{
        //    decimal res = x + y;
        //    return res;
        //}
        #endregion

        #region Substruction

        static double Sub(double x, double y)
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

        static double Mult(double x, double y)
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

        static double Div(double x, double y)
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
    }
}


