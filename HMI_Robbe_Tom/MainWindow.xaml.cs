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

namespace HMI_Robbe_Tom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool AanUit = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ImageButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ClickAanUit(object sender, MouseButtonEventArgs e)
        {
            if (AanUit == true)
            {
                Uri uri = new Uri("ON_OFF_schakelaar_foto_OFF.png", UriKind.Relative);

                aanUitKnopFoto.Source = new BitmapImage(uri);
                AanUit = false;
            }
            else
            {
                Uri uri = new Uri("ON_OFF_schakelaar_foto_ON.png", UriKind.Relative);

                aanUitKnopFoto.Source = new BitmapImage(uri);
                AanUit = true;
            }
        }
    }
}
