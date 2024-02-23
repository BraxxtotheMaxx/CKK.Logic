﻿using CKK.Logic.Models;
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

namespace CKK.UI
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
       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store tp = (Store)Application.Current.FindResource("GlobStore");
            InventoryDis inven=new InventoryDis(tp);
            inven.Show();
            this.Close();
        }


    }
}