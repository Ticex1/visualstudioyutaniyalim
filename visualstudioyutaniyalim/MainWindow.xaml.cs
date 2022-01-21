
using System.Windows;
using System.Windows.Input;
using visualstudioyutaniyalim.Classlar;
using visualstudioyutaniyalim.WPFFormlar;

namespace visualstudioyutaniyalim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
       
            InitializeComponent();
            uc_cagir.uc_ekle(Content_icerik, new ana_sayfa());


        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }


        private void btn_toolbilgileri_Click(object sender, RoutedEventArgs e)
        {
            
            uc_cagir.uc_ekle(Content_icerik, new tool_bilgileri());
            sayfaAd.Content="Tool Bilgileri";
            
        }

        private void btn_eslestirme_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new tool_eslestirme());
            sayfaAd.Content = "Tool Eşleştirme";

        }

        private void btn_büyüt_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }

        }

        private void btn_küçült_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new ana_sayfa());
            sayfaAd.Content = "Ana Sayfa";
        }

        private void tool_örnekleri_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new tool_örnekleri());
            sayfaAd.Content = "Tool Örnekleri";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new hakkımızda());
            sayfaAd.Content = "Hakkımızda";
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
