﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Database d;

        public MainWindow()
        {
            InitializeComponent();
            d = new Database();
        }

        private void addKeywordButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new addKeywordScreen();
        }

        private void AddPaperButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new AddPaperScreen();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
