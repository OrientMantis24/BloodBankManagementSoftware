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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BloodBankManagementSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //PnlMainWindow.MouseUp += new MouseButtonEventHandler(PnlMainWindow_MouseUp);
        }

        //private void PnlMainWindow_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        //}
        private void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            Register OP = new Register();
            //var host = new Window();
            //host.Content = OP;
            //.Show();
            OP.Show();
            //this.Close();
        }
    }
}
