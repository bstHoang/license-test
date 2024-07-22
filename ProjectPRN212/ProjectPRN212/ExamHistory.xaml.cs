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
    /// Interaction logic for ExamHistory.xaml
    /// </summary>
    public partial class ExamHistory : Window
    {
        public ExamHistory(Models.User user)
        {
            InitializeComponent();
            u = user;
            LoadData();

        }
        Models.User u;
        Prn212Context context = new Prn212Context();
        public void LoadData()
        {
            var data1 = context.ExamHistories.Select(e => new
            {
                UserId = e.UserId,
                Score = e.Score,
                ExamTime = e.ExamTime,
                ExamHistoryId = e.ExamHistoryId,
            }).Where(e => e.UserId == u.UserId).ToList();
            QuestionsListView.ItemsSource = data1;
        }
        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                int examHistoryId = (int)button.Tag;
                DetailExamHistory detailExam = new DetailExamHistory(examHistoryId, u);
                detailExam.Show(); 
                this.Close();
            }
        }
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            UserHome home = new UserHome(u);
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
