using System.Windows;
using System.Collections.Generic;

namespace BloodBankManagementSoftware
{
    /// <summary>
    /// Interaction logic for FoundDonatorEntries.xaml
    /// </summary>
    public partial class FoundDonatorEntries : Window
    {
        public FoundDonatorEntries(string SearchedName, string SearchedTown, string SearchedPhoneNumber)
        {
            InitializeComponent();
            List<Donator> Donators = new List<Donator>();
            foreach (var Donator in DonatorsDatabase.GetDonator(SearchedName, SearchedTown, SearchedPhoneNumber))
            {
                Donators.Add(Donator);
            }
            LVDonators.ItemsSource = Donators;
        }

        public FoundDonatorEntries(string SearchedBloodGroup, string SearchedRhFactor)
        {
            InitializeComponent();
            List<Donator> Donators = new List<Donator>();
            foreach (var Donator in DonatorsDatabase.GetDonator(SearchedBloodGroup, SearchedRhFactor))
            {
                Donators.Add(Donator);
            }
            LVDonators.ItemsSource = Donators;
        }
    }
}
