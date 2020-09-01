using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("为了点击我，看来是想尽了办法啊！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也喜欢你！");
        }
        
        private int Rand(int number)
        {
            Random r = new Random();
            return r.Next(0,number);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            int x = this.Width - button2.Width - 15;
            int y = this.Height - button2.Height - 40;
            int x1 = Rand(x);
            int y1 = Rand(y);
            button2.Location = new Point(x1, y1);
        }
    }
}
