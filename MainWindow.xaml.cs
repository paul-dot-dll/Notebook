using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using Microsoft.Win32;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //opens file dialog
            SaveFileDialog SaveWindow = new SaveFileDialog();
            SaveWindow.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            if (SaveWindow.ShowDialog() == true)
            {
                //writes text in textbox to the selected file
                File.WriteAllText(SaveWindow.FileName, TextB.Text);
            }
        }

        private void LoadBTN_Click(object sender, RoutedEventArgs e)
        {
            //opens file dialog
            OpenFileDialog LoadWindow = new OpenFileDialog();
            LoadWindow.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            if (LoadWindow.ShowDialog() == true)
            {
                //sets textbox text to text that was in file
                TextB.Text = File.ReadAllText(LoadWindow.FileName);
            }
        }

        private void TextB_TextChanged(object sender, TextChangedEventArgs e)
        {
            return;
        }
    }
}
