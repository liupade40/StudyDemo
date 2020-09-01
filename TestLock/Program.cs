using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestLock
{
    class Program
    {
        private static object obj = new object();
        
        static void Main(string[] args)
        {
            Thread t1 = new Thread(write);
            t1.Start();
            Thread t2 = new Thread(write);
            t2.Start();
            Console.Read();
        }
        private static void write()
        {
            Console.WriteLine("进入的线程id为{0}", Thread.CurrentThread.ManagedThreadId);
            
            lock (obj)
            {
                Console.WriteLine("正在操作的线程id为{0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(5000);
                Console.WriteLine("退出的线程id为{0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
