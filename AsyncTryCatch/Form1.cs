using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTryCatch
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            NewMethod1();
            // Console.ReadKey();
        }

        private static void NewMethod1()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "1");
            GetUlrString("https://github.com/").Wait();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "2");
            MessageBox.Show("1");
        }

        public async static Task<string> GetUlrString(string url)
        {
            using (HttpClient http = new HttpClient())
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"3");
                return await http.GetStringAsync(url);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = WebRequest.Create("https://github.com/");
            var stream = data.GetResponse().GetResponseStream();
            using (StreamReader reader = new StreamReader(stream))
            {
                //Thread.Sleep(3000);
                var text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
            throw new Exception("同步");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
               await NewMethod();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
             
        }

        private static async Task NewMethod()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var by = await httpClient.GetByteArrayAsync("https://github.com/");
                Console.Write(Encoding.UTF8.GetString(by));
            }
            throw new Exception("措辞");
        }
    }
}
