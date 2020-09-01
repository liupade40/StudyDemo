using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public delegate void MyEvent(object sender, CallHanlder call);
    class Program
    {
        static void Main(string[] args)
        {
            Kettle k = new Kettle();
            k.MyEvent += K_MyEvent ;
            k.Boiled();
            Console.ReadKey();
        }

        private static void K_MyEvent(object sender, CallHanlder call)
        {
            Console.WriteLine("水烧开了，温度是{0}",call.Temperature);
        }
    }
    public class Kettle
    {
        public int Temperature { get; set; }
        public event MyEvent MyEvent;
        public void Boiled()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i>95)
                {
                    MyEvent?.Invoke(this, new CallHanlder(i));
                }
            }
        }
    }
    public class CallHanlder
    {
        public int Temperature { get; set; }
        public CallHanlder(int temp)
        {
            Temperature=temp;
        }
    }
}
