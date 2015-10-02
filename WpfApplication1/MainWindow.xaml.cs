using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                var value = Computation();
                myButton.Dispatcher.Invoke(() =>
                {
                    myButton.Content = value;
                });
            });
            thread.Start();
        }

        public long ComputationBad()
        {
            long result = 0;
            for (long i = 0; i < 1000000; i++)
                result += i*i;
            return result;
        }

        public long Computation()
        {
            Thread.Sleep(3000);
            return Enumerable.Range(1, 100000).Sum(x => ((long) x)*(long) x);
        }

    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
    }
}
