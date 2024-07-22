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
    /// Interaction logic for AdminHome.xaml
    /// </summary>
    public partial class AdminHome : Window
    {
        Models.User user;
        public AdminHome(Models.User u)
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
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }else
            {
                this.WindowState= WindowState.Maximized;
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

          var data1 = context.Questions.Select(p => new
            {
                Question = p.Question1,
                Answer1 = p.Answer1,
                Answer2 = p.Answer2,
                Answer3 = p.Answer3,
                Answer4 = p.Answer4,
                Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                CorrectAnswer = p.CorrectAnswer
            }).ToList();
            dgListQuesTionAll.ItemsSource = data1;
            int numberOfQuestion = context.Questions.Count();
            txtNumberOfQuestion.Text = "" + numberOfQuestion;
            int numberOfUser = context.Users.Count();
            txtNumberOfUser.Text = "" + numberOfUser;
            int soLanThi = context.ExamHistories.Count();
            txtSoLanThi.Text = "" + soLanThi;
            cbTypeOfLicense.ItemsSource = context.TypeOfLicenses.ToList();
            cbTypeOfLicense.DisplayMemberPath = "LicenseName";
            cbTypeOfLicense.SelectedValuePath = "LicenseId";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if(cbTypeOfLicense.SelectedIndex == -1)
            {
                var data1 = context.Questions.Select(p => new
                {
                    Question = p.Question1,
                    Answer1 = p.Answer1,
                    Answer2 = p.Answer2,
                    Answer3 = p.Answer3,
                    Answer4 = p.Answer4,
                    Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                    CorrectAnswer = p.CorrectAnswer,
                    LicenseId = p.LicenseId
                }).Where(p => p.Question.Contains(txtSearchByName.Text)).ToList();
                dgListQuesTionAll.ItemsSource = data1;
            }
            else
            {
                int index = (int)cbTypeOfLicense.SelectedValue;
                var data1 = context.Questions.Select(p => new
                {
                    Question = p.Question1,
                    Answer1 = p.Answer1,
                    Answer2 = p.Answer2,
                    Answer3 = p.Answer3,
                    Answer4 = p.Answer4,
                    Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                    CorrectAnswer = p.CorrectAnswer,
                    LicenseId = p.LicenseId
                }).Where(p => p.Question.Contains(txtSearchByName.Text) && p.LicenseId == index).ToList();
                dgListQuesTionAll.ItemsSource = data1;
            }
            
        }

        private void btnEdipQuestion_Click(object sender, RoutedEventArgs e)
        {
            EdipQuestion edip = new EdipQuestion(user);
            edip.Show();
            this.Close();
        }

        private void btnEdipUser_Click(object sender, RoutedEventArgs e)
        {
            EdipUser edip = new EdipUser(user);
            edip.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
