using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse("1", out int i);
            i = 10;
          var p=  Person(1);
            Console.WriteLine(p.age);
        }
        
        static (string name,string age) Person(int index)
        {
            var first = string.Empty;
            var last = string.Empty;

            // Go to database and get names
            var person = new { FirstName = "123", LastName = "456" };
            first = person.FirstName;
            last = person.LastName;

            return (first, last);
        }
    }

}
