using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeGroundThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
            Thread thread = new Thread(Write);
            thread.Start();
        }
        private void Write()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
            for (int i = 0; i < 10;i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId.ToString());
                Console.WriteLine(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Write);
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
