using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttemtAtWriting_17._12._2018
{
    class Program
    {
        public static string inp;

        static void Main(string[] args)
        {
            string ansver;
            Hello();
            do
            {
                inp = Console.ReadLine();
                Input();
                Console.Write("Press <y> if you want to continue: ");
                ansver = Console.ReadLine();
            }
            while (ansver == "y" || ansver == "yes" || ansver == "Yes" || ansver == "YES");
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

        //static double Add(ref double x, ref double y)
        //{
        //    x = double.Parse(NumberOne());
        //    y = double.Parse(NumberTwo());
        //    double res = x + y;
        //    return res;
        //}

        static decimal Add(ref decimal x, ref decimal y)
        {
            x = decimal.Parse(NumberOne());
            y = decimal.Parse(NumberTwo());
            decimal res = x + y;
            return res;
        }
        #endregion

        #region Substruction
  
        //static double Sub(ref double x, ref double y)
        //{
        //    x = double.Parse(NumberOne());
        //    y = double.Parse(NumberTwo());
        //    double res = x - y;
        //    return res;
        //}
        static decimal Sub(ref decimal x, ref decimal y)
        {
            x = decimal.Parse(NumberOne());
            y = decimal.Parse(NumberTwo());
            decimal res = x - y;
            return res;
        }
        #endregion

        #region Multiplication
        
        //static double Mult(ref double x, ref double y)
        //{
        //    x = double.Parse(NumberOne());
        //    y = double.Parse(NumberTwo());
        //    double res = x * y;
        //    return res;
        //}
        static decimal Mult(ref decimal x, ref decimal y)
        {
            x = decimal.Parse(NumberOne());
            y = decimal.Parse(NumberTwo());
            decimal res = x * y;
            return res;
        }
        #endregion

        #region Division
      
        //static double Div(ref double x, ref double y)
        //{
        //    x = double.Parse(NumberOne());
        //    y = double.Parse(NumberTwo());
        //    double res = x / y;
        //    return res;
        //}
        static decimal Div(ref decimal x, ref decimal y)
        {
            x = decimal.Parse(NumberOne());
            y = decimal.Parse(NumberTwo());
            decimal res = x / y;
            return res;
        }
        #endregion

        #region Numbers
        static string NumberOne()
        {
            char[] operatorsChars = { '+', '-', '*', '/', ' ' };
            string[] numbers = inp.Split(operatorsChars);
            string firstNumber = numbers[0].Replace('.', ',');
            return firstNumber;
        }
        static string NumberTwo()
        {
            char[] operatorsChars = { '+', '-', '*', '/', ' ' };
            string[] numbers = inp.Split(operatorsChars);
            string secondNumber = numbers[1].Replace('.', ',');
            return secondNumber;
        }
        #endregion

        //#region ParseNumbers

        //static int ParseFirstNumber(int x)
        //{
        //    x = int.Parse(NumberOne());
        //    return x;
        //}
        //static int ParseSecondNumber(int y)
        //{
        //    y = int.Parse(NumberTwo());
        //    return y;
        //}
        
        //static double ParseFirstNumber(double x)
        //{
        //    x = double.Parse(NumberOne());
        //    return x;
        //}
        //static double ParseSecondNumber(double y)
        //{
        //    y = double.Parse(NumberTwo());
        //    return y;
        //}
        //#endregion

        static void Input()
        {
            decimal argumentRef1 = 0;
            decimal argumentRef2 = 0;
            string operators;    
            Regex search = new Regex(@"\W+-*/\W", RegexOptions.IgnorePatternWhitespace);
            MatchCollection matches = search.Matches(inp);
            char[] operatorsChars = { '+', '-', '*', '/', ' ' };
            string [] numbers = inp.Split(operatorsChars);
            foreach (Match match in matches)
            {
                operators = match.Value;
                if (operators == "+") Console.WriteLine(Add(ref argumentRef1, ref argumentRef2));
                if (operators == "-") Console.WriteLine(Sub(ref argumentRef1, ref argumentRef2));
                if (operators == "*") Console.WriteLine(Mult(ref argumentRef1, ref argumentRef2));
                if (operators == "/") Console.WriteLine(Div(ref argumentRef1, ref argumentRef2));
            }
        }
    }
}
