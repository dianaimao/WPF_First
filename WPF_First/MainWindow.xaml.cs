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
using System.Windows.Threading;
namespace WPF_First
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _Timer = new DispatcherTimer();
        string[] _ChineseHour = null;
        public MainWindow()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;//任务栏隐藏

            _ChineseHour = new string[] {
                "0","1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12",
                "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"
            };
            _Timer.Interval = TimeSpan.FromSeconds(1);
            _Timer.Tick += new EventHandler(Update_Time);
            _Timer.Start();
        }

        private void Update_Time(object sender, EventArgs e)
        {
            this.Lable_time1.Content = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
            this.Lable_time3.Content = $"{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Year.ToString().Substring(2, 2)}";
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
