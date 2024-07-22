using Microsoft.VisualBasic.ApplicationServices;
using ProjectPRN212.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for UserChangepass.xaml
    /// </summary>
    public partial class UserChangepass : Window
    {
        private Models.User user;
        public UserChangepass(Models.User u)
        {
            InitializeComponent();
            user = u;
            lbUserId.Content = u.UserId;
            lbUserName.Content = u.UserName;
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
        Prn212Context context = new Prn212Context();
        ValidateString validate = new ValidateString();
        private void btnChangePass_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(pbPass.Password) || string.IsNullOrWhiteSpace(pbConfim.Password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
            }
            var user = context.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(lbUserId.Content));

            if (!pbOldPass.Password.Equals(user.Password))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!!!", "Error Changepass", MessageBoxButton.YesNo, MessageBoxImage.Error);
            }
            else if (!pbConfim.Password.Equals(pbPass.Password))
            {
                MessageBox.Show("Confim pass phải trùng với new pass!!!", "Error Changepass", MessageBoxButton.YesNo, MessageBoxImage.Error);
            }
            else if (!validate.ValidatePassWord(pbPass.Password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu phải dài hơn 8 kí tự!!!");
                return;
            }
            else
            {
                user.Password = pbConfim.Password;
                context.Users.Update(user);
                context.SaveChanges();
                Login login = new Login();
                login.Show();
                this.Close();
                MessageBox.Show("Mật khẩu đã được thay đổi!!!", "Changepass", MessageBoxButton.YesNo, MessageBoxImage.Information);
            }
        }
    }
}
