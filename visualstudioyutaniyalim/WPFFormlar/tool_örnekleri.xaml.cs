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

namespace visualstudioyutaniyalim.WPFFormlar
{
    /// <summary>
    /// tool_örnekleri.xaml etkileşim mantığı
    /// </summary>
    public partial class tool_örnekleri : UserControl
    {
        public tool_örnekleri()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Classlar.uc_cagir.uc_ekle(Content_icerik, new WPFToolÖrnekleri.örnek1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Classlar.uc_cagir.uc_ekle(Content_icerik, new WPFToolÖrnekleri.örnek2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Classlar.uc_cagir.uc_ekle(Content_icerik, new WPFToolÖrnekleri.örnek3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Classlar.uc_cagir.uc_ekle(Content_icerik, new WPFToolÖrnekleri.örnek4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Classlar.uc_cagir.uc_ekle(Content_icerik, new WPFToolÖrnekleri.örnek5());
        }
    }
}
