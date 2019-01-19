using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttemptAtWriting_13._12._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, -5, 4, 9, 6 };
            TwoSum(arr, 12);
            Console.ReadKey();
        }

        static int[] TwoSum(int[] nums, int target)
        {
            int[] arr3 = { 1 };
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {


                    if (nums[j] == target - nums[i])
                    {
                        //return new int[] { i, j };
                        Console.WriteLine("{0} , {1}",nums[i] ,nums[j]);    
                    }
                }
            }
            //return arr2;

            return arr3;























            /*
            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            {
                if (nums[0] + nums[j] == 7)
                {
                    Console.WriteLine("{0}, {1}", nums[0], nums[i]);
                }
                else Console.WriteLine("BoB");
                //Console.WriteLine("i = {0} , j = {1}", i, j);
            }
            */
            /*
            for(int i = 0; i <nums.Length; i ++)
            {
                for (int j = 0; j < nums.Length; j ++)
                {
                    if (nums[j] + nums[i] == 7)
                    {
                        Console.WriteLine("{0}, {1}", nums[j], nums[i]);
                    }
                    else Console.WriteLine("BoB");
                }
            }
            */

        }
    }
}
