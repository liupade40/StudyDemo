using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestAsync();
            //Console.WriteLine("23," + Thread.CurrentThread.ManagedThreadId.ToString());
            
            Console.ReadKey();
        }

        private static  void TestAsync()
        {

             NewMethod();
            Console.WriteLine("333," + Thread.CurrentThread.ManagedThreadId.ToString());
        }

        private static async void NewMethod()
        {
            Thread.Sleep(3000);
            ss();
            Console.WriteLine("666," + Thread.CurrentThread.ManagedThreadId.ToString());
            var str = await Task.Run(() =>
            {
                Thread.Sleep(6000);
                return "1,"+ Thread.CurrentThread.ManagedThreadId.ToString();
            });
            Console.WriteLine(str);
            await Task.Run(() => { Console.WriteLine("2," + Thread.CurrentThread.ManagedThreadId.ToString()); });
        }
        public static async void ss()
        {
           // 
           await  Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("5," + Thread.CurrentThread.ManagedThreadId.ToString());
            });
            
        }
    }
}
