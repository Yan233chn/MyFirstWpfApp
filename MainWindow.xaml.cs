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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Word = FirstTextBox.Text;
            if (Word == "616")
            {
                MessageBox.Show("Confirmed successfully");
                Title.Text = "PTT计算";
                MainWindow1.Title.Text = Title.Text;
                FirstGrid.Visibility = Visibility.Collapsed;
                PttGrid.Visibility = Visibility.Visible;
            }
            else if (Word == "114514")
            {
                MessageBox.Show("哼哼，啊啊啊啊啊啊啊啊啊啊啊");
            }
            else
            {
                MessageBox.Show("WTF is that???");
            }
        }
        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            if (DefLv.Text == "") DefLv.Text = "0";
            if (Score.Text == "") Score.Text = "0";
            double song = double.Parse(DefLv.Text);
            int score = int.Parse(Score.Text);
            double result;
            if (score < 9800000) result = song + (score - 9500000) / 300000.0;
            else if (score < 10000000) result = song + 1 + (score - 9800000) / 200000.0;
            else result = song + 2.0;
            PTT.Text = result.ToString();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void MainPageButton_Click(object sender, RoutedEventArgs e)
        {
            PttGrid.Visibility = Visibility.Collapsed;
            FirstGrid.Visibility = Visibility.Visible;
        }
    }
}
