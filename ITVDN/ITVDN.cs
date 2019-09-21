using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN
{
    //class ITVDN
    //{
    //    static void Main(string[] args)
    //    {

    //        PairValuesArray(5);
    //        Console.WriteLine(SumArguments(PairValuesArray(5)));

    //        //Par();
    //        //Console.WriteLine($"First: {PairValuesArray(5)}  *****  Second: {Par()}");
    //        foreach (int a in PairValuesArray(5))
    //            Console.WriteLine(a);

    //        Console.ReadKey();
    //    }

    //    static int[] PairValuesArray(int n)
    //    {
    //        int seatСontroller = 0;
    //        int aL = n / 2 + 1;
    //        int[] array = new int[aL];
    //        for (int i = 0; i <= n; i++)
    //        {
    //            if (i % 2 == 0)
    //            {
    //                array[seatСontroller] = i;
    //                seatСontroller++;
    //            }
    //        }
    //        return array;
    //    }
    //    static int[] Par()
    //    {
    //        int[] x = new int[2];
    //        x[0] = 1;
    //        x[1] = 2;
    //        return x;
    //    }

    //    static int SumArguments(params int[] arguments)
    //    {
    //        int sum = 0;
    //        for(int i = 0; i < arguments.Length; i++)
    //        {
    //            sum += arguments[i];
    //        }
    //        return sum;
    //    }
    //}

    class Program
    {
        public static void Main()
        {
            MyClass myClass = new MyClass();

            Console.WriteLine(myClass.X);
        }
    }

    class MyClass
    {
        int x;

        public int X { get { return x; } }

        public MyClass() { }

        public MyClass(int x)
        {
            this.x = x;
        }
    }


}
