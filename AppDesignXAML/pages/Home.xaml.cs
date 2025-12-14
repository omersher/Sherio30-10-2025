using System.Windows;
using System.Windows.Controls;

namespace AppDesignXAML.pages
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ExitApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // כפתור Login מעביר לדף Login.xaml
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // ניווט לדף Login.xaml
            this.NavigationService.Navigate(new Login());
        }
    }
}
