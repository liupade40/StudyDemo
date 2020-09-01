using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var str= http.GetStringAsync("https://github.com/").Result;
            Console.WriteLine(str);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();
            var str =await http.GetStringAsync("https://github.com/");
            Console.WriteLine(str);
        }
    }
}
