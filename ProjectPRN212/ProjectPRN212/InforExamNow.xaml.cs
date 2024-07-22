using ProjectPRN212.Models;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjectPRN212
{
    /// <summary>
    /// Interaction logic for InforExamNow.xaml
    /// </summary>
    public partial class InforExamNow : Window
    {
        private Models.User user;
        public InforExamNow(Models.User u, int count)
        {
            InitializeComponent();
            user = u;
            lbUserName.Content = u.UserName;
            lbSoCauDung.Content = count + "/25";
            double scoure = count / 25.0 * 10;
            double roundedNumber = Math.Round(scoure, 1);
            lbScoure.Content = roundedNumber;
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            UserHome home = new UserHome(user);
            home.Show();
            this.Close();

        }
        private void Minimized_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Maximized_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát add hay không!!!", "Exit", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                this.Close();
            }
        }
    }
}
