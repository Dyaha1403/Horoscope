using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Rambler_Horoscope_App
{
    public partial class MainWindow : Window
    {
        Parser parser = new Parser();

        string[] title = new string[12];
        string[] horoscope = new string[12];
        public MainWindow() 
        {
            InitializeComponent();
            InitializeParsMethod();
        }

        private void InitializeParsMethod()
        {
            for(int i = 0; i < 12; i++)
            {
                title[i] = parser.ParsHoroscope(i)[0];
                horoscope[i] = parser.ParsHoroscope(i)[1];
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                DragMove(); 
        }

       private void ButtonMinimazed_Click(object sender, RoutedEventArgs e)
       {
           this.WindowState = WindowState.Minimized;
       }

        private void CloseWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonZodiack_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            TitleText.Text = title[Convert.ToInt32(button.Uid)];
            HoroscopeText.Text = horoscope[Convert.ToInt32(button.Uid)];
        }
    }
}
