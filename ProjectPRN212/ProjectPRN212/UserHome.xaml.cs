using Microsoft.VisualBasic.ApplicationServices;
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

namespace ProjectPRN212
{
    /// <summary>
    /// Interaction logic for UserHome.xaml
    /// </summary>
    public partial class UserHome : Window
    {
        private Models.User u;
        Prn212Context context = new Prn212Context();
        public UserHome(Models.User user)
        {
            InitializeComponent();
            u = user;
            lbUserId.Content = user.UserId;
            lbUserName.Content = user.UserName;
            DateTime date = DateTime.Now;
            lbTimeNow.Content = date.ToString("dd/MM/yyyy");
            cbTypeOfLicense.ItemsSource = context.TypeOfLicenses.ToList();
            cbTypeOfLicense.SelectedValuePath = "LicenseId";
            cbTypeOfLicense.DisplayMemberPath = "LicenseName";
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

        private void btnVaoThi_Click(object sender, RoutedEventArgs e)
        {
            if(cbTypeOfLicense.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại thi. Vui lòng chọn lại!!!", "Error Type of license", MessageBoxButton.OK, MessageBoxImage.Question);
                return;
            }
            int check = Convert.ToInt32(cbTypeOfLicense.SelectedValue);
            if(check == 1)
            {
                ThiBangLaiXeMay thiBangLaiXeMay = new ThiBangLaiXeMay(u);
                thiBangLaiXeMay.Show();
                this.Close();
            }
            if (check == 3)
            {
                ThiBangLaiXeOto thiBangLaiXeMay = new ThiBangLaiXeOto(u);
                thiBangLaiXeMay.Show();
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserChangepass userChangepass = new UserChangepass(u);
            userChangepass.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ExamHistory userChangepass = new ExamHistory(u);
            userChangepass.Show();
            this.Close();
        }
    }
}
