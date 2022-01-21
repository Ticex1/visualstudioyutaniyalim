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
    /// örnek4.xaml etkileşim mantığı
    /// </summary>
    public partial class örnek4 : UserControl
    {
        public örnek4()
        {
            InitializeComponent();
            cmbResim.Items.Add("Kedi 1");
            cmbResim.Items.Add("Kedi 2");
            cmbResim.Items.Add("Kedi 3");
        }

        private void cmbResim_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int secim = cmbResim.SelectedIndex;
            switch (secim)
            {
                case 0:
                    image1.Source = new BitmapImage(new Uri(@"image\kedi1.jpg", UriKind.Relative));


                    break;
                case 1:
                    image1.Source = new BitmapImage(new Uri(@"image\kedi2.jpg", UriKind.Relative));
                    break;
                case 2:
                    image1.Source = new BitmapImage(new Uri(@"image\kedi3.jpg", UriKind.Relative));
                    break;

            }
        }
    }
}
