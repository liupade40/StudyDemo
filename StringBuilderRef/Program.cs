using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderRef
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyClass db=new MyClass();
            Foo(db);
            Console.WriteLine(db.MyProperty);//test
            Console.ReadLine();
        }
        static void Foo( MyClass foosb)
        {

            foosb.MyProperty="test";
            foosb = null;
            //Console.WriteLine(foosb.MyProperty);
        }
    }
    public class MyClass
    {
        public string MyProperty { get; set; }
    }
}
