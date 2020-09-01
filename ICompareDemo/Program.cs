using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICompareDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IComparable comparable = "16717" as IComparable;
            int b= comparable.CompareTo("825636");
            if (b>0)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
