using System.Windows;

namespace BloodBankManagementSoftware
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            Register OP = new Register();
            OP.Show();
        }
        private void Search_btn_Click(object sender, RoutedEventArgs e)
        {
            SearchForDonator OP = new SearchForDonator();
            OP.Show();
        }

        private void FindDonator_btn_Click(object sender, RoutedEventArgs e)
        {
            FindDonator OP = new FindDonator();
            OP.Show();
        }
    }
}
