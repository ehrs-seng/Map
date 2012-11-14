using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MApp
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        MainWindow main;

        public Main(MainWindow m)
        {
            InitializeComponent();
            main = m;
        }

        private void AddPaperButton_Click_1(object sender, RoutedEventArgs e)
        {
            AddPaperScreen p = new AddPaperScreen(main);
            main.Content = p;
        }

        private void AddKeyword_Click(object sender, RoutedEventArgs e)
        {
            addKeywordScreen k = new addKeywordScreen(main);
            main.Content = k;
        }
    }
}
