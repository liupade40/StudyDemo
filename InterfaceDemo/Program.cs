using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
           
            int[] ar =new int[] { 1, 3, 4, 5, 6, 7 ,8,9,11,12,13,14,15};
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i]==14)
                {
                    Console.WriteLine(i);
                }
            }
            int s = Method(ar, 0,ar.Length-1,14);
            Console.WriteLine(s);
           // Console.WriteLine(ar[s]);
            Console.ReadKey();
        }
        public static int Method(int[] nums, int low, int high, int target)
        {
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (target == nums[middle])
                {
                    return nums[middle];
                }
                else if (target > nums[middle])
                {
                    low = middle + 1;
                }
                else if (target < nums[middle])
                {
                    high = middle - 1;
                }
            }
            return -1;
        }
        static int binarySerach(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            // 这里必须是 <=
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
    public interface IStudent
    {
         int Id { get; set; }
    }
    class Student : IStudent
    {
        public int Id { get; set; }
    }
}
