using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Program
    {
        /// <summary>
        /// 启动一个简单的http服务，只能处理静态资源
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string myFolder = @"F:\HD";

            //create server with auto assigned port
            SimpleHTTPServer myServer = new SimpleHTTPServer(myFolder);
            Console.WriteLine(myServer.Port);
            Console.ReadKey();
        }
    }
}
