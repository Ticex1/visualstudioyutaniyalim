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
using visualstudioyutaniyalim.Classlar;
using visualstudioyutaniyalim.WPFToolBilgileri;

namespace visualstudioyutaniyalim.WPFFormlar
{
    /// <summary>
    /// Interaction logic for tool_bilgileri.xaml
    /// </summary>
    public partial class tool_bilgileri : UserControl
    {
        public tool_bilgileri()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new button_bilgi ());


        }

        private void checkbox_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new CheckBox_bilgi());
        }
 

        private void radiobutton_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new radiobutton_bilgi());
        }

        private void combobox_bilgi(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new combobox_bilgi());
        }

        private void textbox_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new textbox_bilgi());

        }

       private void label_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new label_bilgi());
        }


        private void listbox_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new listbox_bilgi());
        }

       
        private void contextmenustrip_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new contextmenustrip_bilgi());

        }

        private void picturebox_click(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new picturebox_bilgi());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uc_cagir.uc_ekle(Content_icerik, new richtextboxbilgi());

        }
    }
}
