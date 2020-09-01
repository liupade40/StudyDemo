using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfControl
{
    public partial class Self : UserControl
    {
        public string lable
        {
            set
            {
                label1.Text = value;
            }
        }
        public string lable2
        {
            set
            {
                label2.Text = value;
            }
        }
        public Self()
        {
            InitializeComponent();
        }
    }
}
