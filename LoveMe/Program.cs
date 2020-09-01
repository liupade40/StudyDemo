using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LoveMe
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyClass myClass = new MyClass();
            MyClass2 myClass2 = new MyClass2();
            myClass2.MyProperty = 12;
            myClass.MyProperty = new List<MyClass2>() { myClass2 };
            var ss = JsonConvert.SerializeObject(myClass.MyProperty);
            Console.WriteLine(ss);
            Application.Run(new Form1());
        }
    }
    class MyClass
    {
        public List<MyClass2> MyProperty { get; set; }
    }
    class MyClass2
    {
        public int MyProperty { get; set; }
    }
}
