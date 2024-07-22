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
using System.Windows.Threading;

namespace ProjectPRN212
{
    /// <summary>
    /// Interaction logic for ThiBangLaiXeMay.xaml
    /// </summary>
    public partial class ThiBangLaiXeMay : Window
    {
        public ThiBangLaiXeMay(Models.User u)
        {
            InitializeComponent();
            user = u;
            GenerateButton();
            ShowQuestion(0);
            StartTimer();
            lbUserId.Content = u.UserId;
            lbUserName.Content = u.UserName;    
            DateTime now = DateTime.Now;
            lbTimeNow.Content = now.ToString("dd/MM/yyyy");
        }
        private User user;
        List<ListQuestion> listQuestions = new List<ListQuestion>();    
        Prn212Context context = new Prn212Context();
        StackPanel[] questionsPanel;
        private DispatcherTimer timer;
        private TimeSpan timeRemaining;
        int viTriHienTai = 0;
        public void GenerateButton()
        {
            questionsPanel = new StackPanel[25];
            var randomQuestions = context.Questions.Where(p => p.LicenseId == 1).OrderBy(q => Guid.NewGuid()).Take(25).ToList();
            for (int i = 0; i < randomQuestions.Count; i++)
            {
                ListQuestion listQuestion = new ListQuestion()
                {
                    QuestionId = randomQuestions[i].QuestionId,
                    Question = randomQuestions[i]
                };
                listQuestions.Add(listQuestion);
                Button button = new Button()
                {
                    FontWeight = FontWeights.Bold,
                    Margin = new Thickness(5),
                    FontSize = 20,
                    Height = 35,
                    Width = 130,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Background = new SolidColorBrush(Color.FromRgb(250, 242, 212)),
                    Content = (i + 1).ToString()
                };
                button.Click += NavButton_Click;
                navigationPanel.Items.Add(button);
                StackPanel stack = new StackPanel();
                Label label = new Label()
                {
                    Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
                    FontSize = 40,
                    FontWeight = FontWeights.Bold,
                    Content = "Question " + (i + 1),
                };
                stack.Children.Add(label);
                TextBlock text = new TextBlock()
                {
                    Margin = new Thickness(30, 20, 0, 10),
                    FontSize = 30,
                    TextWrapping = TextWrapping.Wrap,
                    Text = randomQuestions[i].Question1
                };
                stack.Children.Add(text);

                if (randomQuestions[i].ImgQuestion != null)
                {
                    string imagePath = "D:\\Desktop\\NET\\ProjectPRN212\\ProjectPRN212\\PRN212\\" + randomQuestions[i].ImgQuestion;
                    if (System.IO.File.Exists(imagePath))
                    {
                        Image image = new Image();
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        bitmap.UriSource = new Uri(imagePath, UriKind.Absolute);
                        bitmap.EndInit();
                        image.Source = bitmap;
                        image.Height = 200;
                        stack.Children.Add(image);
                    }
                }
                RadioButton radioButton1 = new RadioButton()
                {
                    FontSize = 23,
                    Name = "radio1",
                    VerticalAlignment = VerticalAlignment.Center, 
                    Margin = new Thickness(5),
                    Padding = new Thickness(0, -10, 0, 0),
                    Content = new TextBlock()
                    {
                        Text = randomQuestions[i].Answer1,
                        TextWrapping = TextWrapping.Wrap,
                        TextTrimming = TextTrimming.CharacterEllipsis
                    },
                    Tag = 1,
                    GroupName = $"question{i}",
                };
                stack.Children.Add(radioButton1);
                RadioButton radioButton2 = new RadioButton()
                {
                    FontSize = 23,
                    Name = "radio2",
                    VerticalAlignment = VerticalAlignment.Center,
                    Padding = new Thickness(0, -10, 0, 0),
                    Margin = new Thickness(5),
                    Content = new TextBlock()
                    {
                        Text = randomQuestions[i].Answer2,
                        TextWrapping = TextWrapping.Wrap,
                        TextTrimming = TextTrimming.CharacterEllipsis
                    },
                    Tag = 2,
                    GroupName = $"question{i}"
                };
                stack.Children.Add(radioButton2);
                if (randomQuestions[i].Answer3 != null)
                {
                    RadioButton radioButton3 = new RadioButton()
                    {
                        FontSize = 23,
                        Name = "radio3",
                        VerticalAlignment = VerticalAlignment.Center,
                        Padding = new Thickness(0, -10, 0, 0),
                        Margin = new Thickness(5),
                        Content = new TextBlock()
                        {
                            Text = randomQuestions[i].Answer3,
                            TextWrapping = TextWrapping.Wrap,
                            TextTrimming = TextTrimming.CharacterEllipsis
                        },
                        GroupName = $"question{i}",
                        Tag = 3,
                    };
                    stack.Children.Add(radioButton3);
                }
                if (randomQuestions[i].Answer4 != null)
                {
                    RadioButton radioButton4 = new RadioButton()
                    {
                        FontSize = 23,
                        Name = "radio4",
                        Padding = new Thickness(0, -10, 0, 0),
                        VerticalAlignment = VerticalAlignment.Center,
                        Margin = new Thickness(5),
                        Content = new TextBlock()
                        {
                            Text = randomQuestions[i].Answer4,
                            TextWrapping = TextWrapping.Wrap,
                            TextTrimming = TextTrimming.CharacterEllipsis
                        },
                        Tag = 4,
                        GroupName = $"question{i}"
                    };
                    stack.Children.Add(radioButton4);
                }
                questionsPanel[i] = stack;
            }
        }
        private void ShowQuestion(int index)
        {
            if(index >= 0 && index < questionsPanel.Length)
            {
                questionContentGrid.Children.Clear();
                questionContentGrid.Children.Add(questionsPanel[index]);
                viTriHienTai = index;
            }
        }
        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            int questionNumber = Convert.ToInt32(clickedButton.Content.ToString()) - 1;
            ShowQuestion(questionNumber);
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
            if (MessageBox.Show("Bạn đang trong thời gian làm bài thi bạn có thực sự muốn thoát không!!!", "Exit", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                this.Close();
            }
        }
        private void StartTimer()
        {
            timeRemaining = TimeSpan.FromMinutes(20);
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateTimerDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeRemaining = timeRemaining.Add(TimeSpan.FromSeconds(-1));
            UpdateTimerDisplay();

            if (timeRemaining <= TimeSpan.Zero)
            {
                timer.Stop();
                InputListQuestionAndExamHistory();
                MessageBox.Show("Hết thời gian! Bài thi đã được nộp tự động.");
            }
        }

