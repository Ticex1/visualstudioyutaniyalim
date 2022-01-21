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
using System.IO;


using Microsoft.Win32;

namespace visualstudioyutaniyalim.WPFFormlar
{
    /// <summary>
    /// Interaction logic for tool_eslestirme.xaml
    /// </summary>
    public partial class tool_eslestirme : UserControl
    {
        public tool_eslestirme()
        {
            InitializeComponent();
            comboBox.Items.Add("Tıkla");
            listBox.Items.Add("Tıkla");

        }
        #region ifKontrol
        public void ifKontrol(RadioButton Rcheck)
        {


            if (Rcheck.IsChecked == true)
            {
                MessageBox.Show("Doğru");
            }

            else
            {

                MessageBox.Show("Yanlış veya boş seçim yaptınız");


            }


        }
        #endregion


        #region Eşleşme Click Kontrol
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ifKontrol(buttonRadio);
        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            ifKontrol(checkboxRadio);
        }
        #endregion

        private void radioButton_Click(object sender, RoutedEventArgs e)
        {
            ifKontrol(radioButton1);
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                ifKontrol(comboboxRadio);
            }
            comboBox.SelectedItem = null;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text == "C#" || textBox.Text == "c#")
            {
                ifKontrol(textboxRadio);
                textBox.Text = null;
            }


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                ifKontrol(listboxRadio);
            }

            listBox.SelectedItem = null;
        }

        private void label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ifKontrol(labelRadio);
        }



        private void menuItem_Click(object sender, RoutedEventArgs e)
        {
            ifKontrol(contextmenuRadio);

        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ifKontrol(imageRadio);
        }
        
        
        void LoadXamlPackage(string _fileName)
        {
            TextRange range;
            FileStream fStream;
            if (File.Exists(_fileName))
            {
                range = new TextRange(richtextBox.Document.ContentStart, richtextBox.Document.ContentEnd);
                fStream = new FileStream(_fileName, FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.Text);
                fStream.Close();
            }
        }

        private void dosyaButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string text = File.ReadAllText(openFileDialog.FileName);
                if (text == "c#" || text == "C#")
                {
                    ifKontrol(richtextboxRadio);
                }
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                LoadXamlPackage(openFileDialog.FileName);
            }
        }
    }
}
