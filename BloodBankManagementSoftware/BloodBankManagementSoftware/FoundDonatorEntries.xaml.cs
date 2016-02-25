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
    /// <summary>
    /// Interaction logic for FoundDonatorEntries.xaml
    /// </summary>
    public partial class FoundDonatorEntries : Window
    {
        public FoundDonatorEntries()
        {
            InitializeComponent();
            List<Donator> Donators = new List<Donator>();
            foreach (var Donator in DonatorsDatabase.GetDonator(SearchForDonator.SearchedName, SearchForDonator.SearchedTown, SearchForDonator.SearchedPhoneNumber))
            {
                Donators.Add(Donator);
            }
            LVDonators.ItemsSource = Donators;
        }
    }
}
