using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallBack
{
    class Program
    {
        static  void Main(string[] args)
        {
            tes();
            Console.WriteLine("123");
            Console.ReadKey();
        }
        static void back(int s, Action action)
        {
            Console.WriteLine(s);
            action();
        }
        static async Task<int> tes()
        {
          int i=   await TestAsync();
            return i;
        }
        static async Task<int> TestAsync()
        {
           Task.Run(() =>
             {
                 Thread.Sleep(1000);
                 Console.WriteLine("1");
                 
             });
            Console.WriteLine("12333");

            return 1;
        }
    }
    public class MyClass
    {
        public int MyProperty { get; set; }
    }
}
