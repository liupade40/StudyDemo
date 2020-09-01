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

namespace Datagrid
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "1233333333333333333332", Age = 23 });
            list.Add(new Person() { Name = "2222222222222222222222", Age = 23 });
            list.Add(new Person() { Name = "3333333333333333333333", Age = 23 });
            list.Add(new Person() { Name = "4444444444444444444444", Age = 23 });
            grid.ItemsSource = list;
        }
    }
}
