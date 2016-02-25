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
using Xceed.Wpf.Toolkit;

namespace BloodBankManagementSoftware
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
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
