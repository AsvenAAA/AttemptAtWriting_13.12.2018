using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AttemptAtWriting_13._12._2018
{
    class Program
    {

        static void Main(string[] args)
        {

            GetClasses getCl = new GetClasses(Console.ReadLine());
            getCl.Show();
            Console.ReadLine();   
        }
    }
}
