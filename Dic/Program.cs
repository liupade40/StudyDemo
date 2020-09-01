using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["123"] = "123";
            Console.WriteLine(dictionary["123"]);
            dictionary["234"] = "123";
            Console.WriteLine(dictionary["234"]);
            dictionary.Add("345", "345");
            Console.WriteLine(dictionary["345"]);
            Console.ReadKey();
            MyClass class1=new Class2();
            List<MyClass> list = new List<MyClass>();
        }
    }
    class MyClass
    {

    }
    class Class2:MyClass
    {
        public int MyProperty { get; set; }
    }
}
