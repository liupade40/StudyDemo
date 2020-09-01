using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);

            var request = WebRequest.Create("https://github.com/");//为了更好的演示效果，我们使用网速比较慢的外网
            WebResponse respose = request.GetResponse();//发送请求    
            Stream stream= respose.GetResponseStream();
            StreamReader sr = new StreamReader(stream, Encoding.UTF8);
            
            string result = sr.ReadToEnd();
            
            sr.Dispose();
            //StreamReader sr2 = new StreamReader(stream, Encoding.UTF8);
            Debug.WriteLine(result);
            Debug.WriteLine("【Debug】线程ID:" + Thread.CurrentThread.ManagedThreadId);
            label1.Text = "执行完毕！";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1、APM 异步编程模型，Asynchronous Programming Model
            //C#1[基于IAsyncResult接口实现BeginXXX和EndXXX的方法]             
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);

            var request = WebRequest.Create("https://github.com/");
            request.BeginGetResponse(new AsyncCallback(t =>//执行完成后的回调
            {
                var response = request.EndGetResponse(t);
                var stream = response.GetResponseStream();//获取返回数据流 

                using (StreamReader reader = new StreamReader(stream))
                {
                    StringBuilder sb = new StringBuilder();
                    while (!reader.EndOfStream)
                    {
                        var content = reader.ReadLine();
                        sb.Append(content);
                    }
                    Debug.WriteLine("【Debug】" + sb.ToString().Trim().Substring(0, 100) + "...");//只取返回内容的前100个字符 
                    Debug.WriteLine("【Debug】异步线程ID:" + Thread.CurrentThread.ManagedThreadId);
                    label1.Invoke((Action)(() => { label1.Text = "执行完毕！"; }));//这里跨线程访问UI需要做处理
                    
                }
            }), null);

            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }

        private async  void button3_ClickAsync(object sender, EventArgs e)
        {
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
            //Task.Run(() => { Thread.Sleep(1000); Debug.WriteLine("18"); });
            HttpClient http = new HttpClient();
            await GetNumber();
            //Console.WriteLine(htmlStr);
            //（1）处理请求结果的逻辑可以写这里
            Debug.WriteLine("[新异步]执行完毕！");//（2）不在需要做跨线程UI处理了
            Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId);
        }
        private async Task GetNumber()
        {
            await Task.Run(() => { Thread.Sleep(1000); Debug.WriteLine("【Debug】主线程ID:" + Thread.CurrentThread.ManagedThreadId); Debug.WriteLine("12"); });
        }

        private void button_Click(object sender, EventArgs e)
        {
            Fun(()=>{
                Thread.Sleep(2000);
                Console.WriteLine("执行完了");
            });
        }
        public void Fun(Action action)
        {
            action?.BeginInvoke(null,null);
        }
    }
}
