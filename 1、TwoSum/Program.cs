using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TwoSum
{
    class Program
    {
        #region 题目描述
        //给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
        //示例:
        //给定 nums = [2, 7, 11, 15], target = 9
        //因为 nums[0] + nums[1] = 2 + 7 = 9
        //所以返回[0, 1]
        #endregion
        static void Main(string[] args)
        {
            var array = TwoSum(new int[] { 3,3 }, 6);
            if (array.Length == 0)
            {
                Console.Write("Not Found Two Sum");
            }
            else
            {
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
            MyClass1.S();
            MyClass1.S();
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ar = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    var sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        ar[0] = i;
                        ar[1] = j;
                        return ar;
                    }
                }
            }
            return ar;
        }
        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new ArgumentOutOfRangeException("No two sum solution");
        }
    }
    public static class  MyClass1
    {
        static MyClass1()
        {
            Console.WriteLine("我是静态构造函数");
        }
        public static void S() { }
    }
}
