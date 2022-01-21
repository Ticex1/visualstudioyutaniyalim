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

namespace visualstudioyutaniyalim.WPFToolÖrnekleri
{
    /// <summary>
    /// örnek5.xaml etkileşim mantığı
    /// </summary>
    public partial class örnek5 : UserControl
    {
        public örnek5()
        {
            InitializeComponent();
        }

        

        private void menuItem1_Click(object sender, RoutedEventArgs e)
        {

            icerik.Background = Brushes.Red;
        }

        private void menuItem2_Click(object sender, RoutedEventArgs e)
        {
            icerik.Background = Brushes.Blue;
        }

        private void menuItem3_Click(object sender, RoutedEventArgs e)
        {
            icerik.Background = Brushes.Green;
        }
    }
}
