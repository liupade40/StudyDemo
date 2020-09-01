using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfControl
{
    public partial class CustomControl1 : Control
    {
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            RectangleF rect = new RectangleF(ClientRectangle.X,
                                         ClientRectangle.Y,
                                         ClientRectangle.Width,
                                         ClientRectangle.Height);

            pe.Graphics.DrawString(this.Text, Font, new SolidBrush(ForeColor), rect);
        }
    }
}
