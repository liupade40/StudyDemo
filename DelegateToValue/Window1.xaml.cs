using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DelegateToValue
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public event EventHandler add;
        public Action<string> action;
        public event MEventHalder my;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            action?.Invoke(textbox.Text);
            add?.Invoke(textbox.Text, e);
            my?.Invoke(sender, new MyEvent(textbox.Text) { });
        }
    }
    public class MyEvent : EventArgs
    {
        public MyEvent(string sid)
        {
            id = sid;
        }
        public string id { get; set; }
    }
    
     public delegate void MEventHalder(object sender, MyEvent e);
    
}
