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

namespace BloodBankManagementSoftware
{
    public partial class SearchForDonator : Window
    {
        public SearchForDonator()
        {
            InitializeComponent();
        }

        public static string SearchedName;
        public static string SearchedTown;
        public static string SearchedPhoneNumber;

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Search_btn_Click(object sender, RoutedEventArgs e)
        {
            SearchedName = Name_txb.Text;
            SearchedTown = Town_txb.Text;
            SearchedPhoneNumber = PhoneNumber_txb.Text;
            FoundDonatorEntries OP = new FoundDonatorEntries();
            OP.Show();
        }
    }
}
