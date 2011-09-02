using System.Linq;
using System.Windows;

namespace LonelyMe.WP7.App
{
    public partial class MainPage
    {
        Domain.Registration _registration;

        public MainPage()
        {
            InitializeComponent();
            _registration = new Domain.Registration();
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            var account = _registration.Register(username.Text, password.Password);
            signup_results.ItemsSource = account.SocialAccounts.Select(acc => "Created Account For '" + acc + "'");
        }
    }
}
