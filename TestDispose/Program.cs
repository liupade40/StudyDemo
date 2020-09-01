using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Factory f = new Factory())
            {
                f.MakeSomeGarbage();
                Console.WriteLine("Total memory is {0} KBs.", GC.GetTotalMemory(false) / 1024);
            }

            Console.WriteLine("After GC total memory is {0} KBs.", GC.GetTotalMemory(false) / 1024);

            Console.Read();
        }
    }
    public class Factory : IDisposable
    {
        private StringBuilder sb = new StringBuilder();
        List<int> list = new List<int>();

        //拼接字符串，创造一些内存垃圾
        public void MakeSomeGarbage()
        {
            for (int i = 0; i < 100; i++)
            {
                sb.Append(i.ToString());
            }
        }

        //销毁类时，会调用析构函数
        ~Factory()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
            sb = null;
            GC.Collect();
            GC.SuppressFinalize(this);
        }
    }
}