        private void UpdateTimerDisplay()
        {
            timerTextBlock.Text = timeRemaining.ToString(@"mm\:ss");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc là bạn muốn nộp bài hay không?", "Notification", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                timer.Stop();
                InputListQuestionAndExamHistory();
            }
            else
            {
                return;
            }
        }
        private void InputListQuestionAndExamHistory()
        {
            int count = 0;
            for (int i = 0; i < questionsPanel.Length; i++)
            {
                var stack = questionsPanel[i];
                foreach (var item in stack.Children)
                {
                    if(item is RadioButton radio && radio.IsChecked == true)
                    {
                        int selectedPosition = (int)radio.Tag;
                        listQuestions[i].YourAnser = selectedPosition;
                        if(selectedPosition == listQuestions[i].Question.CorrectAnswer)
                        {
                            count++;
                        }
                    }
                }
            }
            Models.ExamHistory exam = new Models.ExamHistory
            {
                Score = (count / 25.0) * 10, 
                ExamTime = DateTime.Now,
                UserId = user.UserId
            };
            context.ExamHistories.Add(exam);
            context.SaveChanges();
            for(int i = 0;i < listQuestions.Count; i++)
            {
                listQuestions[i].ExamHistoryId = exam.ExamHistoryId;
            }
            context.ListQuestions.AddRange(listQuestions);
            context.SaveChanges();
            InforExamNow userHome = new InforExamNow(user, count);
            userHome.Show();
            this.Close();
        }
       
    }
}
