using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = Algorithm.Method(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 ,12,13,14,50,55}, 50);
            Console.WriteLine(i);
            var i2 = Algorithm.BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 14, 50, 55 }, 50);

            Console.WriteLine(i2);
            Console.ReadKey();
        }
    }
    class Algorithm
    {
        /// <summary>
        /// 二分查找算法
        /// </summary>
        /// <param name="a">有序数组</param>
        /// <param name="key">要找的数字</param>
        /// <returns>要找数字所在的索引</returns>
        public static int BinarySearch(int[] a, int key)
        {
            int lo = 0;
            int hi = a.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (key < a[mid]) hi = mid - 1;
                else if (key > a[mid]) lo = mid + 1;
                else return mid;
            }
            return -1;
        }
        public static int Method(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (target > nums[middle])
                {
                    low = middle+1;
                }
                else if (target < nums[middle])
                {
                    high = middle-1 ;
                }
            }
            return -1;
        }
    }
}
