using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariant
{
    class Program
    {
        public delegate T Mydel<out T>();
        static void Main(string[] args)
        {
            Mydel<string> str1 = () => "1111";
            Mydel<object> obj1 = str1;
            Console.WriteLine(obj1.Invoke());
            Console.ReadKey();
        }
        static string str1()
        {
            return "";
        }
    }
}
