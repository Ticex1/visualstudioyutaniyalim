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
    /// örnek2.xaml etkileşim mantığı
    /// </summary>
    public partial class örnek2 : UserControl
    {
        public örnek2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int kisaKenar, uzunKenar, cevre, alan;
                kisaKenar = Convert.ToInt32(txtKısa.Text);
                uzunKenar = Convert.ToInt32(txtUzun.Text);
                cevre = 2 * (kisaKenar + uzunKenar);
                alan = kisaKenar * uzunKenar;
                lblAlan.Content = "Alan: " + alan;
                lblCevre.Content = "Çevre: " + cevre;
            }
            catch
            {
                MessageBox.Show("Yanlış Giriş Yaptınız");
            }
        }
    }
}
