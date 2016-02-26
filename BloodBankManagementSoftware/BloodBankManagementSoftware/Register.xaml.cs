using System.Windows;

namespace BloodBankManagementSoftware
{
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Submit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Name_txb != null && Town_txb != null && PhoneNumber_txb.IsMaskFull)
            {
                Donator Donator = new Donator() { Name = Name_txb.Text,
                    BloodGroup = BloodGroup_cbb.Text,
                    RhFactor = RhFactor_cbb.Text,
                    Town = Town_txb.Text,
                    PhoneNumber = PhoneNumber_txb.Text };

                using (var ctx = new DonatorContext())
                {
                    ctx.Donators.Add(Donator);
                    ctx.SaveChanges();
                }

                Close();
                System.Windows.MessageBox.Show("Donator saved!");
            }
        }
    }
}
