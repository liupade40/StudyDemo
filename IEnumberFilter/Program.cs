using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumberFilter
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,
            };
            List<int> enumerator = Filter(list, (x) => { return x > 2; }).ToList();
            for (int i = 0; i < enumerator.Count(); i++)
            {
                Console.WriteLine(enumerator[i]);
            }
            Console.ReadKey();
        }

        public static IEnumerable<int> Filter(IEnumerable<int> ObjectList, Func<int, bool> FilterFunc)
        {
            List<int> ResultList = new List<int>();
            foreach (var item in ObjectList)
            {
                if (FilterFunc(item))
                    ResultList.Add(item);
            }
            return ResultList;
        }
    }

}
