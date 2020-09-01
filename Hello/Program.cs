using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                var i = 10;
                int* iptr = &i;    //将i的地址赋值给iptr
                Console.WriteLine((int)&iptr);  //取iptr得地址
                Console.WriteLine(*iptr);
                *iptr = 12;
                Console.WriteLine(*iptr);     //取iptr指向的值
                Console.ReadKey();
            }
           
            IList < string >list= new List<string>();
            list.Add("111");
            var s = list.Count();
            list.Add("22");
            Console.Write(s);
        }
        
    }
    
}
