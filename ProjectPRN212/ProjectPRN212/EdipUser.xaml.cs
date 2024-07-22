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
    /// Interaction logic for EdipUser.xaml
    /// </summary>
    public partial class EdipUser : Window
    {
        Models.User user;
        public EdipUser(Models.User u)
        {
            InitializeComponent();
            user = u;
            LoadData();
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
        private void LoadData()
        {
            var data = context.Users.Select(u => new
            {
                UserId = u.UserId,
                Username = u.UserName,
                Password = "********************",
                Role = u.Role.RoleName
            }).Where(u => u.UserId != user.UserId).ToList();
            dgListUserAll.ItemsSource = data;
            cbRole.ItemsSource = context.Roles.ToList();
            cbRole.DisplayMemberPath = "RoleName";
            cbRole.SelectedValuePath = "RoleId";
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            AdminHome ad = new AdminHome(user);
            ad.Show();
            this.Close();
        }

        private void btnEdipUser_Click(object sender, RoutedEventArgs e)
        {
            EdipQuestion ad = new EdipQuestion(user);
            ad.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void cbRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(lbUserId.Content)))
            {
                return;
            }
            var user = context.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(lbUserId.Content));
            user.RoleId = (int)cbRole.SelectedValue;
            context.Users.Update(user);
            context.SaveChanges();
            LoadData();
        }

        private void dgListUserAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgListUserAll.SelectedItem == null)
            {
                return;
            }
            dynamic user = dgListUserAll.SelectedItem;
            lbUserId.Content = user.UserId;
            lbUserName.Content = user.Username;
            cbRole.Text = user.Role;
        }

        private void btnChangePass_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pbPass.Password) || string.IsNullOrWhiteSpace(pbPass.Password))
            {
                MessageBox.Show("Vui lòng điền đẩy đủ mật khẩu mới và xác nhận mật khẩu!!!");
                return;
            }
            ValidateString validate = new ValidateString();
            if (!pbConfim.Password.Equals(pbPass.Password))
            {
                MessageBox.Show("New password phải trùng với confim password");
                return;
            }
            if (!validate.ValidatePassWord(pbPass.Password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu phải dài hơn 8 kí tự!!!");
                return;
            }
            var user = context.Users.FirstOrDefault(u => u.UserId == Convert.ToInt32(lbUserId.Content));
            user.Password = pbConfim.Password;
            context.Users.Update(user);
            context.SaveChanges();
            LoadData();
            MessageBox.Show("Mật khẩu đã được thay đổi!!!", "Changepass", MessageBoxButton.YesNo, MessageBoxImage.Information);
        }
    }
}
