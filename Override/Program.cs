using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Son s = new Son();
            
            Console.WriteLine(s.MyProperty);
            Console.ReadKey();
        }
    }
    class Base
    {
        public Base()
        {
            method();
        }
        public int MyProperty { get; set; }
        public virtual void method()
        {
            MyProperty = 20;
        }
    }
    class Son : Base
    {
        public override void method()
        {
            MyProperty = 30;
        }
    }
}
