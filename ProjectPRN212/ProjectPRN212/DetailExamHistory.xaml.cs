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
    /// Interaction logic for DetailExamHistory.xaml
    /// </summary>
    public partial class DetailExamHistory : Window
    {
        int examId;
        Models.User user;
        public DetailExamHistory(int examHistoryId, Models.User u)
        {
            InitializeComponent();
            user = u;
            examId = examHistoryId;
            LoadData();
        }
        Prn212Context context = new Prn212Context();
        private void LoadData()
        {
            var check = context.ListQuestions.Select(p => new
            {
                Question = p.Question.Question1,
                Answer1 = p.Question.Answer1,
                Answer2 = p.Question.Answer2,
                Answer3 = p.Question.Answer3,
                Answer4 = p.Question.Answer4,
                Image = p.Question.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.Question.ImgQuestion,
                CorrectAnswer = "Answer " + p.Question.CorrectAnswer,
                YourAnswer = p.YourAnser == null ? "" : "Answer " + p.YourAnser,
                ExamHistoryId = p.ExamHistoryId
            }).Where(p => p.ExamHistoryId == examId).ToList();
            lvQuestions.ItemsSource = check;
            if (check.Count == 25)
            {
                lbChuDe.Content = "Đề thi Bằng lái xem máy";
            }
            else
            {
                lbChuDe.Content = "Đề thi Bằng lái xem Ôtô";
            }
            lbSoLuongCauHoi.Content = "(Số lượng câu hỏi " + check.Count + ")";
        }
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            ExamHistory home = new ExamHistory(user);
            home.Show();
            this.Close();

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
