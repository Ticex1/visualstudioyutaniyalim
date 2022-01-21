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
    /// örnek3.xaml etkileşim mantığı
    /// </summary>
    public partial class örnek3 : UserControl
    {
        public örnek3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    listbox.Items.Add(i + "x" + j + "=" + i * j);
                }
                listbox.Items.Add("==============");
            }
        }
    }
}
