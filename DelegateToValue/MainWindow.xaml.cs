using Newtonsoft.Json;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DelegateToValue
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserControl1_Add(object sender, EventArgs e)
        {
            block.Text = sender.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            window1.add += Window1_add;
            window1.my += Window1_my;
            window1.action = Method;
        }

        private void Window1_my(object sender, MyEvent e)
        {
            MessageBox.Show(e.id);
        }

        private void Window1_add(object sender, EventArgs e)
        {
            textbox3.Text = sender.ToString();
        }

        private void Method(string obj)
        {
            textbox2.Text = obj;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string value = JsonConvert.SerializeObject(null);
            try
            {
                List<KeyValuePair<string, string>> list = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(null);
            }
            catch (Exception ex)
            {

                
            }
            
        }
    }
}
