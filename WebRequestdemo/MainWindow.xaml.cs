using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WebRequestdemo
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource source;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            button.Content = "...";
            try
            {
                source = new CancellationTokenSource();
                button.Content = (await GetGoogleContent(source.Token)).Substring(1, 200);
            }
            catch
            {
                button.Content = "this was cancelled";
            }
            finally
            {
                source = null;
            }
        }

        private  void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            button.Content = "...";
            try
            {
                source = new CancellationTokenSource();
                var task = GetGoogleContent(source.Token);
                task.ContinueWith((result) => button.Content = result);
            }
            catch
            {
                button.Content = "this was cancelled";
            }
            finally
            {
                source = null;
            }
        }
        public void CancelDownload()
        {
        }

        private async Task<string> GetGoogleContent(CancellationToken token)
        {
            var listOfSites = new List<string> {"http://bing.com", "http://yahoo.com", "http://google.com"};
            var tasks =
                listOfSites.Select(async url => (await (await new HttpClient().GetAsync
                (url, token)).Content.ReadAsStringAsync()));
            var results = await Task.WhenAll(tasks.ToArray());
            return string.Join(",", results);
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            if (source != null)
            {
                source.Cancel();
                source = null;
            }
        }
    }
}