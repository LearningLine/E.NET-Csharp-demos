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

namespace TaskUI
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

        private async void OnClick(object sender, RoutedEventArgs e)
        {
            /* DON'T DO THIS
            var task = ComputeNumberAsync();
            task.Wait();
            */

            var value = await ComputeNumberAsync();
            button.Content = value;
        }

        async Task<double> ComputeNumberAsync()
        {
            Task<double> task = Task.Run(() =>
            {
                Task.Delay(3000);
                return (double) 123123123123;
            });
            return await task;
        }
    }
}
