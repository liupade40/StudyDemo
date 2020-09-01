using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Allocate
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = new List<MyCanvas>() { new MyCanvas() { Height = 120,Left=0 }, new MyCanvas() { Height = 120, Left = 20 }, new MyCanvas() { Height = 120, Left = 40 } };
        }
    }
    public class MyCanvas : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; OnPropertyChanged("Height"); }
        }
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; OnPropertyChanged("Height"); }
        }

        private int _top;
        public int Top
        {
            get { return _top; }
            set { _top = value; OnPropertyChanged("Top"); }
        }
        private int _left;
        public int Left
        {
            get { return _left; }
            set { _left = value; OnPropertyChanged("Left"); }
        }
        protected internal virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
