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

namespace WpfLabGroup99
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cHour = 0;
        public MainWindow()
        {
            InitializeComponent();
            hours.ItemsSource = Enumerable.Range(0, 24);
            hours.SelectedIndex = 24;
        }
        /// <summary>
        /// Denna kod används för att generera nya instanser av TrafficPredctions.
        /// När man väljer Hours och sedan trycker view visas alltså hela tiden en ny
        /// helt random instans.
        /// </summary>


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var data = new List<TrafficPrediction>();  // lista skapas för 
            int Hours = (int)hours.SelectedItem;
            var rnd = new Random();
            for (int i = 0; i < Hours; i++)
            {
                double temp = rnd.NextDouble() * 40 - 10;
                var forecast = new TrafficPrediction
                {
                    TrafficIntensities =
                   (TrafficIntensities)rnd.Next(Enum.GetValues(typeof(TrafficIntensities)).Length),
                    FlowSpeed = temp,
                    CarVolume = temp + rnd.NextDouble() * 15,
                    Temperatures = rnd.Next(10) > 5 ? rnd.NextDouble() * 10 : 0,
                    TimeLine = i
                };
                data.Add(forecast);
            }


            DataContext = data;

        }

        /// <summary>
        /// Fungerar som en källa som vi refererar till i xaml för att få fram bilden vi la upp på "view" knappen.
        /// </summary>
        public ImageSource Source { get; set; }

     /// <summary>
     /// 
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Cast sender object.
            MenuItem item = sender as MenuItem;
            // ... Change Title of this window.
            this.Title = "Info: " + item.Header;
            if (item.Header.Equals("One"))
            {
                //if (cHour>1)
                //cHour -= cHour;
            }
            else if (item.Header.Equals("two"))
            {
                //if (cHour > 2)
                //cHour -= cHour;
                //cHour -= cHour;
            }
            else if (item.Header.Equals("three"))
            {
                //if (cHour > 3)
            }


        }
        
    }

}
