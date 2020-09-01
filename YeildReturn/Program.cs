using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeildReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = Yield();
            foreach (var item in result)
            {

            }
            Console.ReadKey();
        }
        static IEnumerable<int> Yield()
        {
            yield return 1;
            yield return 1;
            yield break;
            Console.WriteLine(1);
        }
    }
}
