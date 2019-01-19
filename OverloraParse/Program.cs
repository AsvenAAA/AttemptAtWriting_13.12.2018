using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OverloraParse
{
    class Program
    {
        enum EmpType: byte
        {
            Bob = 1,
            Robin,
            Bill

        }

        static void Main(string[] args)
        {
            EmpType emp = EmpType.Bill;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            Asker(emp);
            Asker(day);
            Asker(cc);
            Console.ReadLine();
            
        }

        static void Asker(Enum e)
        {
            Console.WriteLine("UnderlyingType: {0}", Enum.GetUnderlyingType(e.GetType()));
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("Number of members: {0}", enumData.Length);
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:X}", enumData.GetValue(i));
            }
        }

    }


}   

