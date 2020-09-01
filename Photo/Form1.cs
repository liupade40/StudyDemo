using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo
{
    public partial class Form1 : Form
    {
        Bitmap myBmp;
        Point mouseDownPoint = new Point(); //记录拖拽过程鼠标位置
        bool isMove = false;  //判断鼠标在picturebox上移动时，是否处于拖拽过程(鼠标左键是否按下)
        int zoomStep = 20;   //缩放步长
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.MouseWheel += PictureBox1_MouseWheel;
        }

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            int ow = pictureBox1.Width;
            int oh = pictureBox1.Height;
            int VX, VY;
            if (e.Delta > 0)
            {
                pictureBox1.Width += zoomStep;
                pictureBox1.Height += zoomStep;
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                  BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            if (e.Delta < 0)
            {
                if (pictureBox1.Width < myBmp.Width / 10)
                    return;
                pictureBox1.Width -= zoomStep;
                pictureBox1.Height -= zoomStep;
                PropertyInfo pInfo = pictureBox1.GetType().GetProperty("ImageRectangle", BindingFlags.Instance |
                  BindingFlags.NonPublic);
                Rectangle rect = (Rectangle)pInfo.GetValue(pictureBox1, null);
                pictureBox1.Width = rect.Width;
                pictureBox1.Height = rect.Height;
            }
            VX = (int)((double)x * (ow - pictureBox1.Width) / ow);
            VY = (int)((double)y * (oh - pictureBox1.Height) / oh);
            pictureBox1.Location = new Point(pictureBox1.Location.X + VX, pictureBox1.Location.Y + VY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Tiff文件|*.tif|Bmp文件|*.bmp|Erdas img文件|*.img|EVNI文件|*.hdr|jpeg文件|*.jpg|raw文件|*.raw|vrt文件|*.vrt|所有文件|*.*";
            dlg.FilterIndex = 8;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filename = dlg.FileName;
            }
            if (filename == "")
            {
                return;
            }
            myBmp = new Bitmap(filename);
            if (myBmp == null)
            {
                MessageBox.Show("读取失败");
                return;
            }
            textBox1.Text = filename;
            pictureBox1.Image = myBmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; //设置picturebox为缩放模式
            pictureBox1.Width = myBmp.Width;
            pictureBox1.Height = myBmp.Height;
            //Width = myBmp.Width;
           // Height = myBmp.Height;
            pictureBox1.Location = new Point((Width-pictureBox1.Width)/2, (Height - pictureBox1.Height) / 2);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
                pictureBox1.Focus();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
           // if (isMove)
           // {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
          //  }
        }

        private void pictox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Focus();
           // if (isMove)
         //   {
                int x, y;
                int moveX, moveY;
                moveX = Cursor.Position.X - mouseDownPoint.X;
                moveY = Cursor.Position.Y - mouseDownPoint.Y;
                x = pictureBox1.Location.X + moveX;
                y = pictureBox1.Location.Y + moveY;
                pictureBox1.Location = new Point(x, y);
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
           // }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint.X = Cursor.Position.X;
                mouseDownPoint.Y = Cursor.Position.Y;
                isMove = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = false;
            }
        }

       
    }
}