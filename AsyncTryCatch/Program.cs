using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTryCatch
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //处理未捕获的异常，始终将异常传送到 ThreadException 处理程序。忽略应用程序配置文件。     

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            //订阅ThreadException事件，处理UI线程异常，处理方法为 Application_ThreadException，关于事件的相关知识就不在这叙述了    

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);

            //订阅UnhandledException事件，处理非UI线程异常 ，处理方法为 CurrentDomain_UnhandledException    

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message + ",全局捕获了异常2");
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message + ",全局捕获了异常3");
        }
    }
}
