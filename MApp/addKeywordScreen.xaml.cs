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
using Map;

namespace MApp
{
    /// <summary>
    /// Interaction logic for addKeywordScreen.xaml
    /// </summary>
    public partial class addKeywordScreen : UserControl
    {
        public addKeywordScreen()
        {
            InitializeComponent();
            Database d = new Database();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
