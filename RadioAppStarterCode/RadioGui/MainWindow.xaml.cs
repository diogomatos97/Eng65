using RadioApp;
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

namespace WpfAppTest
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio r = new Radio();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
          
            Player.Play();
        }

        private void Off1_Click(object sender, RoutedEventArgs e)
        {
            Player.Stop();
        }

        private void volumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (volumeSlider != null)
            {


                Player.Volume = volumeSlider.Value / 100;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (sender.Equals(Radio1))
            {
                RName.Text = r.Name(1);
                Player.Source = new Uri(r.ChannelOn(1), UriKind.RelativeOrAbsolute);
                Player.Play();
            }
            else if (sender.Equals(Radio2))
            {
                RName.Text = r.Name(2);
                Player.Source = new Uri(r.ChannelOn(2), UriKind.RelativeOrAbsolute);
                Player.Play();

            }
            else if (sender.Equals(Radio3)) {
                RName.Text = r.Name(3);
                Player.Source = new Uri(r.ChannelOn(3), UriKind.RelativeOrAbsolute);
                Player.Play();
            }
            else {
                RName.Text = r.Name(4);
                Player.Source = new Uri(r.ChannelOn(4), UriKind.RelativeOrAbsolute);
                Player.Play();
            }
          
            
        }

        
    }
}
