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
    /// örnek1.xaml etkileşim mantığı
    /// </summary>
    public partial class örnek1 : UserControl
    {
        public örnek1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rbKirmizi.IsChecked == true)
            {
                MessageBox.Show("Kırmızı seçildi.");
            }
            else if (rbMavi.IsChecked == true)
            {
                MessageBox.Show("Mavi seçildi.");
            }
            else if (rbTuruncu.IsChecked == true)
            {
                MessageBox.Show("Turuncu seçildi");
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }
    }
}
