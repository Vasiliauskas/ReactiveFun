using System;
using System.Reactive.Linq;
using System.Windows;

namespace ReactiveFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Observable.Timer(new TimeSpan(0, 0, 1), new TimeSpan(0, 0, 1)).Subscribe((o) => Console.WriteLine(o));
        }
    }
}
