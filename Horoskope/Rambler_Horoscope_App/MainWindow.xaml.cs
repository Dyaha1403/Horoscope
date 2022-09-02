using System.Windows;
using System.Windows.Input;
using Class_Library_For_Pase;

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

        private void ButtonAries_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[0];

            HoroscopeText.Text = horoscope[0];
        }

        private void ButtonTaurus_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[1];

            HoroscopeText.Text = horoscope[1];
        }

        private void ButtonGemini_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[2];

            HoroscopeText.Text = horoscope[2];
        }

        private void ButtonCancer_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[3];

            HoroscopeText.Text = horoscope[3];
        }

        private void ButtonLeo_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[4];

            HoroscopeText.Text = horoscope[4];
        }

        private void ButtonVirgo_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[5];

            HoroscopeText.Text = horoscope[5];
        }

        private void ButtonLibra_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[6];

            HoroscopeText.Text = horoscope[6];
        }

        private void ButtonScorpio_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[7];

            HoroscopeText.Text = horoscope[7];
        }

        private void ButtonSagittar_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[8];

            HoroscopeText.Text = horoscope[8];
        }

        private void ButtonCaprico_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[9];

            HoroscopeText.Text = horoscope[9];
        }

        private void ButtonAquarius_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[10];

            HoroscopeText.Text = horoscope[10];
        }

        private void ButtonPisces_Click(object sender, RoutedEventArgs e)
        {
            TitleText.Text = title[11];

            HoroscopeText.Text = horoscope[11];
        }
    }
}
