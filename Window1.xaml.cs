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

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //Button
        }
        private readonly string title = "新窗口";
        private readonly int width = 400;
        private readonly int height = 300;
        private void BtnOnClick(object sender, RoutedEventArgs e)
        {
            Window newWindow = new Window();
            newWindow.Title = title;
            newWindow.Width = width;
            newWindow.Height = height;
            newWindow.Show();
            newWindow.Activate();
        }
    }
}
