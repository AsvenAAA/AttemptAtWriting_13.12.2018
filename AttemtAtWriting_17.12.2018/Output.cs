using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttemtAtWriting_17._12._2018
{
    class Output
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            string expr;
            Console.OutputEncoding = Encoding.Unicode;
            Hello();
            do
            {
                expr = Console.ReadLine();
                if ((expr == "q") || (expr == "Q") || (expr == "quit") || (expr == "Quit"))
                {
                    Console.WriteLine("Good luck Bro, i whant to see you again :D");
                    Console.ReadKey();
                    break;
                }
                if (expr == "")
                    Console.WriteLine();
                fundamental.Input();
            }
            while (expr != "q" || expr != "Q" || expr != "quit" || expr != "Quit");
        }
    }
}
