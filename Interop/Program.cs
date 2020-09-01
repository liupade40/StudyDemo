using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Interop
{
    class Program
    {

        // 在托管代码中对非托管函数进行声明，并且附加平台调用所需要属性
        // 在默认情况下，CharSet为CharSet.Ansi
        // 指定调用哪个版本的方法有两种——通过DllImport属性的CharSet字段和通过EntryPoint字段指定
        // 在托管函数中声明注意一定要加上 static 和extern 这两个关键字        [DllImport("user32.dll")]
        [DllImport("user32.dll")]
        public static extern int MessageBox1(IntPtr hWnd, String text, String caption, uint type);

        //// 在默认情况下，CharSet为CharSet.Ansi
        //[DllImport("user32.dll")]
        //public static extern int MessageBoxA(IntPtr hWnd, String text, String caption, uint type);

        // 在默认情况下，CharSet为CharSet.Ansi
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        // 第一种指定方式，通过CharSet字段指定
        [DllImport("user32.dll", CharSet = CharSet.Unicode,ExactSpelling =false)]
        public static extern int MessageBox2(IntPtr hWnd, String text, String caption, uint type);

        // 通过EntryPoint字段指定
        [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
        public static extern int MessageBox3(IntPtr hWnd, String text, String caption, uint type);

        [DllImport("user32.dll", EntryPoint = "MessageBoxW")]
        public static extern int MessageBox4(IntPtr hWnd, String text, String caption, uint type);

        // 在托管代码中对非托管函数进行声明
        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetFileAttributes(string filename);
        static void Main(string[] args)
        {
            GetFileAttributes("FileNotexist.txt");
            int lastErrorCode = Marshal.GetLastWin32Error();
            Win32Exception win32exception = new Win32Exception(lastErrorCode);
            if (lastErrorCode != 0)
            {
                Console.WriteLine("调用Win32函数发生错误，错误信息为 : {0}", win32exception.Message);
            }
            else
            {
                Console.WriteLine("调用Win32函数成功,返回的信息为： {0}", win32exception.Message);
            }

            Console.Read();
        }
    }
}
