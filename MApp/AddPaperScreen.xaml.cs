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
    /// Interaction logic for AddPaperScreen.xaml
    /// </summary>
    public partial class AddPaperScreen : UserControl
    {
        MainWindow main;

        public AddPaperScreen(MainWindow m)
        {
            InitializeComponent();
            main = m;
        }

        private void addpaper_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = (MainWindow)this.Parent;
            Paper p = new Paper();

            p.setTitle(this.titletext.Text);
            p.setAuthor(this.authortext.Text);
            p.setYear(int.Parse(this.yeartext.Text));
            p.setAbstract(this.abstracttext.Text);
            m.d.addPaper(p);
   
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new Main(main);
        }
    }
}
 