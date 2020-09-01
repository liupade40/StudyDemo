using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Abstract
{
    class Program
    {
        
        /// <summary>
        /// 1、有一个抽象类，有子类继承该抽象类。
        /// 2、然后通过传过来的子类名，反射实例化该类，
        /// 3、通过父类去调用抽象方法。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine(MyClass.Add(1, 1));
            //IntPtr ptr=IntPtr.Zero;
            //MyClass.Add2(ptr);
            //Console.WriteLine(ptr);
            string str3 = "111";
            string str2 = "111";
            int i = 1;
            int i2 = 1;
            Console.WriteLine(object.ReferenceEquals(i,i2));

            List<char> list = new List<char>();
            string str = "前几天，有一个做测试的问我.NET Framework是什么，是什么关系呢和C#是什么关系呢";
            list = str.ToList();
            var linq = from c in list
                       group c by c into g
                       select new
                       {
                           key = g.Key,
                           count = g.Count(x=>g.Key==x)

                       };

            foreach (var item in linq)
            {
                Console.WriteLine($"{item.key}==={item.count}");
            }
            Console.ReadKey();
        }
    }
    static class MyClass
    {
        [DllImport("Dll1.dll", CharSet = CharSet.Ansi, EntryPoint = "Add", CallingConvention = CallingConvention.Cdecl)]
        public extern static int Add(int a, int b);
        [DllImport("Dll1.dll", CharSet = CharSet.Ansi, EntryPoint = "Add2", CallingConvention = CallingConvention.Cdecl)]
        public extern static void Add2(IntPtr ptr);
    }

}
