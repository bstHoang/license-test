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
using Microsoft.Win32;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace ProjectPRN212
{
    /// <summary>
    /// Interaction logic for EdipQuestion.xaml
    /// </summary>
    public partial class EdipQuestion : Window
    {
        Models.User user;
        public EdipQuestion(Models.User u)
        {
            InitializeComponent();
            user = u;
            LoadData();
        }
        Question q = new Question();
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

            var data1 = context.Questions.Select(p => new
            {
                QuestionId = p.QuestionId,
                Question = p.Question1,
                Answer1 = p.Answer1,
                Answer2 = p.Answer2,
                Answer3 = p.Answer3,
                Answer4 = p.Answer4,
                Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                CorrectAnswer = "Answer " + p.CorrectAnswer,
                License = p.License.LicenseName
            }).ToList();
            dgListQuesTionAll.ItemsSource = data1;
            cbLicense.ItemsSource = context.TypeOfLicenses.ToList();
            cbLicense.DisplayMemberPath = "LicenseName";
            cbLicense.SelectedValuePath = "LicenseId";
            cbTypeOfLicense.ItemsSource = context.TypeOfLicenses.ToList();
            cbTypeOfLicense.DisplayMemberPath = "LicenseName";
            cbTypeOfLicense.SelectedValuePath = "LicenseId";
            q = new Question();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (cbTypeOfLicense.SelectedIndex == -1)
            {
                var data1 = context.Questions.Select(p => new
                {
                    QuestionId = p.QuestionId,
                    Question = p.Question1,
                    Answer1 = p.Answer1,
                    Answer2 = p.Answer2,
                    Answer3 = p.Answer3,
                    Answer4 = p.Answer4,
                    Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                    CorrectAnswer = "Answer " + p.CorrectAnswer,
                    License = p.License.LicenseName
                }).Where(p => p.Question.Contains(txtSearchByName.Text)).ToList();
                dgListQuesTionAll.ItemsSource = data1;
            }
            else
            {
                int index = (int)cbTypeOfLicense.SelectedValue;
                var data1 = context.Questions.Select(p => new
                {
                    QuestionId = p.QuestionId,
                    Question = p.Question1,
                    Answer1 = p.Answer1,
                    Answer2 = p.Answer2,
                    Answer3 = p.Answer3,
                    Answer4 = p.Answer4,
                    Image = p.ImgQuestion == null ? "" : "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + p.ImgQuestion,
                    CorrectAnswer = "Answer " + p.CorrectAnswer,
                    LicenseId = p.LicenseId,
                    License = p.License.LicenseName
                }).Where(p => p.Question.Contains(txtSearchByName.Text) && p.LicenseId == index).ToList();
                dgListQuesTionAll.ItemsSource = data1;
            }
        }
        private void dgListQuesTionAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgListQuesTionAll.SelectedItem == null)
            {
                return;
            }

            dynamic question = dgListQuesTionAll.SelectedItem;

            txtQuestion.Text = question.Question.ToString();
            txtAnswer1.Text = question.Answer1.ToString();
            txtAnswer2.Text = question.Answer2.ToString();
            if (question.Answer3 == null)
            {
                txtAnswer3.Clear();
            }
            else
            {
                txtAnswer3.Text = question.Answer3.ToString();
            }

            if (question.Answer4 == null)
            {
                txtAnswer4.Clear();
            }
            else
            {
                txtAnswer4.Text = question.Answer4.ToString();
            }
            if (question.GetType().GetProperty("Image") != null)
            {
                string imagePath = question.Image.ToString();
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    Uri imageUri = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                    BitmapImage bitmapImage = new BitmapImage(imageUri);
                    igQuestion.Source = bitmapImage;
                }
                else
                {
                    igQuestion.Source = null; 
                }
            }
            else
            {
                igQuestion.Source = null;
            }
            lbId.Content = question.QuestionId + "";
            cbCorrectAnswer.Text = question.CorrectAnswer;
            cbLicense.Text = question.License;
        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            AdminHome adminHome = new AdminHome(user);
            adminHome.Show();
            this.Close();
        }

        private void btnEdipUser_Click(object sender, RoutedEventArgs e)
        {
            EdipUser adminHome = new EdipUser(user);
            adminHome.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string sourcefile = openFileDialog.FileName;
                string extension = System.IO.Path.GetExtension(sourcefile).ToLower();
                List<string> validExtensions = new List<string> { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

                if (!validExtensions.Contains(extension))
                {
                    MessageBox.Show("Vui lòng chọn file có kết thúc là: .jpg, .jpeg, .png, .bmp, .gif");
                    return;
                }

                Uri fileUri = new Uri(sourcefile);
                igQuestion.Source = new BitmapImage(fileUri);

                string resourceUri = "D://Desktop//NET//ProjectPRN212//ProjectPRN212//PRN212//" + System.IO.Path.GetFileName(sourcefile);

                try
                {
                    string destinationDirectory = System.IO.Path.GetDirectoryName(resourceUri);
                    if (!System.IO.Directory.Exists(destinationDirectory))
                    {
                        System.IO.Directory.CreateDirectory(destinationDirectory);
                    }

                    System.IO.File.Copy(sourcefile, resourceUri, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error copying file: " + ex.Message);
                    return;
                }
            }
        }

        public static string GetFileNameFromPath(string path)
        {
            string[] s1 = path.Split("/");
            return s1[s1.Length - 1];
        }
        ValidateString validate = new ValidateString();
        public bool CheckInput()
        {
            if (!(validate.ValidateQuestion(txtQuestion.Text) && validate.ValidateQuestion(txtAnswer1.Text) && validate.ValidateQuestion(txtAnswer2.Text)) || cbCorrectAnswer.SelectedIndex == -1 || cbLicense.SelectedIndex == -1)
            {
                MessageBox.Show("Kiểm tra lại giá trị nhập Question, Answer1, Answer2, CorrectAnswer, License bắt buộc phải có", "Error AddQuestion", MessageBoxButton.YesNo); 
                    return true;
            }
            return false;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            try
            {
                ComboBoxItem selectedItem = (ComboBoxItem)cbCorrectAnswer.SelectedItem;
                q.Question1 = txtQuestion.Text.Trim();
                q.Answer1 = txtAnswer1.Text.Trim();
                q.Answer2 = txtAnswer2.Text.Trim();
                q.Answer3 = string.IsNullOrWhiteSpace(txtAnswer3.Text) ? null : txtAnswer3.Text.Trim();
                q.Answer4 = string.IsNullOrWhiteSpace(txtAnswer4.Text) ? null : txtAnswer4.Text.Trim();
                q.LicenseId = (int)(cbLicense.SelectedValue);
                q.CorrectAnswer = Convert.ToInt32(selectedItem.Tag);
                string imgSource = null;
                if (igQuestion != null && igQuestion.Source != null)
                {
                    imgSource = igQuestion.Source.ToString();
                }

                string imgQuestion = string.IsNullOrWhiteSpace(imgSource) ? null : GetFileNameFromPath(imgSource);

                q.ImgQuestion = imgQuestion;
                context.Questions.Add(q);
                context.SaveChanges();
                LoadData();
                MessageBox.Show("Bạn đã AddQuestion thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add false: " + ex.Message);
            }
        }


        private void cbCorrectAnswer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((cbCorrectAnswer.SelectedIndex == 2 && string.IsNullOrEmpty(txtAnswer3.Text)) || (cbCorrectAnswer.SelectedIndex == 3 && string.IsNullOrEmpty(txtAnswer4.Text)))
            {
                if (MessageBox.Show("Chắc chắn rằng câu correctAnswer phải là những câu trả lời đã có rồi", "Error AddQuestion", MessageBoxButton.OK) == MessageBoxResult.OK)
                    cbCorrectAnswer.SelectedIndex = -1;
                return;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (CheckInput())
            {
                return;
            }
            var question = context.Questions.FirstOrDefault(p => p.QuestionId == Convert.ToInt32(lbId.Content));
            if(question == null)
            {
                MessageBox.Show("Question is not exist!!!");
                return;
            }
            question.Question1 = txtQuestion.Text.Trim();
            question.Answer1 = txtAnswer1.Text.Trim();
            question.Answer2 = txtAnswer2.Text.Trim();
            question.Answer3 = string.IsNullOrWhiteSpace(txtAnswer3.Text) ? null : txtAnswer3.Text.Trim();
            question.Answer4 = string.IsNullOrWhiteSpace(txtAnswer4.Text) ? null : txtAnswer4.Text.Trim();
            ComboBoxItem boxItem = (ComboBoxItem)cbCorrectAnswer.SelectedItem;
            question.CorrectAnswer = Convert.ToInt32(boxItem.Tag);
            string imgSource = null;
            if (igQuestion != null && igQuestion.Source != null)
            {
                imgSource = igQuestion.Source.ToString();
            }
            question.ImgQuestion = string.IsNullOrWhiteSpace(imgSource) ? null : GetFileNameFromPath(imgSource);
            context.Questions.Update(question);
            context.SaveChanges();
            LoadData();
            MessageBox.Show("Update thành công");
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var question = context.Questions.FirstOrDefault(p => p.QuestionId == Convert.ToInt32(lbId.Content));
            if (question == null)
            {
                MessageBox.Show("Question is not exist!!!");
                return;
            }
            context.Questions.Remove(question);
            context.SaveChanges();
            ClearInput();
            LoadData();
            MessageBox.Show("Delete thành công");
        }
        private void ClearInput()
        {
            lbId.Content = null;
            txtAnswer1.Clear();
            txtQuestion.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();
            cbCorrectAnswer.SelectedIndex = -1;
            cbLicense.SelectedIndex = -1;
            igQuestion.Source = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            igQuestion.Source = null;
        }
    }
}
