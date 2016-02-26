using System.Windows;

namespace BloodBankManagementSoftware
{
    public partial class SearchForDonator : Window
    {
        public SearchForDonator()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Search_btn_Click(object sender, RoutedEventArgs e)
        {
            FoundDonatorEntries OP = new FoundDonatorEntries(Name_txb.Text, Town_txb.Text, PhoneNumber_txb.Text);
            OP.Show();
        }
    }
}
