using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockingCollectionTest
{
    class Program
    {
        static BlockingCollection<int>  bc = new BlockingCollection<int>();

        static void Main(string[] args)
        {
            
            Task.Factory.StartNew(ConsumeTask);
            Task.Factory.StartNew(ProduceTask);
            Console.ReadKey();
        }
        private static void ProduceTask()
        {
            foreach (var item in Enumerable.Range(1, 100))
            {
                //Console.WriteLine(string.Format("+++++++++++++: {0}", item));
                Thread.Sleep(3000);
                bc.Add(item);
            }
            bc.CompleteAdding();
        }

        private static void ConsumeTask()
        {
            foreach (var item in bc.GetConsumingEnumerable())
            {
                Console.WriteLine(string.Format("---------------: {0}", item));
            }
        }
    }
}
